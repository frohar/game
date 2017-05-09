using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int digite = getRandomdigite();
            Console.Write("Lotfan Vared Konid Adad " + digite.ToString().Length + " Ragami:");
            int d2 = Convert.ToInt32(Console.ReadLine());

            cmpdigite(digite, d2);

            Console.Read();


        }

        static int getRandomdigite()
        {
            int a;
            Random g = new Random();
            a  = g.Next(9999);
            return a ;
        }
        static List<int> listDigite(int d)
        {
            List<int> x = new List<int>();
            int _d = d;
            do
            {

                x.Add(_d % 10);
                _d = _d / 10;

            } while (_d > 0);
            return x;
        }

        static void cmpdigite(int d1, int d2)
        {
            int str = 0;
            List<int> _d1 = new List<int>();
            List<int> _d2 = new List<int>();
            _d1 = listDigite(d1);
            _d2 = listDigite(d2);

            for (int i = 0; i < _d1.Count; i++)
            {
                str = 0;
                for (int j = 0; j < _d2.Count; j++)
                {
                    if (_d1[i] == _d2[j])
                    {
                        if (i == j)
                            str++;
                        Console.WriteLine(_d1[i]);
                        str++;

                        Console.WriteLine("*" + str);
                    }
                }
            }

        }
    }
}
