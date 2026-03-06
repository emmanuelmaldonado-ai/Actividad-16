// pida números al usuario hasta ingresar 0 y determine cual fue el nuero mayor 

int numero;
int mayor = 0;
do
{
    Console.WriteLine("Ingrese un número (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero > mayor && numero != 0)
    {
    mayor = numero;
    }
}
while (numero != 0);
Console.WriteLine($"Número mayor {mayor}");
