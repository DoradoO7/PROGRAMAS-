//TAREA1
double lado1, lado2, hipotenusa;
lado1 = lado2 = hipotenusa = 0;
Console.WriteLine("Calculando la hipotenusa de un triangulo:\n");
Console.Write("Dame la base: "); lado1 = double.Parse(Console.ReadLine());
Console.Write("Dame la altura: "); lado2 = double.Parse(Console.ReadLine());
hipotenusa = Math.Sqrt(lado1 * lado1 + lado2 * lado2);
Console.WriteLine($"La hipotenusa es: {hipotenusa}");10