using System.Numerics;

public class Program
{
    static void Main(string[] args)
    {
        double a, b, c, x;
        double discriminante;

        Console.WriteLine("SOLUCION PARA UNA ECUACION DE LA FORMA ax + b + c");

        Console.Write("ingrese el valor para la variable a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor para la variable b: ");
        b = Convert.ToDouble(Console.ReadLine());


        Console.Write("ingrese el valor para la variable c: ");
        c = Convert.ToDouble(Console.ReadLine());


        //procedimiento

        x = -(b/a);

        if (a == 0 && (b + c) == 0)
        {
            Console.Write("tiene infinitas soluciones x = " + x);

        }

        else if (a == 0 && (b + c) != 0)
        {
            Console.Write("no hay una solucion para esta ecuacion");

        }
        else
        {
            Console.Write("tiene solucion unica cuando x = " + x);
        }


    }


}

