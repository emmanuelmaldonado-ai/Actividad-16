// pide un numero al usuario y mostrar su tabla de multiplicar del 1 al 10

Console.WriteLine("Ingrese un númro");
int numero = int.Parse(Console.ReadLine());
int i = 1;
do
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    i++;
}
while (i <= 10);
