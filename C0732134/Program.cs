using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732134
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            string[] letters = new string[4] { "A", "B", "C", "D" };
            string[] names = new string[16] {"Harpuspam", "Sidharath", "Harpreet", "Shingharjeet", "Bableen", "Harman", "Harshil", "Nirmal", "Tirth", "Akash", "Lionel Messi", "Sergio Busquests", "Gerard Pique", "Mohammad Salah", "Wayne Rooney", "Bruce Wayne"};


            for (int j = 0; j <= 3; j++)
            {
                names[j] = names[j] + " " + letters[t];
            }
            t++;
            for (int k = 4; k <= 7; k++)
            {
                names[k] = names[k] + " " + letters[t];
            }
            t++;
            for (int l = 8; l <= 11; l++)
            {
                names[l] = names[l] + " " + letters[t];
            }
            t++;
            for (int m = 12; m <= 15; m++)
            {
                names[m] = names[m] + " " + letters[t];
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            Console.ReadLine();
        }
    }
}
