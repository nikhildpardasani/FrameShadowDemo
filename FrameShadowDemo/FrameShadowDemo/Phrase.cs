using System.Collections.Generic;
using System.Linq;
using MvvmHelpers;
//using SQLite;


namespace Japanese
{
    public class Phrase : ObservableObject
    {
        bool _F1;
        bool _F2;
        bool _F3;
        bool _F4;
        bool _F5;
        bool _Hidden;

        //[PrimaryKey, NotNull]
        public string PhraseId { get; set; }
        public int PhraseNum { get; set; }
        public int CategoryId { get; set; }
        public string English { get; set; }
        public string Romaji { get; set; }
        public string Kana { get; set; }
        public string Kanji { get; set; }
        public int Modified { get; set; }
        public string WordType { get; set; }
        public bool Hidden { get => _Hidden; set => SetProperty(ref _Hidden, value); }
        public int OneHash { get; set; }
        public int TwoHash { get; set; }
        public int ThreeHash { get; set; }
        public int? FrequencyA { get; set; }
        public int? FrequencyB { get; set; }
        public int? FrequencyC { get; set; }
        public int? JapaneseForBusyPeople { get; set; }
        public int? Jlpt { get; set; }
        public int? Source1 { get; set; }
        public int? Source2 { get; set; }
        public int? Source3 { get; set; }
        public int? Source4 { get; set; }
        public int? Source5 { get; set; }
        public int? Source6 { get; set; }
        public int? Source7 { get; set; }
        public int? Source8 { get; set; }
        public bool Selected { get; set; } 
        public bool Viewed   { get; set; }
        public int Points { get; set; }
        public int? Score { get; set; }
        public bool F1 { get => _F1; set => SetProperty(ref _F1, value); }
        public bool F2 { get => _F2; set => SetProperty(ref _F2, value); }
        public bool F3 { get => _F3; set => SetProperty(ref _F3, value); }
        public bool F4 { get => _F4; set => SetProperty(ref _F4, value); }
        public bool F5 { get => _F5; set => SetProperty(ref _F5, value); }
        public int Row { get; set; }
        public string Meta { get; set; }
    }

    public static class PhraseExtensions
    {
        public static int ViewedCount(this List<Phrase> phrases)
        {
            return phrases.Count(x => x.Viewed == true);
        }
        public static int NotViewedCount(this List<Phrase> phrases)
        {
            return phrases.Count(x => x.Viewed == false);
        }
        public static bool AllViewed(this List<Phrase> phrases)
        {
            return phrases.All(p => p.Viewed);
        }
        public static bool None(this List<Phrase> phrases)
        {
            return phrases.Count() == 0;
        }

    }
}