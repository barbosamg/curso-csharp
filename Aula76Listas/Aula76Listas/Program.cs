using System;
using System.Collections.Generic;

namespace Aula76Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //POSSO INSTANCIAR COM OS VALORES
            //List<string> list2 = new List<string> { "Teste", "Test2" };

            list.Add("Maria");
            list.Add("Joao");
            list.Add("Ana");
            list.Add("Alex");
            list.Add("Mateus");
            list.Add("Gabriel");
            list.Add("Joaquin");
            list.Add("Bia");
            //DEFINIR ONDE EU QUERO ADICIONAR
            list.Insert(2, "Junia");

            foreach (string elem in list)
            {
                Console.WriteLine(elem);
            }
            //CONTAR TAMANHO DA LISTA
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Tamanho lista {list.Count}");

            //RETORNAR UM ELEMENTO A PARTIR DE UMA CONDICAO
            Console.WriteLine("-------------------------------------------------------");
            string s1 = list.Find(x => x[0] == 'A');
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Primeiro q tem 'A': {s1}");
            Console.WriteLine($"O último que tem 'A': {s2}");

            //RETORNAR UMA POSICAO QUE CORRESPONDE A UMA CONDICAO
            Console.WriteLine("-------------------------------------------------------");
            int pos1 = list.FindIndex(x => x[0] == 'A');
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Primeira posição que tem 'A': {pos1}");
            Console.WriteLine($"Última posição que tem 'A': {pos2}");

            //FILTRAR A LISTA SOMENTE COM ELEMENTOS DE 4 CARACTERES
            Console.WriteLine("-------------------------------------------------------");
            List<string> list2 = list.FindAll(x => x.Length == 4);
            foreach (string el in list2)
            {
                Console.WriteLine(el);
            }

            //REMOVER ITENS DA LISTA
            Console.WriteLine("-------------------------------------------------------");
            list.Remove("Junia");
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }
            //REMOVEALL
            Console.WriteLine("-------------------------------------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            //REMOVEAT
            Console.WriteLine("-------------------------------------------------------");
            list.RemoveAt(1);
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }

            //REMOVERANGE
            Console.WriteLine("-------------------------------------------------------");
            list.RemoveRange(1, 2);
            foreach (string el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
