using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<tovar> tovarList = new List<tovar>();
            while (true)
            
            {  
                {
                    Console.WriteLine("Введите имя: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Введите Количество: ");
                    int kol = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите стоимость: ");
                    float stoim = Convert.ToInt32(Console.ReadLine());
                    tovarList.Add(new tovar(Name, kol, stoim));
                    Console.Clear();
              
                    for(int i = 0; i < tovarList.Count; i++)
                    {
                        Console.WriteLine("Имя: " + tovarList[i].Name + "Количество : " + tovarList[i].kol + "стоимость: " + tovarList[i].stoim);
                    }
                }
            }
        }
    }
}
