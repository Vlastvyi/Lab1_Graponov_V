using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сохранение времени начала

            DateTime begin_t = DateTime.Now;

            Console.WriteLine("Программа работает");


            // Здесь можно добавить код, который вы хотите измерить



            // Сохранение времени окончания
            // Сохранение времени окончания


            DateTime end_t = DateTime.Now;

            TimeSpan elapsed = end_t - begin_t;


            Console.WriteLine("Код выполнился за " + elapsed.TotalSeconds + " сек.");
        } 


    }
}