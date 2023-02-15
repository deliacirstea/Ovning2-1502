using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning2_1502
{
    internal class App
    {

        public string GetManyOfSameString(int tal)
        {
            if (tal == 1)
                return "ettor";
            else if (tal == 2)
                return "tvåor";
            else if (tal == 3)
                return "treor";
            else if (tal == 4)
                return "fyror";
            else if (tal == 5)
                return "femmor";
            else if (tal == 6)
                return "sexor";
            return null;
        }
        public void Run()
        {
            var random = new Random();
            while (true)
            {
                var tal1 = random.Next(1, 7);
                var tal2 = random.Next(1, 7);
                var tal3 = random.Next(1, 7);

                if (tal1 == tal2 && tal1 == tal3)
                {
                    var threOfSame = GetManyOfSameString(tal1);
                    Console.WriteLine($"Du fick tre {threOfSame}");
                }
                else if (tal1 == tal2)
                {
                    var twoOfSame = GetManyOfSameString(tal1);
                    var third = GetOneOf(tal3);
                    Console.WriteLine($"Du fick två av {twoOfSame} och en av {third}");
                }
                else if (tal1 == tal3)
                {
                    var twoOfSame = GetManyOfSameString(tal1);
                    var second = GetOneOf(tal2);
                    Console.WriteLine($"Du fick två av {twoOfSame} och en av {second}");
                }
                else if (tal2 == tal3)
                {
                    var twoOfSame = GetManyOfSameString(tal2);
                    var first = GetOneOf(tal1);
                    Console.WriteLine($"Du fick två av {twoOfSame} och en av {first}");
                }

                else
                {
                    var first = GetOneOf(tal1);
                    var second = GetOneOf(tal2);
                    var third = GetOneOf(tal3);
                    Console.WriteLine($"Du fick en {first}, en {second} och en {third}");
                }

                Console.Write("Vill du fortsätta? J/N:");
                var s = Console.ReadLine();
                if (s == "N")
                    break;
            }

        }

        public string GetOneOf(int tal1)
        {
            switch (tal1)
            {
                case 1:
                    return "etta";
                case 2:
                    return "tvåa";
                case 3:
                    return "trea";
                case 4:
                    return "fyra";
                case 5:
                    return "femma";
                case 6:
                    return "sexa";
                default:
                    return null;

            }
        }
    }
}
