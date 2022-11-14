using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Account<T>
    {
        public T Num { get; set; }
        public int Balanse { get; set; }
        public string Name { get; set; }

        //public Account(T num, int balanse, string name)
        //{
        //    Num = num;
        //    Balanse = balanse;
        //    Name = name;
        //}

        public string Getinfo()
        {
            return $"{Num} {Balanse} {Name}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Ввведите баланс карты");
            Balanse = Convert.ToInt32(Console.ReadLine());
        }
    }
}
