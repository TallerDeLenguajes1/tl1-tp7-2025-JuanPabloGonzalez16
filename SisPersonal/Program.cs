using SistPersonal;
Empleado[] empleados = new Empleado[3];
empleados[0] = new Empleado
{
    Nombre = "Juan Pablo",
    Apellido = "Gonzalez",
    FechaNac = new DateTime(1985, 3, 12),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(2010, 5, 20),
    SueldoBasico = 100000,
    Cargo = Cargos.Ingeniero
};
empleados[1] = new Empleado
{
    Nombre = "Sebastian",
    Apellido = "Zelarayan",
    FechaNac = new DateTime(1990, 7, 1),
    EstadoCivil = 'S',
    FechaIngreso = new DateTime(2015, 6, 1),
    SueldoBasico = 85000,
    Cargo = Cargos.Administrativo
};
empleados[2] = new Empleado
{
    Nombre = "Gonzalo",
    Apellido = "Figueroa",
    FechaNac = new DateTime(1970, 10, 5),
    EstadoCivil = 'C',
    FechaIngreso = new DateTime(1995, 3, 15),
    SueldoBasico = 120000,
    Cargo = Cargos.Especialista
};

double montoTotal = empleados[0].calcSalario() + empleados[1].calcSalario() + empleados[2].calcSalario();
Console.WriteLine("Monto total en concepto de Salarios: " + montoTotal);
//Muestro los datos del empleado que esta mas proximo a jubilarse
//Para ello calculo
if (empleados[0].Jubilacion() < empleados[1].Jubilacion() && empleados[0].Jubilacion() < empleados[2].Jubilacion())
{
    //Muestro datos del empleado 1
    Console.WriteLine("El empleado mas proximo a jubilarse es: " + empleados[0].Nombre + empleados[0].Apellido);
    Console.WriteLine("Cantidad de anios para jubilarse: " + empleados[0].Jubilacion());
    Console.WriteLine("Fecha de nacimiento : " + empleados[0].FechaNac);
    Console.WriteLine("Edad : " + empleados[0].Edad());
    Console.WriteLine("Fecha Ingreso a la empresa : " + empleados[0].FechaIngreso);
    Console.WriteLine("Salario: " + empleados[0].calcSalario());
    Console.WriteLine("Cargo: " + empleados[0].Cargo);
    Console.WriteLine("Estado Civil : " + empleados[0].EstadoCivil);
}
else if (empleados[1].Jubilacion() < empleados[0].Jubilacion() && empleados[1].Jubilacion() < empleados[2].Jubilacion())
{
    Console.WriteLine("El empleado mas proximo a jubilarse es: " + empleados[1].Nombre + empleados[1].Apellido);
    Console.WriteLine("Cantidad de anios para jubilarse: " + empleados[1].Jubilacion());
    Console.WriteLine("Fecha de nacimiento : " + empleados[1].FechaNac);
    Console.WriteLine("Edad : " + empleados[1].Edad());
    Console.WriteLine("Fecha Ingreso a la empresa : " + empleados[1].FechaIngreso);
    Console.WriteLine("Salario: " + empleados[1].calcSalario());
    Console.WriteLine("Cargo: " + empleados[1].Cargo);
    Console.WriteLine("Estado Civil : " + empleados[1].EstadoCivil);
}
else
{
Console.WriteLine("El empleado mas proximo a jubilarse es: " + empleados[2].Nombre + empleados[2].Apellido);
    Console.WriteLine("Cantidad de anios para jubilarse: " + empleados[2].Jubilacion());
    Console.WriteLine("Fecha de nacimiento : " + empleados[2].FechaNac);
    Console.WriteLine("Edad : " + empleados[2].Edad());
    Console.WriteLine("Fecha Ingreso a la empresa : " + empleados[2].FechaIngreso);
    Console.WriteLine("Salario: " + empleados[2].calcSalario());
    Console.WriteLine("Cargo: " + empleados[2].Cargo);
    Console.WriteLine("Estado Civil : " + empleados[2].EstadoCivil);
}