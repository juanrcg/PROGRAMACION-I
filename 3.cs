internal class Program

{

   private static void Main(string[] args)

  {

    // 3.  Leer un número entero de dos dígitos y determinar si sus dos dígitos son primos.



    int divisores = 0; 

    

    int valor = int.Parse(Console.ReadLine());



    if (valor < 100 && valor > -100){



      int fid = valor/10;

      int sd = (valor % 10);





      for(int i =1 ; i<fid ; i++){



       if (fid%i == 0)

       divisores = divisores + 1;

   

     }



      if (divisores >= 2)

     {

       Console.WriteLine("uno de ellos no es primo");

       

     }



      else



       divisores = 0;



      for(int i =1 ; i<sd ; i++){



       if (sd%i == 0)

       divisores = divisores + 1;

   

     }



      if (divisores >= 2)

     {

       Console.WriteLine("uno de ellos no es primo");

       

     }



      else 



      Console.WriteLine("los dos son primos");

   

  }



  }

}
