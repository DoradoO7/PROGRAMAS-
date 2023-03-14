// Imprime lo de fibonacit
int n, contador = 0, f = 0, fiboant = 0 , temp = 0;
char resp;
do {
    Console.Clear();
    Console.WriteLine("Imprime los primeros n numero de la serie de fibonacci\n");
    do {
        Console.Write("Dame un numero? ");
        n = int.Parse(Console.ReadLine());
    } while( n <= 0);
    do {
        temp = fiboant;
        fiboant = f;
        f = fiboant + temp;
        Console.Write($"{fiboant} ");
        if(f == 0)f++;
        contador++;
    } while(contador < n);
    contador = f = fiboant = temp = 0;
    Console.Write("\nDeseas continuar (S/N) ? ");resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');
Console.WriteLine("\nGracias por utilizar este programa !");