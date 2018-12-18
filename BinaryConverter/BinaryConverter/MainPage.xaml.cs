using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BinaryConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Binary.Text = calculate(Decimal.Text).ToString();   
        }

        private int calculate(string text)
        {
            int dec = 0;
            Stack<int> stack = new Stack<int>();
            dec = Int32.Parse(text);
            while (dec >= 1)
            {
                stack.Push(dec%2);
                dec /= 2;
            }
            string result = "";
            foreach (int item in stack) result += item;
            dec=Int32.Parse(result);
            return dec;
        }
    }
}
