using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Japanese;
using MvvmHelpers;
using MvvmHelpers.Interfaces;

namespace FrameShadowDemo.Pages
{
    public class CardListViewModel : BaseViewModel
    {

        string _introFooter;
        string _introTitle;
        string _pageTitle;

        public string IntroFooter { get => _introFooter; set => SetProperty(ref _introFooter, value); }
        public string IntroTitle { get => _introTitle; set => SetProperty(ref _introTitle, value); }
        public string PageTitle { get => _pageTitle; set => SetProperty(ref _pageTitle, value); }

        public IAsyncCommand<string> OpenPageCmd { get; set; }

        #region Properties
        public int cardSetId;         public string cardSetName;

        private ObservableCollection<Phrase> _phrases = new ObservableCollection<Phrase>();
        public ObservableCollection<Phrase> Phrases { get => _phrases; set => SetProperty(ref _phrases, value); }

        bool _MessageGridVisible = false;
        public bool MessageGridVisible { get => _MessageGridVisible; set => SetProperty(ref _MessageGridVisible, value); }

        public string SectionFooter { get => _sectionFooter; set => SetProperty(ref _sectionFooter, value); }
        public string SectionTitle { get => _sectionTitle; set => SetProperty(ref _sectionTitle, value); }
        string _sectionFooter;
        string _sectionTitle;
        #endregion

        #region Commands
        public ICommand HBtnCmd { get; set; }
        public ICommand F1BtnCmd { get; set; }
        public ICommand F2BtnCmd { get; set; }
        public ICommand F3BtnCmd { get; set; }
        public ICommand F4BtnCmd { get; set; }
        public ICommand F5BtnCmd { get; set; }
        #endregion

        public void SetIntroFooter()
        {
            IntroFooter = "There are 100 cards in this card set.";
        }

        public async Task OnAppearing()
        {
            IsBusy = true;
            await Task.Delay(40);
            //Phrases = new ObservableCollection<Phrase>(App.DB.GetPhrasesForCardSet(cardSetId));
            List<Phrase> list = new List<Phrase>();
            for (int i = 1; i <= 100; i++)
            {
                Phrase ph = new Phrase();
                ph.English = "English" + i;
                ph.PhraseId = i + "";
                ph.PhraseNum = i;
                list.Add(ph);
            }
            Phrases = new ObservableCollection<Phrase>(list);
            var num = 1;
            foreach (var x in Phrases) { x.Row = num++; }
            SectionTitle = "Cards";
            SectionFooter = "Tap H to mark a card as hidden so it won't be included in the deck. Tapping buttons 1 through 5 will add the card to one of your Favorite collections F1 through F5";
            MessageGridVisible = true;
            IsBusy = false;
        }
        public CardListViewModel()
        {
            IntroTitle = "Contents";
            SectionTitle = "Information";
            SectionFooter = "Fetching card details, please be patient";
            IsBusy = true;
        }
    }
}
