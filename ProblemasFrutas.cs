

/*Esneyder Yesid Gracia Hernandez
 * 213022_568
 * Ingenieria de sistemas
 * Autoria propia*/
class ProblemasFrutas
{
     
    static void Main(string[] args)
    {
        decimal precioPera = 450;
        decimal precioManzana = 560;
        decimal precioCiruela = 30;
        decimal precioBanano = 80;

        decimal precioPina = 1000;

        Console.Write("Pera - ");
        int cantidadPeras = ObtenerCantidad();

        Console.Write("Manzanas - ");
        int cantidadManzanas = ObtenerCantidad();

        Console.Write("Ciruela - ");
        int cantidadCiruelas = ObtenerCantidad();

        Console.Write("Banano - ");
        int cantidadBananos = ObtenerCantidad();

        Console.Write("Piña - ");
        int cantidadPiña = ObtenerCantidad();

        decimal costoTotal = (cantidadPeras * precioPera) +
            (cantidadManzanas * precioManzana) +
            (cantidadCiruelas * precioCiruela) +
            (cantidadBananos * precioBanano) +
            (cantidadPiña * precioPina);

        if (costoTotal > 20000)
        {
            Console.WriteLine($"El valor antes del descuento : ${costoTotal:N2}");

            decimal descuento = costoTotal * 0.10m;
            costoTotal -= descuento;

            Console.WriteLine($"¡Felicitaciones! Obtuviste un descuento del 10% (${descuento:N2}).");
        }

        Console.WriteLine($"El valor neto de la compra es: ${costoTotal:N2}");
    }

    private static int ObtenerCantidad()
    {
        int numero;
        bool esNumeroValido;

        do
        {
            Console.WriteLine("Ingrese la cantidad");
            string entrada = Console.ReadLine();
            esNumeroValido = int.TryParse(entrada, out numero) && numero >= 0;

            if (!esNumeroValido)
            {
                Console.WriteLine("Ingrese un numero valido mayor a 0");
            }

        } while (!esNumeroValido);

        return numero;
    }
}
