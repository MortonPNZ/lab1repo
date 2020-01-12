using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
    
            static void Main(string[] args)
            {
                HorizontalLine h1 = new HorizontalLine(0, 15, 0, '*');
                h1.Draw();
                HorizontalLine h2 = new HorizontalLine(0, 15, 10, '*');
                h2.Draw();
                VerticalLine v1 = new VerticalLine(0, 10, 0, '*');
                v1.Draw();
                VerticalLine v2 = new VerticalLine(0, 10, 15, '*');
                v2.Draw();
               

                Console.ReadKey();
            }
        }
    }

