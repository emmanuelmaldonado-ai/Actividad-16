// cuente cuantos numero ingreso el usuario hasta ingresar 0

int cuenta = 0;
int numero;
do
{
    Console.WriteLine("Ingrese un número (0 para salir)");
    numero = int.Parse(Console.ReadLine());
    if (numero != 0)
    {
        cuenta++;
    }
}
while (numero != 0);
Console.WriteLine($"Fueron {cuenta} números ingresados");
