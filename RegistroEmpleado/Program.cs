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

void mostrarDatos(int pos)
{
    Console.WriteLine("Mostrar registros");
    for(int i = 0; i < pos; i++)
    {
        if(pos == 0)
        {
            Console.WriteLine("No hay datos que ense;ar");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Nombre: {empleados[i].nombres} {empleados[i].apellidos} con cargo: {empleados[i].cargo} SALARIO C$: {empleados[i].salario}");
        }
    }
}

void guardarEmpleado(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\introProgramacion\\empleados.csv");
    for (int i = 0; i < pos; i++)
    {
        Console.Clear();
        archivo.WriteLine($"{empleados[i].nombres}; {empleados[i].apellidos}; {empleados[i].cargo}; {empleados[i].salario}");
    }
    archivo.Close();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registros guardados");
    Console.ResetColor();
}


int menu()
{
    Console.Write("1. Agregar \n2. Mostrar\n3. Guardar\n4. Salir\nDigite su opcion: ");
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
                mostrarDatos(i);
                break;
            case 3:
                guardarEmpleado(i);
                break;
            case 4:
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opcion invalida.");
                Console.ResetColor();
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
