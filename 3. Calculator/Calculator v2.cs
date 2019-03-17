﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Este es un contenedor/separador de codigos para organizarlos y dar niveles diferentes.
namespace Test6076
{
    // Una clase define los tipos de datos y la funcionalidad que tendrán sus objetos.
    class HerramientaCalculo
    {
        static void Main(string[] args)
        {
            // Metodo Central para la ejecucion de Menu()
            Menu();
        }

        public static void Menu()
        {
            // Sets Básicos
            Console.Clear();
            Console.Title = "Herramienta de Cálculo";
            //System.Threading.Thread.Sleep(2000);
            Console.WriteLine("<==== Calculadora Aritmética | 186076 | 20/02/2019 ====>");
            Console.WriteLine("\n ~ Escoja el operador:");
            Console.WriteLine("\n 1. Adición (+)");
            Console.WriteLine("\n 2. Sustracción (-)");
            Console.WriteLine("\n 3. Multiplicación (*)");
            Console.WriteLine("\n 4. División (/)");
            Console.WriteLine("\n 5. Historial de Operaciones (~)");
            Console.WriteLine("\n 6. Borrado del Historial (!)");
            Console.WriteLine("\n ------------------------------");
            Console.Write("\n ~ Operador: ");
            // Variables de Introducción de Datos
            string Ask = Console.ReadLine();
            string Resp = Ask.ToString();

            switch (Resp)
            {
                case "+":
                    Console.Clear();
                    // Método de Adición (+)
                    Ad();
                    Next();
                    break;

                case "-":
                    Console.Clear();
                    // Método de Sustracción (-)
                    Min();
                    Next();
                    break;

                case "*":
                    Console.Clear();
                    // Método de Multiplicación (*)
                    Mult();
                    Next();
                    break;

                case "/":
                    Console.Clear();
                    // Método de División (/)
                    Div();
                    Next();
                    break;
                case "~":
                    // Método para ver el Historial de Operaciones
                    Hist();
                    Next();
                    break;
                case "!":
                    // Método de Borrado del Historial
                    DelHist();
                    Next();
                    break;
                default:
                    Console.WriteLine("Error...");
                    break;
            }
        }

        private static void Ad()
        {
            // Valores
            double Num1, Num2, Res = 0;
            Console.WriteLine("\n ~~~ Adición ~~~");
            Console.Write("\n ~Valor 1: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("\n ~Valor 2: ");
            Num2 = double.Parse(Console.ReadLine());
            // Resultado de la operación
            Res = Num1 + Num2;
            Console.WriteLine("\n ~Resultado: " + Num1 + " + " + Num2 + " = " + Res);
            Console.WriteLine("\n ------------------------------");
            string Results = "Adición: " + Num1 + " + " + Num2 + " = " + Res + " ";
            StreamWriter Hist = new StreamWriter(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt", true);
            Hist.Write(Results);
            Hist.WriteLine(DateTime.Now);
            Hist.Close();
        }

        private static void Min()
        {
            // Valores
            double Num1, Num2, Res = 0;
            Console.WriteLine("\n ~~~Sustracción ~~~");
            Console.Write("\n ~Valor 1: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("\n ~Valor 2: ");
            Num2 = double.Parse(Console.ReadLine());
            // Resultado de la operación
            Res = Num1 - Num2;
            Console.WriteLine("\n Resultado: " + Num1 + " - " + Num2 + " = " + Res);
            Console.WriteLine("\n ------------------------------");
            string Results = "Sustracción: " + Num1 + " - " + Num2 + " = " + Res + " ";
            StreamWriter Hist = new StreamWriter(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt", true);
            Hist.Write(Results);
            Hist.WriteLine(DateTime.Now);
            Hist.Close();
        }

        private static void Mult()
        {
            // Valores
            double Num1, Num2, Res = 0;
            Console.WriteLine("\n ~~~ Multiplicación ~~~");
            Console.Write("\n ~Valor 1: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("\n ~Valor 2: ");
            Num2 = double.Parse(Console.ReadLine());
            // Resultado de la operación
            Res = Num1 * Num2;
            Console.WriteLine("\n Resultado: " + Num1 + " * " + Num2 + " = " + Res);
            Console.WriteLine("\n ------------------------------");
            string Results = "Multiplicación: " + Num1 + " * " + Num2 + " = " + Res + " ";
            StreamWriter Hist = new StreamWriter(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt", true);
            Hist.Write(Results);
            Hist.WriteLine(DateTime.Now);
            Hist.Close();
        }

        private static void Div()
        {
            // Valores
            double Num1, Num2, Res = 0;
            Console.WriteLine("\n ~~~ División ~~~");
            Console.Write("\n ~Valor 1: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("\n ~Valor 2: ");
            Num2 = double.Parse(Console.ReadLine());
            // Resultado de la operación
            Res = Num1 / Num2;
            Console.WriteLine("\n Resultado: " + Num1 + " / " + Num2 + " = " + Res);
            Console.WriteLine("\n ------------------------------");
            string Results = "División: " + Num1 + " / " + Num2 + " = " + Res + " ";
            StreamWriter Hist = new StreamWriter(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt", true);
            Hist.Write(Results);
            Hist.WriteLine(DateTime.Now);
            Hist.Close();
        }

        private static void Next()
        {
            // Verifica si el usuario desea realizar más operaciones
            System.Threading.Thread.Sleep(800);
            Console.Write("\n ¿Desea realizar otra operación? Y/N: ");
            string Query = Console.ReadLine();
            string Resp1 = Query.ToString();
            // Si el usuario lo prefiere, se limpia la pantalla y vuelve al menu principal
            if (Resp1 == "Y" || Resp1 == "y") { Menu(); }
            else
            {
                // Alternativa a "Y", Cierre de la aplicación
                Console.Clear();
                Console.WriteLine("~~~~~~ Saliendo.... ~~~~~~");
                System.Threading.Thread.Sleep(1000);
            }
        }

        private static void Hist()
        {
            string[] HistArray = File.ReadAllLines(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt");
            Console.WriteLine("\n ---- Historial de Operaciones ----");
            foreach (string line in HistArray)
            {
                Console.WriteLine("\n" + line);
            }
            Console.WriteLine("\n ----------------------------------");
        }

        private static void DelHist()
        {
            // Forma de borrar el Historial de Operaciones
            Console.Write("\n Digite 'del' si esta segur@ de que desea borrar el Historial: ");
            string Access = Console.ReadLine();
            if (Access == "del")
            {
                Console.WriteLine("\n ~ Borrando Historial de Operaciones...");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\n ~ Su Historial ha sido borrado! :D");
                Console.WriteLine("\n ------------------------------");
                File.WriteAllText(@"C:\Users\Emil\source\repos\Test6076\Test6076\Historial.txt", String.Empty);
            } else {
                Console.WriteLine("\n ~ Error... :d");
                Console.WriteLine("\n ~ Los datos no fueron borrados... :'d");
            }
        }
    }
}