Empleado[] empleados = new Empleado[10];


void agregarEmpleado(int pos)
{
    Console.Write("Nombre: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellido: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.Write("Salario: ");
    empleados[pos].salario = Double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamente");
    Console.ResetColor();
}
int menu()
{
    Console.Write("1. Agregar \n2. Mostrar\n3. Eliminar\n4. Salir\nDigite su opcion: ");
    int op = int.Parse(Console.ReadLine()!);
    return op;
}

int main()
{
    int op = 0, i = 0;
    do
    {
        Console.WriteLine($"Registro #{i + 1}");
        op = menu();
        switch (op)
        {
            case 1:
                agregarEmpleado(i++);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
    } while (op != 4);
    return 0;
}

main();
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}
