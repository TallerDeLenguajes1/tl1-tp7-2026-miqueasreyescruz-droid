namespace empleado;
class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private cargoEmpleado cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public cargoEmpleado Cargo { get => cargo; set => cargo = value; }

    public TimeSpan Antiguedad ()
    {
        return (DateTime.Now - FechaIngreso);
    }

    public TimeSpan Edad()
    {
        return (DateTime.Now - FechaNacimiento);
    }

    public TimeSpan ParaJubilarce()
    {
        DateTime FechaJubilacion = FechaNacimiento.AddYears(65);
        return (FechaJubilacion - DateTime.Now);
    }
}

public enum cargoEmpleado : int 
{
    Auxiliar = 1,
    Administrativo = 2    
}