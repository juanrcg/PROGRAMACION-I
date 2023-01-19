internal class Program

{

   private static void Main(string[] args)

  {

     //1 --Leer un número entero de dos dígitos y determinar a cuánto es igual la suma de sus dígitos.

     int valor = int.Parse(Console.ReadLine());

     int suma = valor/10 + valor%10;

    Console.WriteLine(suma);



   

  }

}
