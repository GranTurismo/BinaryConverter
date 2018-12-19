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
            Binary.Text = ActionSelector();   
        }

        private string ActionSelector()
        {
            return isDecToBin ? DectToBin() : BinToDec();
        }

        private string BinToDec()
        {
            string blackAc = Decimal.Text;
            int result = 0;
            for(int i=1;i<=blackAc.Length;i++)
            {
                result+=(int)(int.Parse(blackAc[i-1].ToString()) * Math.Pow(2,blackAc.Length - i));
            }
            return result.ToString();
        }

        private string DectToBin()
        {
            Stack<int> stack = new Stack<int>();
            int dec = Int32.Parse(Decimal.Text);
            while (dec >= 1)
            {
                stack.Push(dec % 2);
                dec /= 2;
            }
            string result = "";
            while (stack.Count > 0)
                result += stack.Pop();
            return result;
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
