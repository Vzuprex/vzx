csharp;
using System;
﻿using System.Security.Cryptography.X509Certificates;

namespace vzx
{
    internal class Program
    {
        public static string entrada;
        public static string entradaN1;
        public static string entradaN2;
        public static int Nmero1;
        public static int Nmero2;
        public static int Total;
        static void Main(string[] args)
        {
            STAR();
        }
            public static void STAR()
            {

            Console.WriteLine("🤖:Ingrese el nombre de operacion que quiere realizar: Suma, Resta");
            entrada = Console.ReadLine();

            
                
            if(entrada =="Suma")
            {
                Suma();
            }
            if(entrada =="Resta")
            {
                Resta();
            }
            if(entrada=="Fin")
            {
                Environment.Exit(0);
            }
            

            }
            
        public static void Suma()
        {
            Console.WriteLine("  ██████  █    ██  ███▄ ▄███▓ ▄▄▄      \r\n▒██    ▒  ██  ▓██▒▓██▒▀█▀ ██▒▒████▄    \r\n░ ▓██▄   ▓██  ▒██░▓██    ▓██░▒██  ▀█▄  \r\n  ▒   ██▒▓▓█  ░██░▒██    ▒██ ░██▄▄▄▄██ \r\n▒██████▒▒▒▒█████▓ ▒██▒   ░██▒ ▓█   ▓██▒\r\n▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒░   ░  ░ ▒▒   ▓▒█░\r\n░ ░▒  ░ ░░░▒░ ░ ░ ░  ░      ░  ▒   ▒▒ ░\r\n░  ░  ░   ░░░ ░ ░ ░      ░     ░   ▒   \r\n      ░     ░            ░         ░  ░\r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       \r\n                                       ");
            
            Console.WriteLine("🤖:Ingresa el primer numero que quieras sumar.");
            entradaN1 = Console.ReadLine();
            Console.WriteLine("🤖:Ingresa el segundo numero que quieras sumar.");
            entradaN2 = Console.ReadLine();
            if (int.TryParse(entradaN1, out Nmero1) && int.TryParse(entradaN2, out Nmero2))
            {

                Total = Nmero1 + Nmero2;

                Console.WriteLine("  __          __         .__   \r\n_/  |_  _____/  |______  |  |  \r\n\\   __\\/  _ \\   __\\__  \\ |  |  \r\n |  | (  <_> )  |  / __ \\|  |__\r\n |__|  \\____/|__| (____  /____/ :{0}\r\n                       \\/      ",Total);
                Console.WriteLine("🤖:Ingresa otra vez la operacion que quieras hacer. Suma o Resta, o fin para salir");
                entrada = Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Resta()
        {
            Console.WriteLine(" ██▀███  ▓█████   ██████ ▄▄▄█████▓ ▄▄▄      \r\n▓██ ▒ ██▒▓█   ▀ ▒██    ▒ ▓  ██▒ ▓▒▒████▄    \r\n▓██ ░▄█ ▒▒███   ░ ▓██▄   ▒ ▓██░ ▒░▒██  ▀█▄  \r\n▒██▀▀█▄  ▒▓█  ▄   ▒   ██▒░ ▓██▓ ░ ░██▄▄▄▄██ \r\n░██▓ ▒██▒░▒████▒▒██████▒▒  ▒██▒ ░  ▓█   ▓██▒\r\n░ ▒▓ ░▒▓░░░ ▒░ ░▒ ▒▓▒ ▒ ░  ▒ ░░    ▒▒   ▓▒█░\r\n  ░▒ ░ ▒░ ░ ░  ░░ ░▒  ░ ░    ░      ▒   ▒▒ ░\r\n  ░░   ░    ░   ░  ░  ░    ░        ░   ▒   \r\n   ░        ░  ░      ░                 ░  ░\r\n                                            ");

            Console.WriteLine("🤖:Ingresa el primer numero que quieras sumar Restar.");
            entradaN1 = Console.ReadLine();
            Console.WriteLine("🤖:Ingresa el segundo numero que quieras Restar.");
            entradaN2 = Console.ReadLine();
            if(int.TryParse(entradaN1,out Nmero1) && int.TryParse(entradaN2, out Nmero2))
            {
            Total = Nmero1 - Nmero2;

            
                Console.WriteLine("  __          __         .__   \r\n_/  |_  _____/  |______  |  |  \r\n\\   __\\/  _ \\   __\\__  \\ |  |  \r\n |  | (  <_> )  |  / __ \\|  |__\r\n |__|  \\____/|__| (____  /____/ :{0}\r\n                       \\/      ", Total);
                Console.WriteLine("🤖:Ingresa otra vez la operacion que quieras hacer. Suma o Resta, o fin para salir");
                entrada = Console.ReadLine();
                Console.Clear();
            }
                
              
            

        }
    }
}
