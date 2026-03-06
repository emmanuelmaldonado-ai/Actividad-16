// pide un numero al usuario hasta ingresar 0 y al final muestre:

int numero;
int suma= 0;
int cantidad = 0;
do
{
    Console.WriteLine("Ingrese un númro (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    suma += numero;

    if (numero != 0)
    {
        cantidad++;
    } 
}
while (numero != 0);
if (cantidad > 0)
{
    double promedio = suma / cantidad;
    Console.WriteLine($"Suma total: {suma}");
    Console.WriteLine($"Cantidad de números: {cantidad }");
    Console.WriteLine($"Promedio:  {promedio}");
}
else
{
    Console.WriteLine("Error");
}
