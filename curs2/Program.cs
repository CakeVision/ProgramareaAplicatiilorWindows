using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_AccessorsDelegateInterface
{
    class Prod
    {   
        public delegate double dlgTVA(double v);
        private string denum = "Noname";
        private int cant=0;
        public string Denum
        {
            get { return denum; }
            set 
            {
                if (value.Length > 0)
                    denum = value;
                else denum = "FaraNume";
            }  
        }
        public double Pret { get; set; }
        public int Cant
        {   
            // only in get and set we have to use private members, because otherwise it will self-call to infinity
            get => cant;
            set => cant = value;
        }
        public double Valoare { get => Cant*Pret;}
        public Prod() { }
        public Prod(string d, int c, double p){
            Denum = d; Cant = c; Pret = p;
            pf2 = (x) => x * Valoare;
        }
        public override string ToString(){
            return $"{Denum} : {Cant} x {Pret} = {Valoare}";
        }
        public dlgTVA pf1 = (x) => 0.19*x;
        public dlgTVA pf2;
    }
        
       
    internal class Program
    {
        static void Main(string[] args)
        {

            Prod p1 = new Prod(), p2 = new Prod("Cascaval", 12, 35.5);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2);
            Console.WriteLine($"Produsul {p2.Denum} are TVA de {p2.pf1(p2.Valoare)} lei"); 
            Console.WriteLine($"Produsul {p2.Denum} are TVA de {p2.pf2(0.05)} lei"); 
            
        }
    }
}
