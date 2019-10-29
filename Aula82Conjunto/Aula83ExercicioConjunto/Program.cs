using System;
using System.Collections.Generic;

namespace Aula83ExercicioConjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O Curso A possui quantos alunos? ");
            int alunosA = int.Parse(Console.ReadLine());

            HashSet<int> A = new HashSet<int>();
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < alunosA; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("==============================================================");
            Console.WriteLine("O Curso B possui quantos alunos? ");
            int alunosB = int.Parse(Console.ReadLine());

            HashSet<int> B = new HashSet<int>();
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < alunosB; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("==============================================================");
            Console.WriteLine("O Curso C possui quantos alunos? ");
            int alunosC = int.Parse(Console.ReadLine());

            HashSet<int> C = new HashSet<int>();
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < alunosC; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine($"Total alunos: {Novo.Count}");
        }
    }
}
