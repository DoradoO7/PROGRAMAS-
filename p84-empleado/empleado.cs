public class empleado {
public string Nombre {get; set;}
public int Edad {get; set;}

public empleado() {}
public empleado(string nombre) => Nombre = nombre;
public empleado(string nombre, int edad) => (Nombre, Edad) = (nombre, edad);


public void ImprimirDatos() {
Console.WriteLine($"Nombre: {Nombre}");
Console.WriteLine($"Edad: {Edad}");
}
}