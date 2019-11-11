using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrameShadowDemo
{
    [QueryProperty("Name", "name")]
    [QueryProperty("RowId", "rowId")]
    public partial class CardListPage : BackArrowScrollableView
    {

        //CardListViewModel vm;

        int cardSetId;
        string cardSetName;

        public string Name { set => cardSetName = Uri.UnescapeDataString(value); }
        public string RowId { set => cardSetId = Int32.Parse(value); }

        public CardListPage()
        {
            InitializeComponent();
            //BindingContext = vm = new CardListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //vm.cardSetId = cardSetId;             //vm.cardSetName = cardSetName;
            this.PageTitle = cardSetName + " Card Set";
            //vm.SetIntroFooter();
            //await Task.Run(async () => await vm.OnAppearing());
        }

    }

}