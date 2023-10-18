using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int day_of_weekend = Convert.ToInt32(Console.ReadLine());
            if (day_of_weekend >= 1 && day_of_weekend <= 7){
                if (day_of_weekend == 6 || day_of_weekend == 7){
                    Console.WriteLine("Да");
                }
                else{
                    Console.WriteLine("Нет");
                }
            }
            else{
                Console.WriteLine("В неделе не может быть больше 7 или меньше 7 дней. Введите число корректно!");
                day_of_weekend = Convert.ToInt32(Console.ReadLine());
                if (day_of_weekend >= 1 && day_of_weekend <= 7){
                if (day_of_weekend == 6 || day_of_weekend == 7){
                    Console.WriteLine("Да");
                }
                else{
                    Console.WriteLine("Нет");
                }
            }
            }
        }   
    }
}
