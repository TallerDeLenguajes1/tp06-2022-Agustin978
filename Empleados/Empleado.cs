public class Empleado
{
    string nombre, apellido;
    DateTime fechaNacimiento, fechaIngreso;
    Char estadoC;
    char genero;
    double sueldoBasico;
    Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngreso, char genero, Cargos cargo, double sueldoBasico, char estadoC)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngreso = fechaIngreso;
        this.genero = genero;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
        this.estadoC = estadoC;
    }

    public int antiguedadEnEmpresa()
    {
        int antiguedad = DateTime.Today.AddTicks(-fechaIngreso.Ticks).Year - 1;
        return antiguedad;
    }

    public int edad()
    {
        int edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1;
        return edad;
    }

    public int AnoJubila()
    {
        if(this.genero.CompareTo("Femenino") == 0)
        {
            return 60 - edad();
        }else
        {
            return 65 - edad();
        }
    }

    public double Adicional()
    {
        double adicional = 0;
        int add;
        if(antiguedadEnEmpresa()>20)
        {
            add = 25;
            if(this.cargo.Equals("Ingeniero") || this.cargo.Equals("Especialista"))
            {
                add += 50;
                adicional = ((this.sueldoBasico * add) / 100) * antiguedadEnEmpresa();
            }else
            {
                adicional = ((this.sueldoBasico * add) / 100) * antiguedadEnEmpresa();
            }
        }else
        {
            add = 1;
            if(this.cargo.Equals("Ingeniero") || this.cargo.Equals("Especialista"))
            {
                add += 50;
                adicional = ((this.sueldoBasico * add) / 100) * antiguedadEnEmpresa();
            }else
            {
                adicional = ((this.sueldoBasico * add) / 100) * antiguedadEnEmpresa();
            }
        }
        return adicional;
    }

    public double Salario()
    {
        return this.sueldoBasico + Adicional();
    }


    public override string ToString()
    {
        return "Nombre: "+this.nombre+" /\nApellido: "+this.apellido+" /\nGenero: "+this.genero+" /\nEdad: "+edad()+
                " / \nEstado Civil: "+this.estadoC+" /\nCargo: "+this.cargo+" /\nFecha de ingreso en la empresa: "+this.fechaIngreso+
                " /\nSueldo: $USD "+this.sueldoBasico;
    }

}