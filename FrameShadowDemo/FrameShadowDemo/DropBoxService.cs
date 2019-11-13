using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using Dropbox.Api;
using Dropbox.Api.Files;


using Xamarin.Forms;

namespace FrameShadowDemo
{
    public class DropBoxService
    {
        #region Constants

        private const string AppKeyDropboxtoken = "MyDropboxToken";

        private const string ClientId = "s3xczzf9u0wn7bh";
        
        private const string RedirectUri = "https://www.google.com/";


        #endregion

        #region Fields

        /// <summary>
        ///     Occurs when the user was authenticated
        /// </summary>
        public Action OnAuthenticated;

        private string oauth2State;

        #endregion

        #region Properties

        private string AccessToken { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     <para>Runs the Dropbox OAuth authorization process if not yet authenticated.</para>
        ///     <para>Upon completion <seealso cref="OnAuthenticated"/> is called</para>
        /// </summary>
        /// <returns>An asynchronous task.</returns>
        public async Task Authorize()
        {
            if (string.IsNullOrWhiteSpace(this.AccessToken) == false)
            {
                // Already authorized
                this.OnAuthenticated?.Invoke();
                return;
            }

            if (this.GetAccessTokenFromSettings())
            {
                // Found token and set AccessToken 
                return;
            }

            // Run Dropbox authentication
            this.oauth2State = Guid.NewGuid().ToString("N");
            var authorizeUri = DropboxOAuth2Helper.GetAuthorizeUri(OAuthResponseType.Token, ClientId, new Uri(RedirectUri), this.oauth2State);
            var webView = new WebView { Source = new UrlWebViewSource { Url = authorizeUri.AbsoluteUri } };
            webView.Navigated += WebView_Navigated;
            var contentPage = new ContentPage { Content = webView };
            await Application.Current.MainPage.Navigation.PushModalAsync(contentPage);
        }

        private async void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (!e.Url.StartsWith(RedirectUri, StringComparison.OrdinalIgnoreCase))
            {
                // we need to ignore all navigation that isn't to the redirect uri.
                return;
            }

            try
            {
                var result = DropboxOAuth2Helper.ParseTokenFragment(new Uri(e.Url));

                if (result.State != this.oauth2State)
                {
                    return;
                }

                this.AccessToken = result.AccessToken;

                await SaveDropboxToken(this.AccessToken);
                this.OnAuthenticated?.Invoke();
            }
            catch (Exception ex)
            {
                // There was an error in the URI passed to ParseTokenFragment
            }
            finally
            {
                //e.Cancel = true;
                if (Application.Current.MainPage.Navigation.ModalStack.Count > 0)
                    await Application.Current.MainPage.Navigation.PopModalAsync();
            }
        }

        public async Task<IList<Metadata>> ListFiles()
        {
            try
            {
                using (var client = this.GetClient())
                {
                    var list = await client.Files.ListFolderAsync(string.Empty);
                    return list?.Entries;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public async Task<byte[]> ReadFile(string file)
        {
            try
            {
                using (var client = this.GetClient())
                {
                    var response = await client.Files.DownloadAsync(file);
                    var bytes = response?.GetContentAsByteArrayAsync();
                    return bytes?.Result;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public async Task<FileMetadata> WriteFile(byte[] fileContent, string filename)
        {
            try
            {
                var commitInfo = new CommitInfo(filename, WriteMode.Overwrite.Instance, false, DateTime.Now);

                using (var client = this.GetClient())
                {
                    var metadata = await client.Files.UploadAsync(commitInfo, new MemoryStream(fileContent));
                    return metadata;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Saves the Dropbox token to app settings
        /// </summary>
        /// <param name="token">Token received from Dropbox authentication</param>
        private static async Task SaveDropboxToken(string token)
        {
            if (token == null)
            {
                return;
            }

            try
            {
                Application.Current.Properties.Add(AppKeyDropboxtoken, token);
                await Application.Current.SavePropertiesAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private DropboxClient GetClient()
        {
            return new DropboxClient(this.AccessToken);
        }

        /// <summary>
        ///     Tries to find the Dropbox token in application settings
        /// </summary>
        /// <returns>Token as string or <c>null</c></returns>
        private bool GetAccessTokenFromSettings()
        {
            try
            {
                if (!Application.Current.Properties.ContainsKey(AppKeyDropboxtoken))
                {
                    return false;
                }

                this.AccessToken = Application.Current.Properties[AppKeyDropboxtoken]?.ToString();
                if (this.AccessToken != null)
                {
                    this.OnAuthenticated.Invoke();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        private async void WebViewOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (!e.Url.StartsWith(RedirectUri, StringComparison.OrdinalIgnoreCase))
            {
                // we need to ignore all navigation that isn't to the redirect uri.
                return;
            }

            try
            {
                var result = DropboxOAuth2Helper.ParseTokenFragment(new Uri(e.Url));

                if (result.State != this.oauth2State)
                {
                    return;
                }

                this.AccessToken = result.AccessToken;

                await SaveDropboxToken(this.AccessToken);
                this.OnAuthenticated?.Invoke();
            }
            catch (Exception ex)
            {
                // There was an error in the URI passed to ParseTokenFragment
            }
            finally
            {
                e.Cancel = true;
                if (Application.Current.MainPage.Navigation.ModalStack.Count > 0)
                    await Application.Current.MainPage.Navigation.PopModalAsync();
            }
        }

        #endregion
    }
}