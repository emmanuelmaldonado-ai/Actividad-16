// pide una contraseña al usuario y continue solicitandola hasta que sea correcta 

string contraseña = "123456";
string intento;
do
{
    Console.WriteLine("Ingresar contraseña");
    intento =Console.ReadLine();
}
while (intento != contraseña );
Console.WriteLine("Bienvenido");
