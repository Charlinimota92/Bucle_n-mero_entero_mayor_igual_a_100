// See https://aka.ms/new-console-template for more information
Console.WriteLine("Número entero");
Console.WriteLine();

{

    Console.WriteLine("Ingrese la cantidad de números a evaluar:");
    int cantidadNumeros = Convert.ToInt32(Console.ReadLine());


    int sumatoria = 0;

    // Bucle para leer los números y calcular la sumatoria
    for (int i = 0; i < cantidadNumeros; i++)
    {
        Console.WriteLine("Ingrese el número " + (i + 1) + ":");
        int numero = Convert.ToInt32(Console.ReadLine());
        sumatoria += numero;
    }

   
    if (sumatoria >= 100)
    {
        Console.WriteLine("La sumatoria es mayor o igual a 100. Resultado: " + sumatoria);
    }
    else
    {
        Console.WriteLine("La sumatoria es menor que 100. Resultado: " + sumatoria);
    }



}
