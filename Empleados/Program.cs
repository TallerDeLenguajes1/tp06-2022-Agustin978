// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n============Programa empleados============\n");

DateTime fechaNacimiento = new DateTime(2000,5,4);
DateTime fechaIngreso = new DateTime(2018,11,25);
Cargos cargo = Cargos.Ingeniero;
Empleado empleado1 = new Empleado("Agustin", "Lobo", fechaNacimiento, fechaIngreso, char.Parse("M"), cargo, 75152.32, char.Parse("S"));
Console.WriteLine(empleado1.ToString());
Console.WriteLine("\nSueldo actual: $USD "+empleado1.Salario());