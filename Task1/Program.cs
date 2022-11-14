using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер счета");
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите ФИО");
            //string name = Console.ReadLine();
            //int balanse = Convert.ToInt32(Console.ReadLine());
            //Account<int> account1 = new Account<int>(numInt, 100, name );
            //Console.WriteLine(account1.Getinfo());

            //Console.WriteLine("Введите строковый номер счета");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите ФИО");
            //name = Console.ReadLine();
            //balanse = Convert.ToInt32(Console.ReadLine());
            //Account<string> account2 = new Account<string>(numString, 200, name);
            //Console.WriteLine(account2.Getinfo());

            Account<int> account1 = new Account<int>();
            account1.Input();
            Console.WriteLine(account1.Getinfo());

            Account<string> account2 = new Account<string>();
            account2.Input();
            Console.WriteLine(account2.Getinfo());

            Console.ReadKey();
        }
    }
}
