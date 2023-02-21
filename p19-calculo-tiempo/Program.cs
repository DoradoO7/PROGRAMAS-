//TAREA 1
double dias, horas, minutos, segundos;
dias = horas = minutos = segundos = 0;
Console.WriteLine("Calculando el tiempo:\n");
Console.Write("Dame las horas: "); horas = double.Parse(Console.ReadLine());
dias = horas / 24;
minutos = horas * 60;
segundos = horas * 60 * 60;
Console.WriteLine($"El tiempo es:\n{dias} dias\n{horas} horas\n{minutos} minutos\n{segundos} segundos\n");