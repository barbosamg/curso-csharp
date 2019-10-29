using System;

namespace Aula89FuncoesString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "  abcde FGHIJ ABC abc DEFG   ";

            //CONVERTER PARA MAIUSCULO
            string maiusculo = original.ToUpper();
            Console.WriteLine($"Original: {original} - ToUpper: {maiusculo}");
            Console.WriteLine();
            //CONVERTER PARA MINUSCULO
            string minusculo = original.ToLower();
            Console.WriteLine($"Original: {original} - ToLower: {minusculo}");
            Console.WriteLine();
            //REMOVER ESPEÇOS DO INICIO E FIM DA STRING
            string trim = original.Trim();
            Console.WriteLine($"Original: {original} - Trim: {trim}");
            Console.WriteLine();
            //BUSCAR A PRIMEIRA POSICAO DE UM VALOR DENTRO DA STRING
            int idxOf = original.IndexOf("bc");
            Console.WriteLine($"Original: {original} - IndexOf: {idxOf}");
            Console.WriteLine();
            //BUSCAR A ULTIMA POSICAO DE UM VALOR DENTRO DA STRING
            int idxOfLast = original.LastIndexOf("ghjz");
            Console.WriteLine($"Original: {original} - IndexOf: {idxOfLast}");
            Console.WriteLine();
            //RECORTAR A STRING (CORTAR A PARTIR DA POSICAO 5)
            string recorteString = original.Substring(5);
            Console.WriteLine($"Original: {original} - Substring: {recorteString}");
            Console.WriteLine();
            //RECORTE DE STRING A PARTIR DE UMA POSICAO COM LIMITES DE CARACTERES A SEREM CORTADOS
            string recorteString2 = original.Substring(5, 4);
            Console.WriteLine($"Original: {original} - Substring 2: {recorteString2}");
            Console.WriteLine();
            //SUBSTITUIR PARTE DA STRING POR OUTRA
            string replace = original.Replace('a', 'W');
            string replace2 = original.Replace("abc", "wyz");
            Console.WriteLine($"Original: {original} - Replace: {replace}");
            Console.WriteLine($"Original: {original} - Replace 2: {replace2}");
            Console.WriteLine();
            //TESTE SE A STRING ESTA VAZIA
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
            //SPLIT
            string[] split = original.Split(" ");
            Console.WriteLine($"Split: {split[2]}");
            //CONVERSAO PARA NUMERO
            int numero = int.Parse("1");
            int numero2 = Convert.ToInt32("2");
            Console.WriteLine($"Conversao para numero 1: {numero} | numero 2: {numero2}");
            //CONVERSAO DE NUMERO PARA STRING
            string str1 = 3.ToString(), str2 = 3.ToString("C"), str3 = 3.ToString("C3"), str4 = 3.ToString("F2");
            Console.WriteLine($"string 1: {str1} | string 2: {str2} | string 3: {str3} | string 4: {str4} | ");
        }
    }
}
