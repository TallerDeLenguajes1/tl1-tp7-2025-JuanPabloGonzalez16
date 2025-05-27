using EspacioCalculadora;
Calculadora Calc = new Calculadora();
int op;
string? texOp;
string? resultadoOperacion;
do
{
    Console.WriteLine("Ingrese el numero de Operacion");
    Console.WriteLine("1)Sumar");
    Console.WriteLine("2)Restar");
    Console.WriteLine("3)Multiplicar");
    Console.WriteLine("4)Dividir");
    Console.WriteLine("5)Limpiar Resultado");
    Console.WriteLine("0)Salir");
    texOp = Console.ReadLine();
    bool cambioOp = int.TryParse(texOp, out op);
    Console.WriteLine("Ingrese el numero a operar");
    string? numOp;
    double num;
    numOp = Console.ReadLine();
    bool cambio = double.TryParse(numOp, out num);
    if (cambioOp && cambio)
    {
        switch (op)
        {
            case 1:
                Calc.Sumar(num);
                resultadoOperacion = Calc.Resultado.ToString();
                Console.WriteLine("Resultado: " + resultadoOperacion);
                break;
            case 2:
                Calc.Restar(num);
                resultadoOperacion = Calc.Resultado.ToString();
                Console.WriteLine("Resultado: " + resultadoOperacion);
                break;
            case 3:
                Calc.Multiplicar(num);
                resultadoOperacion = Calc.Resultado.ToString();
                Console.WriteLine("Resultado: " + resultadoOperacion);
                break;
            case 4:
                Calc.Dividir(num);
                resultadoOperacion = Calc.Resultado.ToString();
                Console.WriteLine("Resultado: " + resultadoOperacion);
                break;
            case 5:
                Calc.Limpiar();
                resultadoOperacion = Calc.Resultado.ToString();
                Console.WriteLine("Resultado: " + resultadoOperacion);
                break;
        }
    }
    
} while (op != 0);