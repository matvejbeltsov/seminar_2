using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static int second_chislo(int chislo){
            int result = 0;
            if (chislo >= 100 && chislo <= 999){
                result = chislo / 10 % 10;
            }
            else{
                Console.WriteLine("Введено неверное число. Введите число от 100 до 999");
                chislo = Convert.ToInt32(Console.ReadLine());
                if (chislo >= 100 && chislo <= 999){
                result = chislo / 10 % 10;
                }
            }
            return result; 
        }

       
        static void Main(string[] args)
        {
           Console.WriteLine("Введите число от 100 до 999");
           int chislo = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(second_chislo(chislo));
        }
    }
}
