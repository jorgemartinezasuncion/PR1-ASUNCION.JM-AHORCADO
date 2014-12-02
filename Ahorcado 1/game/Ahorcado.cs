using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ahorcado_1
{
    class Ahorcado
    {
        private string palabra;
        private string palabraOculta;

        public string PalabraOculta
        {
            get { return palabraOculta; }
        }
        private int vida;

        public int Vida
        {
            get { return vida; }
        }
        public Ahorcado() //Números de intentos inicials.
        {
            vida = 6;
        }
        public string mostrarahorcado()    //-----------------------------------------Construccion del ahorcado ----------------------------------------//
        {
            string ahorcado = "";
            switch (this.vida)
            {
                case 0:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |           /|\\ \r\n" +
                            "  |           / \\ \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 1:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |           /|\\ \r\n" +
                            "  |           /   \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 2:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |           /|\\ \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 3:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |           /|  \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 4:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |            |  \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 5:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |            O  \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
                case 6:
                    ahorcado = "_________________ \r\n" +
                            "  |            |  \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            "  |               \r\n" +
                            " /|\\              \r\n";
                    break;
            }
            return ahorcado;
        }
        public bool setPalabra(string palabra) //----------------------------Part de la representació de la paraula oculta------------------------//
        {
            if (!palabra.Equals("")) //Entrara si la cadena te algo dins
            {
                string PatronBusqueda = "0|1|2|3|4|5|6|7|8|9|_"; // Patró per a filtrar numeros en cas, que no se introduisquen lletres.
                Regex regex = new Regex(PatronBusqueda, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
                if (!regex.Match(palabra).Success)
                {
                    this.palabra = palabra; // ----------Estructura de representació de la paraula oculta.----------//
                    this.palabraOculta = "";
                    for (int i = 0; i < this.palabra.Length; i++)
                    {
                        this.palabraOculta += "_"; //Les lletres de la paraula introduida. es representara per _ per caracter.
                    }
                    return true;
                }
            }
            return false;
        }
        public bool comprobaStat(){ //----------------------------------- Part de finalizació del joc --------------------------------------------//
            bool fin = true;
            for (int i = 0; i < this.palabra.Length; i++)
            {
                if (palabraOculta[i].Equals('_'))//si la paraula conte alguna barra baixa, el joc no sacabat
                {
                    fin = false;//El joc no acaba
                }
            }
            if (vida == 0)      //pero si les vides arriben a 0 dona = si te barres baixes o no
            {
                fin = true;     //El joc s'acaba
            }
            return fin;
        }
        public void setLletra(char lletra)  //-----------------------------------Part de la lletra presionada-------------------------------------// 
        {
            bool exist = false;
            string cadena = "";
            for (int i = 0; i < this.palabra.Length; i++)  //Recorrec la paraula.
            {
                if (this.palabra[i].Equals(lletra))    //Si la lletra coincideix en alguna posicio, safegeix a la paraula oculta.
                {
                    cadena += lletra;
                    exist = true;
                }
                else    //sino, mante la lletra o _ que tenia
                {
                    cadena += this.palabraOculta[i];
                }
            }
            if (!exist)   //si no existeix, reste una vida
            {
                this.vida--;
            }
            this.palabraOculta = cadena;
        }
    }
}
