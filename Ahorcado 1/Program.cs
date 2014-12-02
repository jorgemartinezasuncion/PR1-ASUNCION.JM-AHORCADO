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
            Console.SetWindowSize(170,58);
        
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
            do{  //----------------------------------------------------Representar el ahorcado--------------------------------------------//
                Console.Clear();
                Console.WriteLine(a.mostrarahorcado());
                Console.WriteLine("\r\n");
                Console.WriteLine(a.PalabraOculta);
                try
                {
                    a.setLletra(char.Parse(Console.ReadLine()));
                }
                catch (Exception ae){ }
            } while (!a.comprobaStat());

            Console.Clear();                     // Es netejara la consola cada vegada que se introduisca un caracter, per a que el ahorcado no se acumule.
            Console.WriteLine(a.mostrarahorcado());
            Console.WriteLine("\r\n");
            Console.WriteLine(a.PalabraOculta);
            Console.WriteLine("\r\n");
            if (a.Vida == 0)
            {
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                                                                           
                    Console.WriteLine("                              ,!MMMMMMM!,                     MM MM  ,.                               ");
                    Console.WriteLine("      ., .M                .MMMMMMMMMMMMMMMM.,          'MM.  MM MM .M'   ██░ ██  ▄▄▄        ██████   ");
                    Console.WriteLine("    . M: M;  M          .MMMMMMMMMMMMMMMMMMMMMM,          'MM,:M M'!M'   ▓██░ ██▒▒████▄    ▒██    ▒   ");
                    Console.WriteLine("   ;M MM M: .M        .MMMMMMMMMMMMMMMMMMMMMMMMMM,         'MM'...'M     ▓██░ ██▒▒████▄    ▒██    ▒   ");
                    Console.WriteLine("    M;MM;M :MM      .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.       .MMMMMMMM     ▒██▀▀██░▒██  ▀█▄  ░ ▓██▄     ");
                    Console.WriteLine("    'M;M'M MM      MMMMMM  MMMMMMMMMMMMMMMMM  MMMMMM.    ,,M.M.'MMM'     ░▓█ ░██ ░██▄▄▄▄██   ▒   ██▒  ");
                    Console.WriteLine("     MM'MMMM      MMMMMM @@ MMMMMMMMMMMMMMM @@ MMMMMMM.'M''MMMM;MM'      ░▓█▒░██▓ ▓█   ▓██▒▒██████▒▒  ");
                    Console.WriteLine("    MM., ,MM     MMMMMMMM  MMMMMMMMMMMMMMMMM  MMMMMMMMM      '.MMM        ▒ ░░▒░▒ ▒▒   ▓▒█░▒ ▒▓▒ ▒ ░  ");
                    Console.WriteLine("    'MM;MMMMMMMM.MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.      'MMM        ▒ ░▒░ ░  ▒   ▒▒ ░░ ░▒  ░ ░  ");
                    Console.WriteLine("     ''.'MMM'  .MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM       MMMM       ░  ░░ ░  ░   ▒   ░  ░  ░    ");
                    Console.WriteLine("      MMC      MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM.      'MMMM      ░  ░  ░      ░  ░      ░    ");
                    Console.WriteLine("     .MM      :MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM''MMM       MMMMM                                                                    ");
                    Console.WriteLine("     MMM      :M  'MMMMMMMMMMMMM.MMMMM.MMMMMMMMMM'.MM  MM:M.    'MMMMM     ██▓███  ▓█████  ██▀███  ▓█████▄  ██▓▓█████▄  ▒█████      ▐██▌ ");
                    Console.WriteLine("    .MMM   ...:M: :M.'MMMMMMMMMMMMMMMMMMMMMMMMM'.M''   MM:MMMMMMMMMMMM'   ▓██░  ██▒▓█   ▀ ▓██ ▒ ██▒▒██▀ ██▌▓██▒▒██▀ ██▌▒██▒  ██▒    ▐██▌ ");
                    Console.WriteLine("   AMMM..MMMMM:M.    :M.'MMMMMMMMMMMMMMMMMMMM'.MM'     MM''''''''''''     ▓██░ ██▓▒▒███   ▓██ ░▄█ ▒░██   █▌▒██▒░██   █▌▒██░  ██▒    ▐██▌ ");
                    Console.WriteLine("   MMMMMMMMMMM:MM     'M'.M'MMMMMMMMMMMMMM'.MC'M'     .MM                 ▒██▄█▓▒ ▒▒▓█  ▄ ▒██▀▀█▄  ░▓█▄   ▌░██░░▓█▄   ▌▒██   ██░    ▓██▒ ");
                    Console.WriteLine("    '''''''''':MM.       'MM!M.'M-M-M-M'M.'MM'        MMM                 ▒██▒ ░  ░░▒████▒░██▓ ▒██▒░▒████▓ ░██░░▒████▓ ░ ████▓▒░    ▒▄▄  ");
                    Console.WriteLine("               MMM.            'MMMM!MMMM'            .MM                 ▒▓▒░ ░  ░░░ ▒░ ░░ ▒▓ ░▒▓░ ▒▒▓  ▒ ░▓   ▒▒▓  ▒ ░ ▒░▒░▒░     ░▀▀▒ ");
                    Console.WriteLine("                MMM.             '''   ''            .MM'                 ░▒ ░      ░ ░  ░  ░▒ ░ ▒░ ░ ▒  ▒  ▒ ░ ░ ▒  ▒   ░ ▒ ▒░     ░  ░ ");
                    Console.WriteLine("                 MMM.                               MMM'                  ░░          ░     ░░   ░  ░ ░  ░  ▒ ░ ░ ░  ░ ░ ░ ░ ▒         ░ ");
                    Console.WriteLine("                  MMMM            ,.J.JJJJ.       .MMM'                               ░  ░   ░        ░     ░     ░        ░ ░      ░    ");
                    Console.WriteLine("                   MMMM.       'JJJJJJJ'JJJM   CMMMMM                    ");
                    Console.WriteLine("                     MMMMM.    'JJJJJJJJ'JJJ .MMMMM'                     ");
                    Console.WriteLine("                       MMMMMMMM.'  'JJJJJ'JJMMMMM'                       ");
                    Console.WriteLine("                         'MMMMMMMMM'JJJJJ JJJJJ'                         ");
                    Console.WriteLine("                            ''MMMMMMJJJJJJJJJJ'                          ");
                    Console.WriteLine("                                    'JJJJJJJJ'							");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Presione cualquier tecla para salir del juego");
  

            }
            else
            {
                Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("                        __________________________________________________________________________________________");
                    Console.WriteLine("         _______________|                                                                                         |_______________ ");
                    Console.WriteLine("         \\              | ██╗  ██╗ █████╗ ███████╗     ██████╗  █████╗ ███╗   ██╗ █████╗ ██████╗  ██████╗     ██╗ |              / ");
                    Console.WriteLine("          \\             | ██║  ██║██╔══██╗██╔════╝    ██╔════╝ ██╔══██╗████╗  ██║██╔══██╗██╔══██╗██╔═══██╗    ██║ |             /  ");
                    Console.WriteLine("           \\            | ███████║███████║███████╗    ██║  ███╗███████║██╔██╗ ██║███████║██║  ██║██║   ██║    ██║ |            /   ");
                    Console.WriteLine("            \\           | ██╔══██║██╔══██║╚════██║    ██║   ██║██╔══██║██║╚██╗██║██╔══██║██║  ██║██║   ██║    ╚═╝ |           /    ");
                    Console.WriteLine("            /           | ██║  ██║██║  ██║███████║    ╚██████╔╝██║  ██║██║ ╚████║██║  ██║██████╔╝╚██████╔╝    ██╗ |           \\   ");
                    Console.WriteLine("           /            | ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝     ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═════╝  ╚═════╝     ╚═╝ |            \\  ");
                    Console.WriteLine("          /             |_________________________________________________________________________________________|             \\ ");
                    Console.WriteLine("         /_______________)                                                                                       (_______________\\");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.Write("Presione cualquier tecla para salir del juego");
            }
            Console.ReadKey();
            
        }
    }
}
