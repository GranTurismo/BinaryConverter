using BinaryConverter.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace BinaryConverter
{
    public partial class MainPage : ContentPage
    {
        bool isDecToBin = true;
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           Binary.Text = isDecToBin ? Tool.LMethods.DecToBin(Decimal.Text) : Tool.LMethods.BinToDec(Decimal.Text);
        }
        private void Invert_Clicked(object sender, EventArgs e)
        {
            string temp;
            temp = DecLabel.Text;
            DecLabel.Text = BinLabel.Text;
            BinLabel.Text = temp;
            Decimal.Text = "";
            Binary.Text = "";
            isDecToBin = !isDecToBin;
        }
    }
}
