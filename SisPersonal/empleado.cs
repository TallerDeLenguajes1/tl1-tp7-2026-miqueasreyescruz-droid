namespace empleado;
class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private CargoEmpleado cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public CargoEmpleado Cargo { get => cargo; set => cargo = value; }

    public int Antiguedad ()
    {
        int resultado = DateTime.Today.Year - FechaIngreso.Year;
        if (DateTime.Today < fechaIngreso.AddYears(resultado))
        {
            resultado--;
        }
        return resultado;
    }

    public int Edad ()
    {
        int resultado = DateTime.Today.Year - fechaNacimiento.Year;
        if (DateTime.Today < fechaNacimiento.AddYears(resultado))
        {
            resultado--;
        }
        return resultado;
    }

    public int ParaJubilarce ()
    {
        return (65 - Edad());
    }

    public double SalarioTotal()
    {
        return (sueldoBasico + Adicional());
    }

    private double Adicional()
    {
        double resultado = 0;

        if (Antiguedad() > 20)
        {
            resultado = sueldoBasico * 0.25;
        }
        else
        {
            resultado = sueldoBasico * (0.01 * Antiguedad());
        }

        if(Cargo == CargoEmpleado.Ingeniero || Cargo == CargoEmpleado.Especialista)
        {
            resultado *= 1.50;
        }

        if(EstadoCivil == 'C')
        {
            resultado += 150000;
        }

        return resultado;
    }
}

public enum CargoEmpleado : int 
{
    Auxiliar = 1,
    Administrativo = 2,   
    Ingeniero = 3, 
    Especialista = 4, 
    Investigador = 5 
}