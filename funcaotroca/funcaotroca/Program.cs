using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcaotroca
{
    class Program
    {
        static void Troca(int[] vetor, int pos1, int pos2)
        {
            int temp = 0;
            temp = vetor[pos1];
            vetor[pos1] = vetor[pos2];
            vetor[pos2] = temp;                     
              
        }
        
        static void Main(string[] args)
        {
            int[] numeros = { 12, 7, 15, 11, 27 };
            Console.WriteLine("Elementos do vetor:\n\n12  7  15  11  27");
            Console.WriteLine("(0)(1) (2) (3) (4)");

            Console.WriteLine("\n");
            Console.WriteLine("Digite as posições as quais você quer trocar:\n");

            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());

            if (P1 > 4 || P1 < 0 || P2 > 4 || P2 < 0)
            {
                Console.WriteLine("\nERROR: Valor digitado MAIOR ou MENOR do que o tamanho do vetor!");
                Console.ReadKey();
            }
                
            Troca(numeros, P1, P2);

            Console.WriteLine("\nNova Posição dos elementos do vetor:\n");

            for (int i = 0; i < numeros.Length; i++)
                Console.Write( numeros[i] + "  ");

            Console.ReadKey();
        }
    }
}
