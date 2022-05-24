// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n=================Progama Calculadora=================\n");
bool repite = true;

Console.WriteLine("Ingrese el valor inicial: ");
double valorInicial = double.Parse(Console.ReadLine());
Calculadora calc = new Calculadora(valorInicial);

while(repite)
{
    
    int opcion = menu();
    double num;

    switch(opcion)
    {
        case 1: 
            Console.WriteLine("Ingrese el numero a sumar: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(calc.resultado+" + "+num+" = "+calc.suma(num));
            break;
        
        case 2:
            Console.WriteLine("Ingrese el numero a restar: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(calc.resultado+" - "+num+" = "+calc.resta(num));
            break;

        case 3:
            Console.WriteLine("Ingrese por el numero en que se dividira (distinto de 0): ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(calc.resultado+" / "+num+" = "+calc.cociente(num));

            break;

        case 4:
            Console.WriteLine("Ingrese el numero por el que se multiplicara: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine(calc.resultado+" * "+num+" = "+calc.producto(num));
            break;
        
        case 5:
            Console.WriteLine("Limpiando resultado.");
            Console.WriteLine("Ingrese nuevamente el valor inicial: ");
            valorInicial = double.Parse(Console.ReadLine());
            calc = new Calculadora(valorInicial);
            break;

        default:
            Console.WriteLine("Gracias por usar mi programa :)");
            repite = false;
            break;
    }
}

int menu()
{
    int opcion = 0;
    do
    {
        Console.WriteLine("\n-----Menu-----\n");
        Console.WriteLine("1-> Sumar los numeros.");
        Console.WriteLine("2-> Restar los numeros.");
        Console.WriteLine("3-> Obtener el cociente entre los numeros.");
        Console.WriteLine("4-> Obtener el producto entre los numeros.");
        Console.WriteLine("5-> Limpiar el resultado.");
        Console.WriteLine("6-> Salir del programa.");
        Console.WriteLine("Ingrese una ocion: ");
        opcion = int.Parse(Console.ReadLine());
        
    }while(opcion < 1 || opcion > 6);
    
    return opcion;
}