﻿//Tarea1
double radio, altura, volumen;
radio = altura = volumen = 0;
Console.WriteLine("Calculando volumen de un cilindro:\n");
Console.Write("Dame el radio: "); radio = double.Parse(Console.ReadLine());
Console.Write("Dame la altura: "); altura = double.Parse(Console.ReadLine());
volumen = radio * radio * altura * Math.PI;
Console.WriteLine($"El volumen del cilindro es: {volumen}");