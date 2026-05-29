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
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}
