using System;

class MainClass {

  static int n1,n2,n3,n4,n5;
  static float[] numeros;
  static float mayorNum;
  static float menorNum;

  public static void Main (string[] args) {

    RandomNumber(ref n1,ref n2,ref n3,ref n4,ref n5);
    Console.WriteLine("Los numeros aleatorios son: {0}, {1}, {2}, {3}, {4}",n1,n2,n3,n4,n5);

    
    Console.WriteLine("Digite el tamaño del vector:");
    int size = int.Parse(Console.ReadLine());
    numeros = new float[size];

    CargarVector();

    MayorMenor(out mayorNum,out menorNum);

    Console.WriteLine("El numero mayor del vector es {0}",mayorNum);    
    Console.WriteLine("El numero menor del vector es {0}",menorNum);

  }

  static void RandomNumber(ref int n1,ref int n2,ref int n3,ref int n4,ref int n5){

    Random r = new Random();
    n1 = r.Next(0, 30);
    n2 = r.Next(0, 30);
    n3 = r.Next(0, 30);
    n4 = r.Next(0, 30);
    n5 = r.Next(0, 30);
  }

  static void CargarVector(){
  
    for (int i=0;i<numeros.Length;i++){
      Console.WriteLine("Digite el valor de la posicion {0}:",i);
      numeros[i] = float.Parse(Console.ReadLine());
      
    }

  }

  static void MayorMenor(out float mayor, out float menor){

    mayor = numeros[0];
    menor = numeros[0];

    for (int i=0;i<numeros.Length;i++){
      
      if (numeros[i] > mayor)
        mayor = numeros[i];
      else
        if (numeros[i] < menor)
          menor = numeros[i];

    }

  } 

}