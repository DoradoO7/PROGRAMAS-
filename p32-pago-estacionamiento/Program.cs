﻿// Administrar el pago por estacionamientos de acuerddo a la zona
int op;
float tasa, pago, impuesto, total;

Console.Clear();
Console.WriteLine("Administrar el pago por estacionaineto de de acuerdo a la Zona\n");
Console.WriteLine("1-Estacionamiento Tacuba 3%");
Console.WriteLine("2-Estacionamiento Portales 5%");
Console.WriteLine("3-Estacionamiento Conquistadores 10%");
Console.WriteLine("4-Estacionamiento Pajaros caido 15%");
Console.Write("Elige opcion");
op = int.Parse(Console.ReadLine());
Console.Write("Pago efectuado? "); pago = float.Parse(Console.ReadLine());
tasa=0.0f;
switch(op){

    case 1 : tasa = 0.03f;break;
    case 2 : tasa = 0.05f;break;
    case 3 : tasa = 0.10f;break;
    case 4 : tasa = 0.15f;break;
}
impuesto = pago * tasa;
total = pago + impuesto;
string salida= string.Format($"Eligiste el estacionamiento {op}\n"+
    $"Pagaste{pago} por el tiempo de uso\n" +
    $"Corresponde un impuesto de {impuesto}\n"+
    $"El pago total es de {total}");
Console.WriteLine(salida);



