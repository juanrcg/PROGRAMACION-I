internal class Program

{

   private static void Main(string[] args)

  {

    // 4.  Leer dos números enteros de dos dígitos y determinar si la suma de los dos números origina un número par.



     int valor = int.Parse(Console.ReadLine());







   if (valor < 100 && valor > -100){







    int fid = valor/10;



    int sd = (valor % 10);



    int suma = fid + sd;





    if(suma %2 == 0 ){

     Console.WriteLine("la suma de ambos es par ");

   }

    else

    Console.WriteLine("la suma de ambos no es par ");



  }



  }

}
