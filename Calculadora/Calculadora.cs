public class Calculadora
{
    public double resultado;
    public double num;

    public Calculadora(double valorInicial)
    {
        this.resultado = valorInicial;
    }

    public double suma(double num) => resultado += num;

    public double resta(double num) => resultado -= num;

    public double cociente(double num)
    {
        if(num != 0)
        {
            return resultado = resultado / num;
        }else
        {
            Console.WriteLine("No se puede realizar la division en 0");
            return 0;
        }
    }

    public double producto(double num) => resultado *= num;
    public double Limpiar() => resultado = 0;
}