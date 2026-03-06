// ingresar numeros y contar cuantos son pares hasta ingresar 0

int numero;
int par = 0;
do
{
    Console.WriteLine("Ingresa un numero (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0 && numero != 0)
    {
        par++;
    }
}
while (numero != 0);
Console.WriteLine($"Números pares: {par}");
