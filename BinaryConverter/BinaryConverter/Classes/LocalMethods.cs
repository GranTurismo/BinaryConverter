using BinaryConverter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BinaryConverter.Classes
{
    class LocalMethods:ILocalMethods
    {
        public string DecToBin(string Dec)
        {
            Stack<int> stack = new Stack<int>();
            int dec = Int32.Parse(Dec);//ai aq tundac
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

        public string BinToDec(string Dec)
        {
            string blackAc = Dec;
            int result = 0;
            for (int i = 1; i <= blackAc.Length; i++)
            {
                result += (int)(int.Parse(blackAc[i - 1].ToString()) * Math.Pow(2, blackAc.Length - i));
            }
            return result.ToString();
        }
    }
}
