using System;

class Program
{
    static void Main()
    {
        // Lectura del tamaño del arreglo
        int n = int.Parse(Console.ReadLine());

        // Lectura de los números
        string[] entrada = Console.ReadLine().Split(' ');

        int[] arreglo = new int[n];

        for (int i = 0; i < n; i++)
        {
            arreglo[i] = int.Parse(entrada[i]);
        }

        // --- INICIO DE LÓGICA DEL ALUMNO ---

        int max = arreglo[0];

        for (int i = 1; i < arreglo.Length; i++)
        {
            if (arreglo[i] > max)
            {
                max = arreglo[i];
            }
        }

        Console.WriteLine(max);

        // --- FIN DE LÓGICA DEL ALUMNO ---
    }
}
