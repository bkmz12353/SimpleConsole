using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            raschet();
        }
       static void raschet()
        {
            double num1;
            double num2;
            string[] znachenia;
            string vvod = Console.ReadLine();
            Console.WriteLine("Введите значения");
      ggo:      try
            {
                znachenia = vvod.Split(' ');
                 num1 = Convert.ToDouble(znachenia[0].Replace('.',','));
                 num2 = Convert.ToDouble(znachenia[1].Replace('.', ','));
            }
            catch
            {
                Console.WriteLine("Некорректные значения! Повторите ввод:");
                goto ggo;
            }
            double num3 = num1 / num2;
            Console.WriteLine("Итоговое значение:");
            Console.WriteLine(num3);
            Console.ReadLine();
            
        }

       
    }
}
