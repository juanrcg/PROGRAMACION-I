internal class Program

{

   private static void Main(string[] args)

  {

    // 2.  Leer un número entero de dos dígitos y determinar si es primo y además si es negativo.



     int contador = 0;

     int valor = int.Parse(Console.ReadLine());

    



     if (valor > 0 ){

      

     Console.WriteLine("el numero es positivo");

    }

    else 

     valor = valor * -1;

     Console.WriteLine("el numero es negativo");

   



     for(int i = 1 ; i < valor; i++){



       if(valor % i == 0){



         contador  = contador + 1;

      }

    }



     if (contador > 2){



       Console.WriteLine("el numero no es primo");



    }

     else 

     Console.WriteLine("el numero es primo");

    

    

  }

}
