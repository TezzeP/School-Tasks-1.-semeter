using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningeKaast600
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello 600 Terninger!");

            Die terning1 = new Die();

            int[] antal = new int[6];

            for (int i = 0; i < 600; i++)
            {
                int valg = terning1.Roll();
                switch (valg)
                {
                    case 1:
                        antal[0]++; break;
                    case 2:
                        antal[1]++; break;
                    case 3:
                        antal[2]++; break;
                    case 4:
                        antal[3]++; break;
                    case 5:
                        antal[4]++; break;
                    case 6:
                        antal[5]++; break;

                  

                }

            }
            for (int i = 0; i < antal.Length; i++)
            {
                Console.WriteLine(antal[i] + "\t");

            }
            /*
            int[] antal = new int[6];
            antal[terning1.FaceValue] = terning1.Roll();
            antal[terning1.FaceValue] = terning1.Roll();
            antal[terning1.FaceValue] = terning1.Roll();
            antal[terning1.FaceValue] = terning1.Roll();
            antal[terning1.FaceValue] = terning1.Roll();
            antal[terning1.FaceValue] = terning1.Roll();
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(antal[i]);
            }
            
             */
             
            Console.Read();
        }
        
    }
}
