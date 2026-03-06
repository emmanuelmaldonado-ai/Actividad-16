// menú que se repita hasta que el usuario elija la opcion de salir

int opcion;
do
{
    Console.WriteLine("Menú");
    Console.WriteLine("Opciones: 1) saludo; 2) número aleatorio; 0) salir");
    opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, es un gusto saludarte de nuevo");
            break;
        case 2:
            Console.WriteLine("Número aleatorio: 888");
            break;
        case 0:
            Console.WriteLine("Saliendo...");
            break;
        deafult:
            Console.WriteLine("opcion no valida");
            break;
    }
    Console.WriteLine();
}
while (opcion != 0);
