// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

        int [] nombreDeTableau = new int [3];

        nombreDeTableau [0] = 1;
        nombreDeTableau [1] = 2;
        nombreDeTableau [2] = 3;

        Console.WriteLine(nombreDeTableau [0]);
        Console.WriteLine(nombreDeTableau [1]);
        Console.WriteLine(nombreDeTableau [2]);


        int [] nDeTableau2 = new int [3];

        nDeTableau2 [0] = 4;
        nDeTableau2 [1] = 5;
        nDeTableau2 [2] = 6;
        

        Console.WriteLine(nDeTableau2 [0]);
        Console.WriteLine(nDeTableau2 [1]);
        Console.WriteLine(nDeTableau2 [2]);


        int [] grandTableau= new int [6];

        grandTableau[0]= nombreDeTableau [0];
        grandTableau[1]= nombreDeTableau [1];
        grandTableau[2]= nombreDeTableau [2];
        grandTableau[3]= nDeTableau2 [0];
        grandTableau[4]= nDeTableau2 [1];
        grandTableau[5]= nDeTableau2 [2];
        
        



        Console.WriteLine(nombreDeTableau [0]);
        Console.WriteLine(nombreDeTableau [1]);
        Console.WriteLine(nombreDeTableau [2]);
        Console.WriteLine(nDeTableau2 [0]);
        Console.WriteLine(nDeTableau2 [1]);
        Console.WriteLine(nDeTableau2 [2]);
    








        }
    }
}
