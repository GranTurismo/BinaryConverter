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
        bool isDecToBin = true;// es gamoiyene da aq dawere is ternaruli if :D gaqvs ukve mzad iq  ro ar akontrolo calke
        //ki aris magram minda ro aq rac sheidzleba cota rame gaketdes,minda maqsimalurad external iyos ra :d
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           Binary.Text = isDecToBin ? Tool.LMethods.DecToBin(Decimal.Text) : Tool.LMethods.BinToDec(Decimal.Text);//vso  // Tool.LMethods.ActionSelector();
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
