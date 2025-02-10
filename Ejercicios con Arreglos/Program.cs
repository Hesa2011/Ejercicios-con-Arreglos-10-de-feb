
//1.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número leído.
//2.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición de del arreglo está el mayor número par leído.
//3.Leer 10 enteros, almacenarlos en un arreglo y determinar en qué posición del arreglo está el mayor número primo leído.
//5. Leer 10 números enteros, almacenarlos en un arreglo y determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo    
//6.Leer 10 números enteros, almacenarlos en un arreglo y determinar en qué posiciones se encuentran los números con más de 3 dígitos



//Ejercicio 1


using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; 
        int maximo, posicion;

        Console.WriteLine("Ingrese 10 números enteros:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        maximo = numeros[0];
        posicion = 0;

        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > maximo)
            {
                maximo = numeros[i];
                posicion = i;
            }
        }
        Console.WriteLine($"\nEl número mayor es {maximo} y se encuentra en la posición {posicion} del arreglo.");
    }
}
