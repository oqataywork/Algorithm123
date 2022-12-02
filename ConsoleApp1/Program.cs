using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // лист степеней двойки и его заполнение
            List<int> powersList = new List<int>();
            powersList.Add(0);
            powersList.Add(1);

            int factor = 2;
            int multiplied = 1;

            int counter = 25; // увеличить, если число будет большим
            for (int i = 0; i < counter; i++) 
            {
                multiplied = factor * multiplied;
                powersList.Add(multiplied);
               // Console.WriteLine(powersList.ElementAt(i+2));
            }





            Console.WriteLine("Введите сумму из степеней двойки");
            string d = Console.ReadLine();
            int number = (int.Parse(d));

            List<int> range = new List<int>();
            for (int i = 0; i < powersList.Count; i++)
            {
                if (number > powersList[i])
                {
                    range.Add(powersList[i]);
                }
                else
                {
                    break;
                }
            }



           
            List<int> answer = new List<int>();
            for (int i = range.Count-1; i > 0; i-- )
            {
                if ((number - range.ElementAt(i)) >= 0)
                {
                    number -= range.ElementAt(i);
                    answer.Add(range.ElementAt(i));
                }
              
                if (i == 0)
                {
                    Console.WriteLine("Введенное число не состояло из степеней двойки");
                }
            }


            for (int i = 0; i < answer.Count; i++)
            {
                Console.Write(answer[i] + ", ");
            }




        }
    }
}
