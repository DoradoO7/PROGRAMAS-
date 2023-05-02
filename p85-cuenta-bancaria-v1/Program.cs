// Control bancario
Console.WriteLine("\nProbando la clase CuentaBancaria:\n");
CuentaBancaria cuenta = new CuentaBancaria(5000);
Console.WriteLine($"Saldo inicial : {cuenta.Saldo}");
cuenta.Deposita(200);
Console.WriteLine($"Saldo deposito: {cuenta.Saldo}");
bool retiro = cuenta.Retira(40);
if(retiro)
Console.WriteLine($"Saldo retiro : {cuenta.Saldo}");
else
Console.WriteLine("No se pudo retirar, saldo insuficiente");


Console.WriteLine("\nProbando la clase Cliente:\n");
Cliente cliente1 = new Cliente("David","Perez");
cliente1.Cuenta = cuenta;
Console.WriteLine($"Datos cliente: {cliente1.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Maria","Lopez");
cliente2.Cuenta = new CuentaBancaria(1300);
Console.WriteLine($"Datos cliente: {cliente2.ToString()}");
Console.WriteLine($"Saldo cuenta : {cliente2.Cuenta.Saldo}");
