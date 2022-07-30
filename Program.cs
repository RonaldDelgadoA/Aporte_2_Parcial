using System;

namespace Prueba_1
{
    public class Program
    {
        public static void Main(string[] arg)
        {

    
        //Celular #1
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine("");
        var Celular1 = new Dispositivo1();
        Console.WriteLine(Celular1.Repara());

        var R1 = new PantallaRota(Celular1);
        Console.WriteLine(R1.Repara());

        var R2 = new Bateria(Celular1);
        Console.WriteLine(R2.Repara());

        var R3 = new RestablecerDispositivo(Celular1);
        Console.WriteLine(R3.Repara());

        Console.WriteLine(Celular1.Hardware());

        var H1 = new Hardware1(Celular1);
        Console.WriteLine(H1.Hardware());
        Console.WriteLine("");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

        //Celular #2
        Console.WriteLine("");
        var Celular2 = new Dispositivo2();
        Console.WriteLine(Celular2.Repara());

        var R4 = new Bateria(Celular2);
        Console.WriteLine(R4.Repara());

        var R5 = new RestablecerDispositivo(Celular2);
        Console.WriteLine(R5.Repara());

        var R6 = new PantallaRota(Celular2);
        Console.WriteLine(R6.Repara());

        Console.WriteLine(Celular2.Hardware());

        var H2 = new Hardware2(Celular2);
        Console.WriteLine(H2.Hardware());
        Console.WriteLine("");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
        
        //Celular #3
        Console.WriteLine("");
        var Celular3 = new Dispositivo3();
        Console.WriteLine(Celular3.Repara());

        var R7 = new RestablecerDispositivo(Celular3);
        Console.WriteLine(R7.Repara());

        var R8 = new Bateria(Celular3);
        Console.WriteLine(R8.Repara());

        var R9 = new PantallaRota(Celular3);
        Console.WriteLine(R9.Repara());

        Console.WriteLine(Celular3.Hardware());

        var H3 = new Hardware3(Celular3);
        Console.WriteLine(H3.Hardware());
        Console.WriteLine("");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

        }
    }
}