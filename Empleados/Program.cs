// See https://aka.ms/new-console-template for more information

Console.WriteLine("\n============Programa empleados============\n");

DateTime fechaNacimiento = new DateTime(2000,5,4);
DateTime fechaIngreso = new DateTime(2018,11,25);
Cargos cargo = Cargos.Ingeniero;
Empleado empleado1 = new Empleado("Agustin", "Lobo", fechaNacimiento, fechaIngreso, char.Parse("M"), cargo, 75152.32, char.Parse("S"));
Console.WriteLine(empleado1.ToString());
Console.WriteLine("\nSueldo actual: $USD "+empleado1.Salario());

Console.WriteLine("\n\n");
Console.WriteLine("Empleado 2");

DateTime fechaNacimiento2 = new DateTime(1985,2,25);
DateTime fechaIngreso2 = new DateTime(2009,11,25);
Cargos cargo2 = Cargos.Auxiliar;
Empleado empleado2 = new Empleado("Juan", "Perez", fechaNacimiento2, fechaIngreso2, char.Parse("M"), cargo2, 25025.2, char.Parse("C"));
Console.WriteLine(empleado2.ToString());
Console.WriteLine("\nSueldo actual: $USD "+empleado2.Salario());