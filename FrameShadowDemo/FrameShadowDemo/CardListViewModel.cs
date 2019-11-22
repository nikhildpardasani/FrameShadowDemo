using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
        public ICommand LoadMorePhrasesCommand { get; set; }

        #region Properties
        public int cardSetId;         public string cardSetName;

        public List<Phrase> Phrases { get; set; }

        private ObservableRangeCollection<Phrase> phraseToDisplay = new ObservableRangeCollection<Phrase>();
        public ObservableRangeCollection<Phrase> PhraseToDisplay
        {
            get => phraseToDisplay;
            set
            {
                SetProperty(ref phraseToDisplay, value);
            }
        }

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

        int batchSize = 10;
        int currentFlightIndex = 0;

        public CardListViewModel()
        {
            IntroTitle = "Contents";
            SectionTitle = "Information";
            SectionFooter = "Fetching card details, please be patient";
            IsBusy = true;
            LoadMorePhrasesCommand = new Xamarin.Forms.Command(LoadMore);
        }


        public void SetIntroFooter()
        {
            IntroFooter = "There are 100 cards in this card set.";
        }

        public async Task OnAppearing()
        {
            IsBusy = true;
            await Task.Delay(40);
            //Phrases = new ObservableCollection<Phrase>(App.DB.GetPhrasesForCardSet(cardSetId));
            Phrases = new List<Phrase>();
            for (int i = 1; i <= 1000; i++)
            {
                Phrase ph = new Phrase();
                ph.English = "English" + i;
                ph.PhraseId = i + "";
                ph.PhraseNum = i;
                Phrases.Add(ph);
            }
            var num = 1;
            foreach (var x in Phrases) { x.Row = num++; }
            SectionTitle = "Cards";
            SectionFooter = "Tap H to mark a card as hidden so it won't be included in the deck. Tapping buttons 1 through 5 will add the card to one of your Favorite collections F1 through F5";
            MessageGridVisible = true;

            PhraseToDisplay = new ObservableRangeCollection<Phrase>(Phrases.Take(batchSize).ToList());
            currentFlightIndex = 0;
            IsBusy = false;
        }

        void LoadMore()
        {
            PhraseToDisplay.AddRange(Phrases.Skip(batchSize + currentFlightIndex).Take(batchSize));
            currentFlightIndex += batchSize;
        }
    }
}
