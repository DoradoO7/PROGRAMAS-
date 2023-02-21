//TAREA
double angulo, angulo2, angulo3;
angulo = angulo2 = angulo3 = 0;
Console.WriteLine("Calculando el terer angulo de un triangulo:\n");
Console.Write("Dame el primer angulo 1: "); angulo = double.Parse(Console.ReadLine());
Console.Write("Dame el segundo angulo 2: "); angulo2 = double.Parse(Console.ReadLine());
angulo3 = 180 - (angulo + angulo2);
Console.WriteLine($"El tercer angulo es: {angulo3}")