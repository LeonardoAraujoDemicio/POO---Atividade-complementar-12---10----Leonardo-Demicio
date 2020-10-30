using System;
using System.Globalization;
using System.Numerics;

namespace Atividade_complementar_12_10_Leo_A._Demicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de pessoas: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insira a primeira altura: ");
                vect[i] = double.Parse(Console.ReadLine()); _ = CultureInfo.InvariantCulture;
            

            }
                double soma = vect[0] + vect[1] + vect[2];
                Console.WriteLine("A soma das alturas é: " + soma);

               double media = (vect[0] + vect[1] + vect[2]) / 3;
                Console.WriteLine("A média das alturas é: " + media);

                Console.ReadKey();

            
        }
    }
}
