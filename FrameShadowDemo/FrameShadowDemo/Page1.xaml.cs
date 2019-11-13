using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FrameShadowDemo
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            DropBoxService dbs = new DropBoxService();
            dbs.Authorize();
        }
    }
}
