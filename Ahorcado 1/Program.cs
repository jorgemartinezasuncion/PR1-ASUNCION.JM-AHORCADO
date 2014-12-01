using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado_1
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.SetWindowSize(58, 58);
        
            Console.ForegroundColor = ConsoleColor.Green;

             Console.WriteLine(" _____________  ______________________________________________ ");
             Console.WriteLine("___    |__  / / /_  __ \\__  __ \\_  ____/__    |__  __ \\_  __ \\ ");
             Console.WriteLine("__  /| |_  /_/ /_  / / /_  /_/ /  /    __  /| |_  / / /  / / / ");
             Console.WriteLine("_  ___ |  __  / / /_/ /_  _, _// /___  _  ___ |  /_/ // /_/ /  ");
             Console.WriteLine("/_/  |_/_/ /_/  \\____/ /_/ |_| \\____/  /_/  |_/_____/ \\____/   ");
                                                              
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

          

            Ahorcado a = new Ahorcado();
            Console.WriteLine("Escribe la palabra a jugar:");
            string palabra;

            do{
                palabra = Console.ReadLine();
            }while(!a.setPalabra(palabra));
            do{  //----------------------------------------------------Representar el penxat--------------------------------------------//
                Console.Clear();
                Console.WriteLine(a.mostrarPenxat());
                Console.WriteLine("\r\n");
                Console.WriteLine(a.PalabraOculta);
                try
                {
                    a.setLletra(char.Parse(Console.ReadLine()));
                }
                catch (Exception ae){ }
            } while (!a.comprobaStat());

            Console.Clear();                     // Es netejara la consola cada vegada que se introduisca un caracter, per a que el ahorcado no se acumule.
            Console.WriteLine(a.mostrarPenxat());
            Console.WriteLine("\r\n");
            Console.WriteLine(a.PalabraOculta);
            Console.WriteLine("\r\n");
            if (a.Vida == 0)
            {
                Console.WriteLine("Has perdut");
            }
            else
            {
                Console.Clear();

                    Console.WriteLine(" ██╗  ██╗ █████╗ ███████╗     ██████╗  █████╗ ███╗   ██╗ █████╗ ██████╗  ██████╗     ██╗ ");
                    Console.WriteLine(" ██║  ██║██╔══██╗██╔════╝    ██╔════╝ ██╔══██╗████╗  ██║██╔══██╗██╔══██╗██╔═══██╗    ██║ ");
                    Console.WriteLine(" ███████║███████║███████╗    ██║  ███╗███████║██╔██╗ ██║███████║██║  ██║██║   ██║    ██║ ");
                    Console.WriteLine(" ██╔══██║██╔══██║╚════██║    ██║   ██║██╔══██║██║╚██╗██║██╔══██║██║  ██║██║   ██║    ╚═╝ ");
                    Console.WriteLine(" ██║  ██║██║  ██║███████║    ╚██████╔╝██║  ██║██║ ╚████║██║  ██║██████╔╝╚██████╔╝    ██╗ ");
                    Console.WriteLine(" ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═════╝  ╚═════╝     ╚═╝ ");
                                   
            }
            Console.ReadKey();
            
        }
    }
}
