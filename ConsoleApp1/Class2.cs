using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
    public string Városnevek { get; set; }
    public int Irányítószám { get; set; }

    public int Kordináták { get; set; } 

        public Városnevek(int id) { }
        public Városnevek()
        {
            var a = sor.Split(";");
            Városnevek = a[0];
            Irányítószám = a[1];
            Kordináták = a[2];
        }
        public override string? 
        {
            return $"Városnevek: {Városnevek}, Irányítószám: {Irányítószám}, Kordináták: {KoKordináták}";

        





    }
}
