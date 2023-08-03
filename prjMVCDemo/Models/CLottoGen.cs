using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjMVCDemo.Models
{
    public class CLottoGen
    {
        public string getNembers()
        {
            int count = 0;
            int[] numbers = new int[6];
            Random rand = new Random();
            while(count < 6)
            {
                int temp = rand.Next(1, 50);
                numbers[count] = temp;
                count++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j< numbers.Length; j++) 
                {
                    if (numbers[j] > numbers[j + 1])
                    { 
                        int big = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = big;
                    }

                    string s = " ";
                    foreach (int i in numbers)
                        s += i + " ";
                    return s;
        }
    }
}