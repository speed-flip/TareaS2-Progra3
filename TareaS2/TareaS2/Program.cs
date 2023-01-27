using TareaS2.Modelos;

Expresion c1 = new Expresion()
{
    numero1 = 9,
    numero2 = 2,
};

Console.WriteLine("========== INICIO =========== ");

Expresion c2 = new Expresion()
{
    numero1 = 30,
    numero2 = 40,
};

List<Expresion> listEx = new List<Expresion>();

listEx.Add(c1);
listEx.Add(c2);

foreach (Expresion e in listEx)
{
    Console.WriteLine($"Suma: {e.suma()}");
    Console.WriteLine($"Resta: {e.resta()}");
    Console.WriteLine($"Multiplicación: {e.multiplicacion()}");
    Console.WriteLine($"División: {e.division()}");
    Console.WriteLine($"Maximo: {e.maximo()}");
    Console.WriteLine($"Minimo: {e.minimo()}");
    Console.WriteLine("=======");
}