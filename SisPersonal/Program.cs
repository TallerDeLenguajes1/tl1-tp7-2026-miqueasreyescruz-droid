using empleado;

double MontoTotal = 0;
Empleado[] MisEmpleados = new Empleado[3];
Empleado proximoJubilarse;

Console.WriteLine("___CARGANDO EMPLEADOS___");

MisEmpleados[0] = new Empleado();
MisEmpleados[0].Nombre = "Carlos";
MisEmpleados[0].Apellido = "Ferrari";
MisEmpleados[0].FechaNacimiento = DateTime.Now.AddYears(-42);
MisEmpleados[0].EstadoCivil = 'C';
MisEmpleados[0].FechaIngreso = DateTime.Now.AddYears(-15);
MisEmpleados[0].SueldoBasico = 750000;
MisEmpleados[0].Cargo = CargoEmpleado.Ingeniero;

MisEmpleados[1] = new Empleado();
MisEmpleados[1].Nombre = "Señor";
MisEmpleados[1].Apellido = "Barriga";
MisEmpleados[1].FechaNacimiento = DateTime.Now.AddYears(-50);
MisEmpleados[1].EstadoCivil = 'S';
MisEmpleados[1].FechaIngreso = DateTime.Now.AddYears(-28);
MisEmpleados[1].SueldoBasico = 1000000;
MisEmpleados[1].Cargo = CargoEmpleado.Administrativo;

MisEmpleados[2] = new Empleado();
MisEmpleados[2].Nombre = "Indio";
MisEmpleados[2].Apellido = "Solari :(";
MisEmpleados[2].FechaNacimiento = DateTime.Now.AddYears(-77);
MisEmpleados[2].EstadoCivil = 'C';
MisEmpleados[2].FechaIngreso = DateTime.Now.AddYears(-18);
MisEmpleados[2].SueldoBasico = 2000000;
MisEmpleados[2].Cargo = CargoEmpleado.Auxiliar;

Console.WriteLine("________________________");
MontoTotal = MisEmpleados[0].SalarioTotal() + MisEmpleados[1].SalarioTotal() + MisEmpleados[2].SalarioTotal();
Console.WriteLine($"-> Monto Total de lo que se paga en concepto de Salarios: {MontoTotal:C2}");

proximoJubilarse = MisEmpleados[0];
for(int i = 1; i < 3; i++)
{
    if (proximoJubilarse.ParaJubilarse() > MisEmpleados[i].ParaJubilarse())
    {
        proximoJubilarse = MisEmpleados[i];
    }
}

Console.WriteLine("-> Informacion del empleado mas proximo a jubilarse:");
Console.WriteLine($"Nombre: {proximoJubilarse.Nombre}");
Console.WriteLine($"Apellido: {proximoJubilarse.Apellido}");
Console.WriteLine($"Fecha de Nacimiento: {proximoJubilarse.FechaNacimiento}");
Console.WriteLine($"Estado Civil: {proximoJubilarse.EstadoCivil}");
Console.WriteLine($"Fecha de Ingreso: {proximoJubilarse.FechaIngreso}");
Console.WriteLine($"Sueldo Basico: {proximoJubilarse.SueldoBasico:C2}");
Console.WriteLine($"Cargo: {proximoJubilarse.Cargo}");
Console.WriteLine("- Informacion auxiliar: ");
Console.WriteLine($"Antiguedad: {proximoJubilarse.Antiguedad()}");
Console.WriteLine($"Edad: {proximoJubilarse.Edad()}");
Console.WriteLine($"Años para jubilarse: {proximoJubilarse.ParaJubilarse()}");
Console.WriteLine($"Salario total: {proximoJubilarse.SalarioTotal():C2}");