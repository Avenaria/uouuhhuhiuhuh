using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uouuhhuhiuhuh
{

    class website
    {
        public 
        string name;
        string way;
        string description;
        int id;
        public website(string n, string w, string d, int i ) { 
        name = n;
        way = w;
        description = d;
        id = i;
        }
        static void Print( )
        {
            Console.WriteLine($"Название сайта {} , красткое описание {},расположение , id  {}")
        }
        static void Find ( string n, int id ) {

            Console.WriteLine("Введите название сайта и его id ");
            name= n;


        }



    }
    internal class Program
    { //Напишите метод, который отображает квадрат из
       // некоторого символа.Метод принимает в качестве параметра: длину стороны квадрата, символ
        static void kvadrat(int side) => Console.WriteLine(string.Join("\n", Enumerable.Repeat(new string('*', side), side)));

        static void Main(string[] args)
        { 
            //Задание 2
            //var s = "12321";
            //if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром!");\










        }

    }
    
}
