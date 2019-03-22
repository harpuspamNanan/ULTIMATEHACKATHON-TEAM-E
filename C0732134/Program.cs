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

            /*  Harpuspam Nanan [c0732134]
             *  Sidharath Aggarwal
             *  Harpreet Singh
             *  Shingharjeet Singh
             *  Bableen Kaur
             *  Harman Singh
             *  Harshil Jariwala
             *  Nirmal Patel
             *  Tirth Patel
             *  Akash Rabari  
             */
            Console.WriteLine(FindInArray());

            Console.ReadLine();
        }

        public static int FindInArray()
        {
            string[] vowels = { "a", "e", "i", "o", "u" };
            string input;
            input = Console.ReadLine();
            for (int i = 0; i < vowels.Length; i++)
            {
                if (input == vowels[i])
                    return 1;
                else
                    return -1;
            }
            return 1;

        }

    }
}
            
       

        


        
