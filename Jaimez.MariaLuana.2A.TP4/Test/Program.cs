using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Bolsa bolsa = 6;

            Prenda p1 = new Prenda(1, Prenda.ETipoPrenda.Remera, "Nike", 1500);

            Accesorio a1 = new Accesorio(1, Accesorio.ETipoAc.Reloj, Accesorio.ETipoMaterial.Plata , "Rolex", 5000);

            Prenda p2 = new Prenda(2, Prenda.ETipoPrenda.Pantalon, "Adidas", 1800);

            Accesorio a2 = new Accesorio(2, Accesorio.ETipoAc.Collar, Accesorio.ETipoMaterial.Plata, "Pandora", 2300);

            Prenda p3 = new Prenda(3, Prenda.ETipoPrenda.Pantalon, "Kosiuko", 2000);

            Accesorio a3 = new Accesorio(3, Accesorio.ETipoAc.Pulsera, Accesorio.ETipoMaterial.Acero, "Viceroy", 1650);

            Prenda p4 = new Prenda(4, Prenda.ETipoPrenda.Zapato, "Nike", 4000);
            
            Accesorio a4 = new Accesorio(4, Accesorio.ETipoAc.Collar, Accesorio.ETipoMaterial.Oro, "Graff", 6000);

            bolsa += p1;
            bolsa += p1; //repetido

            bolsa += p2;
            bolsa += a1;
            bolsa += a2;
            bolsa += a3;
            bolsa += a4;

            bolsa += p3; //sin lugar
            bolsa += p4;

            Console.WriteLine();

            Console.WriteLine(p1.Equals(p4));
            
            Console.WriteLine(a2.Equals(a4));

            Console.WriteLine(Bolsa.Mostrar(bolsa));

            Console.ReadLine();
        }
    }
}
