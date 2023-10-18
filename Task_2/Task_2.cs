using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static int third_number(int chislo){
            int result = 0;
            if(chislo >= 100 &&chislo <= 999){
                result = chislo % 10;
                
            }
            else{
                while (chislo > 999){
                    chislo /= 10;
                }
                result = chislo % 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int chislo = Convert.ToInt32(Console.ReadLine());
            if (chislo < 100){
                Console.WriteLine("Третьей цифры нет");
            }
            else{
            Console.WriteLine(third_number(chislo));
            }
        }   
    }
}
