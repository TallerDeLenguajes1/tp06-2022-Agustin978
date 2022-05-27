public class Empleado
{
    string nombre, apellido;
    DateTime fechaNacimiento, fechaIngreso;
    Estado estado;
    Genero genero;
    double sueldoBasico;
    Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, Genero genero, Cargos cargo, double sueldoBasico, Estado estado)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngreso = fechaIngreso;
        this.genero = genero;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
        this.estado = estado;
    }

    public double antiguedadEnEmpresa()
    {
        DateTime antiguedad = DateTime.Now.Year - fechaIngreso.Value.Year;
        return antiguedad;
    }

    public int edad()
    {
        DateTime edad = DateTime.Now.Year - fechaNacimiento.Value.Year;
        return edad;
    }

    public AnoJubila()
    {
        if(this.genero == 'Femenino')
        {
            return 60 - edad();
        }else
        {
            return 65 - edad();
        }
    }

}