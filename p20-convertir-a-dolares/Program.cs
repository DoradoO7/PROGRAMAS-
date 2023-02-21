//TAREA1
double dolar, pesos, conversion;
dolar = pesos = conversion = 0;
Console.WriteLine("Convirtiendo pesos a dolares:\n");
Console.Write("Dame la cantidad de pesos: "); pesos = double.Parse(Console.ReadLine());
Console.Write("Dame el precio del dolar: "); dolar = double.Parse(Console.ReadLine());
conversion = pesos / dolar;
Console.WriteLine($"La conversion en dolares es: {conversion}");