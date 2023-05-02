empleado empleado01 = new empleado();
// Instanciar, luego reservar espacio en memoria
empleado empleado02;
empleado02 = new empleado();
empleado empleado03=new empleado("El  bob esponja");
empleado empleado04=new empleado("patcio",38);
// Asignar valores a los datos a través de las propiedades
empleado01.Nombre = "Leonardo";
empleado01.Edad = 22;
empleado02.Nombre = "Jose";
empleado02.Edad = 35;
// Invocar los métdos
empleado01.ImprimirDatos();
empleado02.ImprimirDatos();
empleado03.ImprimirDatos();
empleado04.ImprimirDatos();
