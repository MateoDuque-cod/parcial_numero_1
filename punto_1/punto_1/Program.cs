public class Program
{
    static void Main(string[] args)
    {
        const double sueldo_base = 2000000, bono = 1000000, porc_comision = 0.10;

        double pmdio_comison, comision1, comision2, comision3, comision_ttl;
        double valor_vnta1, valor_vnta2, valor_vnta3 ;
        double sueldo_completo;

        // PUNTO 1 
        Console.Write("ingrese el valor de la venta 1: ");
        valor_vnta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la venta 2: ");
        valor_vnta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la venta 3: ");
        valor_vnta3 = Convert.ToDouble(Console.ReadLine());

        //PROCESO
        comision1 = valor_vnta1 * porc_comision;
        comision2 = valor_vnta2 * porc_comision;
        comision3 = valor_vnta3 * porc_comision;

        comision_ttl = comision1 + comision2 + comision3;

        Console.Write("el valor ganado por comision es de: $ " + comision_ttl + " pesos");
        Console.WriteLine();
        //PUNTO 2

        sueldo_completo = sueldo_base + comision_ttl;

        Console.Write("el valor total a pagar es de: $ " + sueldo_completo + " pesos");
        Console.WriteLine();


        //PUNTO 3

        if (valor_vnta1 > valor_vnta2 && valor_vnta1 > valor_vnta3)
        {
            Console.Write($"la venta que genero mayor comision fue la de: $ {valor_vnta1} pesos, con una comision de: $ {comision1} pesos");
        }

        else if (valor_vnta2 > valor_vnta1 && valor_vnta2 > valor_vnta3)
        {
            Console.Write($"la venta que genero mayor comision fue la de: $ {valor_vnta2} pesos, con una comision de: $ {comision2} pesos");
        }

        else
        {
            Console.Write($"la venta que genero mayor comision fue la de: $ {valor_vnta3} pesos, con una comision de: $ {comision3} pesos");
        
        }
        Console.WriteLine();

        //PUNTO 4

        Console.Write("el promedio ganado por la primera venta es de: $ " + comision1 + " pesos");
        Console.WriteLine();

        Console.Write("el promedio ganado por la segunda venta es de: $ " + comision2 + " pesos");
        Console.WriteLine();

        Console.Write("el promedio ganado por la tercera venta es de: $ " + comision3 + " pesos");
        Console.WriteLine();

        pmdio_comison = comision_ttl / 3 ;

        Console.Write("con un promedio total del:"+ pmdio_comison + "%");











    }


}