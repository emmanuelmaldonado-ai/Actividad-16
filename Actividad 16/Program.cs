// de¿¿pedir numeros y sumarlos hasta que el usuario escriba 0

int suma = 0;
int numero;
do
{
    Console.WriteLine("Ingrese un número (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero != 0)
    {
        suma += numero;
    }
}
while (numero != 0);
Console.WriteLine($"La suma total es: {suma}");
