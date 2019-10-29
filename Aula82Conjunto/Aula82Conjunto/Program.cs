using System;
using System.Collections.Generic;

namespace Aula82Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(5);
            A.Add(10);
            A.Add(3);
            A.Add(9);

            B.Add(1);
            B.Add(5);
            B.Add(2);
            B.Add(9);
            //CONJUNTO NAO ACEITA VALORES REPETIDOS
            B.Add(2);

            //REMOVER UM ELEMENTO
            B.Remove(1);

            //EFETURAR DIFERENCA ENTRE CONJUNTOS(REMOVE OS ELEMENTOS QUE PERTENCEM A B QUE ESTAO NO A)
            A.ExceptWith(B);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            //ADICIONAR ELEMENTOS QUE EXISTEM EM OUTRO CONJUNTO E NAO EXISTEM NESTE
            A.UnionWith(B);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            //INTERCECAO DOS CONJUNTOS
            A.IntersectWith(B);
            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------");

            foreach (var item in B)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Digite um valo inteiro");
            int N = int.Parse(Console.ReadLine());

            //VERIFICAR SE EXISTE UM ELEMENTO
            if (A.Contains(N)) Console.WriteLine($"{N} pertence ao conjunto A");

            Console.ReadLine();
        }
    }
}
