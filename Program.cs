using System;
using System.Text;

namespace projetoCurso
{
    class Program
    {
        public static void Main(string[] args)
       // {
       // exemplo1();
       //exemplo2();
       //  exemplo3();
       // }

        //public static void exemplo1()
        // {
        //    int first = 2;
        //     string second = "4";
        //    int result = first + Int32.Parse(second);
        //    Console.WriteLine(result);

        //  Console.WriteLine("result");

        public static void exemplo2()
        {
            Console.WriteLine($" size of Int16 = {sizeof(Int16)}");
            Console.WriteLine($"Int16.MinValue = {Int16.MaxValue}");
            Console.WriteLine($"Int32.MaxValue = {Int32.MaxValue}");
            Console.WriteLine($"size of Int32 = {sizeof(Int32)}");
            Console.WriteLine($"Int32.MaxValue = {Int32.MaxValue}");
            Console.WriteLine($"Int32.MaxValue = {Int32.MaxValue}");
        }


        public static void exemplo3()
        {
            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();


            var enderecoTemp = Console.ReadLine();

            Console.WriteLine("Digite o seu Numero telefone: ");
            var numeroTelefoneTemp = Console.ReadLine();
            int numeroTelefone;
            if (!Int32.TryParse(numeroTelefoneTemp, out numeroTelefone))
            {
                Console.WriteLine("Numero incorreto");
            }
            else
            {
                Console.WriteLine(numeroTelefone);
            }

            var bairro = Console.ReadLine();
            var cidade = Console.ReadLine();
            var estado = Console.ReadLine();

            Console.WriteLine("Digite o seu CEP;");
            var cepTemp = Console.ReadLine();
            int cep;
            if (!Int32.TryParse(cepTemp, out cep))
            {
                Console.WriteLine("Numero incorreto!");
            }
            else
            {
                Console.WriteLine(cep);
            }

            Console.WriteLine(cep);
            var cpf = Console.ReadLine();
            Console.WriteLine(cpf);

            Console.WriteLine("Digite o valor:");
            var valorCompratemp = Console.ReadLine();
            double valorCompra;
            if (!double.TryParse(valorCompratemp, out valorCompra))
            {
                Console.WriteLine("Valor incorreto!");
            }
            else
            {
                Console.WriteLine(valorCompra);
            }
            Console.ReadLine();
        }

        //Construa um programa que receba 4 notas, faça o calculo da média aritmetica e imprima o resultado, conforme regras:
        //Nota de 0 a 10;
        //media maior ou igual a 7 = Aprovado
        //media abaixo de 5 = reprovado
        //demais em exame
        public static void exercicio1()
        {

            int indice = 0;
            float total = 0, nota;
            float media =0;

            for (int i = 0; 3 < i; i++)
            {
                Console.WriteLine($"1/4 Digite {i} notas  ");
                var notaTemp = Console.ReadLine();
                float.TryParse(notaTemp, out nota);
                total += nota;

            }
            media = total/ 4;
             
            if (media < 5)
            {
                Console.WriteLine("Aluno Reprovado");
            }
            else if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado ");
            }
            else if (media)
            {

            }

        }

        public static void Main()
        {
            int valor =(int)1.5; //Cast. explicito.

            Console.WriteLine(valor);

            object val = new StringBuilder();

            if (val is StringBuilder) // Verificação do Cast com IS.
            {
                 StringBuilder builder = val as StringBuilder; // Cast com operados AS.
                 Console.WriteLine(builder.Length == 0);
            }
        }



    }




}  



