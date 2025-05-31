namespace SistPersonal;
public enum Cargos
    {
        Auxiliar,
        Ingeniero,
        Administrativo,
        Especialista,
        Investigador,

    }

public class Empleado
{

    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;

    private Cargos cargo;
    //Propiedades
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    //Metodos//
    public int Antiguedad()
    {
        return ((DateTime.Now.Year) - (FechaIngreso.Year));
    }
    public int Edad()
    {
        return DateTime.Now.Year - FechaNac.Year;
    }
    public int Jubilacion()
    {
        int edad = Edad();
        return 65 - edad;
    }
    public double calcSalario()
    {
        double Salario;
        double Adicional;
        if (Antiguedad() <= 20)
        {
            Adicional = sueldoBasico * 0.01 * Antiguedad();
        }else
        {
            Adicional = sueldoBasico * 0.25;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            Adicional *= 1.5;
        }
        if (char.ToUpper(estadoCivil) == 'C')
        {
            Adicional += 150000;
        }
        Salario = sueldoBasico + Adicional;
        return Salario;
    }
}