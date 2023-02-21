//TAREA1
double C, F;
C = F = 0;
Console.WriteLine("Convirtiendo grados Fahrenheit a C:\n");
Console.Write("Dame los grados en Fahreheit: "); F = double.Parse(Console.ReadLine());
C = (F - 32) * 5 / 9;
Console.WriteLine($"Grados C: {C}");