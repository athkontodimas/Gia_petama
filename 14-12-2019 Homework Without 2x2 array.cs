using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_12_2019_Exercise_Alternative_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chars = new List<string>();
            string[] stringArray = new string[11];
           
            char[] word = { 'C','H','E','S','S','M','A','S','T','E','R' };
            char[] word2 = new char[11] {'|', '|', '|', '|', '|', '|', '|', '|', '|', '|', '|' };

            Random rand = new Random();
            int r;
          for (int i=0; i<11; i++)
            {
                 stringArray[i] = Convert.ToString(word2[i]);
            }

            for (int i = 10; i >= 0; i--)
            {
                r = rand.Next(0,11);
                do
                {
                    for (int j = 10; j >= 0; j--)
                    {
                        if (i == j)
                        {
                            word2[j] = 'X';
                        }
                                                                            
                        if (i!=j && j!=r)
                        {
                            word2[r] = word[j];
                        }
                        

                    }
                } while (i == r);

                stringArray[i] = Convert.ToString(word2[i]);

                Console.Write(stringArray[i]);
            }
        }
    }
}
