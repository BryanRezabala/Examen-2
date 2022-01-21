using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Singleton.Instance.mensaje = "Lista de menu de comida en la costa";
            Singleton.Instance.mensaje = "Menu 1: Seco de pollo";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del primer Menu

            Singleton.Instance.mensaje = "Menu 2: aguado";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del segundo Menu

            Singleton.Instance.mensaje = "Menu 3: Tigrillo";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del tercer Menu

            Singleton.Instance.mensaje = "Menu 4: Cevich";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del cuarto Menu

            Singleton.Instance.mensaje = "Menu 5: Bollo de pescado";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del quinto Menu

            Singleton.Instance.mensaje = "Menu 6: Cangreso criollo";
            Console.WriteLine(Singleton.Instance.mensaje);
            // muestra el nombre del sexto Menu 

            Singleton.Instance.mensaje = "Menu 7: Encocado";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del septimo Menu

            Singleton.Instance.mensaje = "Menu 8: Encebollado";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del octavo Menu

            Singleton.Instance.mensaje = "Menu 9: Corviche";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del noveno Menu

            Singleton.Instance.mensaje = "Menu 10: Sangos";
            Console.WriteLine(Singleton.Instance.mensaje);
            //muestra el nombre del decimo Menu

        }


    }
}