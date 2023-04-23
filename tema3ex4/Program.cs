using System;

//Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
//Cel mai mare numar din vector
//Cel mai mic numar din vector
//Numerele divizibile cu 3

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul de elemente din vector: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Introduceti elementul {i + 1}: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        //cel mai mare numar din vector
        int max = GetMax(vector);
        Console.WriteLine($"Cel mai mare numar din vector este: {max}");

        //cel mai mic numar din vector
        int min = GetMin(vector);
        Console.WriteLine($"Cel mai mic numar din vector este: {min}");

        //divizibile cu 3
        int[] divizibileCu3 = GetDivizibileCu3(vector);
        Console.Write("Numerele divizibile cu 3 sunt: ");
        for (int i = 0; i < divizibileCu3.Length; i++)
        {
            Console.Write(divizibileCu3[i] + "");
        }
        Console.WriteLine();
    }

    static int GetMax(int[] vector)
    {
        int max = int.MinValue;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] > max)
            {
                max = vector[i];
            }
        }
        return max;
    }

    static int GetMin(int[] vector)
    {
        int min = int.MaxValue;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] < min)
            {
                min = vector[i];
            }
        }
        return min;
    }

    static int[] GetDivizibileCu3(int[] vector)
    {
        int count = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] % 3 == 0)
            {
                count++;
            }
        }
        int[] divizibileCu3 = new int[count];
        int j = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] % 3 == 0)
            {
                divizibileCu3[j] = vector[i];
                j++;
            }
        }
        return divizibileCu3;
    }
}
