using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadataka5
{
    class NebeskoTijelo
    {
        double brzinaOkoOsi, brzinaOkoSunca;
        public double BrzinaOkoOsi { get => brzinaOkoOsi; set => brzinaOkoOsi = value; }
        public double BrzinaOkoSunca { get => brzinaOkoSunca; set => brzinaOkoSunca = value; }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double o, double s)
        {
            BrzinaOkoOsi = o;
            BrzinaOkoSunca = s;
        }
    }
    class Satelit : NebeskoTijelo
    {
        public Satelit(double o, double s)
        {
            BrzinaOkoOsi = o;
            BrzinaOkoSunca = s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(55.3, 26.5);
            Satelit Mjesec = new Satelit(35.3, 26.25);
            Console.ReadLine();
        }
    }
}
