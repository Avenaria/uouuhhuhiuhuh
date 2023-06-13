using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uouuhhuhiuhuh
{
    public class magazine
    {
        public string Name;
        public string adres;
        public int Number;
        public magazine(string name, string str, int y)
        {
            this.Name = name;
            adres = str;
            Number = y;
        }
        public void PrintName()
        {
            Console.WriteLine("" + this.Name);
        }
        public void PrintCol_str()
        {
            Console.WriteLine("" + this.adres);
        }
        public void PrintYear()
        {
            Console.WriteLine("" + this.Number);
        }
    }
