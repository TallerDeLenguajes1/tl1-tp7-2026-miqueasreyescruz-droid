namespace empleado;

class Empleado
{
    private string Nombre;
    private string Apellido;
    private DateTime FechaNacimiento;
    private char Estadocivil;
    private DateTime FechaIngreso;
    private double SueldoBasico;
    private cargoEmpleado Cargo;
}

public enum cargoEmpleado : int 
{
    Auxiliar = 1,
    Administrativo = 2    
}