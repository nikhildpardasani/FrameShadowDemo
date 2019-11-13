using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FrameShadowDemo
{
    public partial class Page1 : ContentPage
    {
        DropBoxService dbs;
        public Page1()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            dbs = new DropBoxService();
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            dbs.Authorize();
        }

        private async void Btn2_Clicked(object sender, EventArgs e)
        {
            var abc = await dbs.ListFiles();
        }
    }
}
