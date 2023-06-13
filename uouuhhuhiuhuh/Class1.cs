using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uouuhhuhiuhuh
{
    public class journal
    {
        public string Name;
        public int str;
        public int year;
        public journal(string name, int col_str, int year)
        {
            this.Name = name;//
            this.str = col_str;
            this.year = year;
        }
        public void PrintName()
        {
            Console.WriteLine("" + this.Name);
        }
        public void PrintCol_str()
        {
            Console.WriteLine("" + this.str);
        }
        public void PrintYear()
        {
            Console.WriteLine("" + this.year);
        }
    }
