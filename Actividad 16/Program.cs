// pida números al usuario hasta ingresar 0 y determine cual fue el nuero mayor 

int numero;
do
{
    Console.WriteLine("Ingrese un número positivo");
    numero = int.Parse(Console.ReadLine());
}
while (numero <= 0);
Console.WriteLine($"Número aceptado {numero}");
