// almacenar 10 registros de estudiantes:nombre, carrera, promedio//
Estudiante[] estudiante= new Estudiante[10];

int Menu()
{
    Console.Write("1.agregar");
    Console.Write("2. mostrar ");
    Console.Write("3. salir ");
}

void pedirDatos()
{
    for (int i = 0; i < 10; i++)
    {
        Console.Write("nombre: ");
        estudiante[i].nombre = Console.ReadLine();
        Console.Write("carrera: ");
        estudiante[i].carrera = Console.ReadLine();
        Console.Write("promedio: ");
        estudiante[i].promedio= double.Parse(Console.ReadLine());
    }
}
void mostrarDatos()
{
    for(int i = 0;i < 10;i++)
    {
        Console.WriteLine($"{estudiante[i].nombre} / {estudiante[i].carrera} / {estudiante[i].promedio} ");
    }
}
void main()
{
    int opcion;
    do
    {
        opcion = Menu();
        switch (opcion)
        {
            case 1:
                pedirDatos();
                break;
            case 2:
                mostrarDatos();
                break;
            case 3:
                Console.WriteLine("saliendo");
                break;
            default:
                Console.WriteLine("opcion invalida");
                break;
        } while (opcion != 3) ;
    }
    struct Estudiante 
{
    public string nombre;
    public string carrera;
    public double promedio;

}

