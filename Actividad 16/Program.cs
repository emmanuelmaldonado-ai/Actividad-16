// pida al usuario 5 números y calcule la suma total 

int i = 1;
int suma = 0;
do
{
    Console.WriteLine("Ingrese un número");
    int numero = int.Parse(Console.ReadLine());
    suma = suma + numero;
    i++;
}
while (i <= 5);
Console.WriteLine($"Suma total: {suma}");
