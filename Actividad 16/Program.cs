// números del 1 al 20 indicando si son pares o impares.

int i = 1;
do
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} Par");
    }
    else
    {
        Console.WriteLine($"{i} Impar");
    }
    i++;
}
while (i <= 20);

