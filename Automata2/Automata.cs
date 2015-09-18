using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata2
{
    /// <summary>
    /// Universidad Cooperativa de Colombia
    /// Facultad de Ingenieria
    /// Programa Ing. de Sistemas
    /// Juan Guillermo Gómez
    /// 17/08/2015
    /// 
    /// Descripción: Automata que reconoce cadenas: aab+c*ddd
    /// 
    /// </summary>
    public class Automata2
    {

        private String cadena = "";
        private int cont = 0;

        static void Main(string[] args)
        {
            Automata2 objAutomata2 = new Automata2();
            objAutomata2.Init();
        }

        private void Init()
        {
            while(true)
            {
                Console.WriteLine("Ingrese una cadena valida para (aab+c*ddd); Para salir digite S");
                cadena = Console.ReadLine();

                if (cadena.Equals("S"))
                {
                    break;
                }

                cont = 0;
                Q1();
                Console.ReadLine();

            }
        }

        private void Q1()
        {
            Console.WriteLine("En el estado Q1 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'a')
                {
                    cont++;
                    Q2();
                }
                else
                {
                    Console.WriteLine("Cadena no aceptada");
                    return;
                }
            }
        }

        private void Q2()
        {
            Console.WriteLine("En el estado Q2 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'a')
                {
                    cont++;
                    Q3();
                }
                else
                {
                    Console.WriteLine("Cadena no aceptada");
                    return;
                }
            }

        }

        private void Q3()
        {
            Console.WriteLine("En el estado Q3 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'b')
                {
                    cont++;
                    Q4();
                }
                else
                {
                    Console.WriteLine("Cadena no aceptada");
                    return;
                }
            }
        }

        private void Q4()
        {
            Console.WriteLine("En el estado Q4 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'b')
                {
                    cont++;
                    Q4();
                }
                else if (cadena[cont] == 'd')
                {
                    cont++;
                    Q6();
                }
                else if (cadena[cont] == 'c')
                {
                    cont++;
                    Q5();
                }
            }
        }

        private void Q5()
        {
            Console.WriteLine("En el estado Q5 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'c')
                {
                    cont++;
                    Q5();
                }
                else if (cadena[cont] == 'd')
                {
                    cont++;
                    Q6();
                }
            }
        }

        private void Q6()
        {
            Console.WriteLine("En el estado Q6 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'd')
                {
                    cont++;
                    Q7();
                }
                else
                {
                    Console.WriteLine("Cadena no aceptada");
                    return;
                }
            }
        }

        private void Q7()
        {
            Console.WriteLine("En el estado Q7 NO ACEPTACIÓN");

            if (cont < cadena.Length)
            {
                if (cadena[cont] == 'd')
                {
                    cont++;
                    Q8();
                }
                else
                {
                    Console.WriteLine("Cadena no aceptada");
                    return;
                }
            }

        }

        private void Q8()
        {
            Console.WriteLine("En el estado Q8 de ACEPTACIÓN");
        }




    }
}
