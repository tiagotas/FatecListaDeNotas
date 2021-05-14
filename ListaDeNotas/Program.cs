using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diário de Classe");

            List<Aluno> lista_alunos = new List<Aluno>();

            lista_alunos.Add(new Aluno()
            {
                Ra = 123,
                Nome = "José Antunes",
                Trabalho = 9.0,
                Exercicios = 8.0,
                Prova = 10.0,
                //Media = 9.0
            });

            lista_alunos.Add(new Aluno()
            {
                Ra = 456,
                Nome = "Maria",
                Trabalho = 10.0,
                Exercicios = 10.0,
                Prova = 9.0,
               // Media = 9.7
            });

            lista_alunos.Add(new Aluno()
            {
                Ra = 789,
                Nome = "Ronaldo",
                Trabalho = 6.0,
                Exercicios = 7.0,
                Prova = 5.0,
                //Media = 6.0
            });

            lista_alunos.Add(new Aluno()
            {
                Ra = 369,
                Nome = "Joana",
                Trabalho = 8.0,
                Exercicios = 8.0,
                Prova = 9.0,
                //Media = 8.3
            });

            lista_alunos.Add(new Aluno()
            {
                Ra = 147,
                Nome = "João",
                Trabalho = 8.0,
                Exercicios = 9.0,
                Prova = 7.0,
                //Media = 8.0
            });

            lista_alunos.Add(new Aluno()
            {
                Ra = 258,
                Nome = "Josué",
                Trabalho = 7.0,
                Exercicios = 7.0,
                Prova = 9.0,
                //Media = 7.7
            });


            /*lista_alunos.Add(a0);
            lista_alunos.Add(a1);
            lista_alunos.Add(a2);
            lista_alunos.Add(a3);
            lista_alunos.Add(a4);
            lista_alunos.Add(a5);*/

            Console.WriteLine("Temos {0} alunos no sistema ", lista_alunos.Count);


            
            for(int posicao=0; posicao<lista_alunos.Count; posicao++)
            {
                Console.WriteLine("Aluno na posição {0} é {1} ", posicao, lista_alunos[posicao].Nome);
            }


            Aluno novo_aluno = new Aluno();

            Console.WriteLine("Informe o RA: ");
            novo_aluno.Ra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Nome: ");
            novo_aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a Nota do Trabalho: ");
            novo_aluno.Trabalho = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota dos Exercícios: ");
            novo_aluno.Exercicios = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Nota da Prova ");
            novo_aluno.Prova = Convert.ToDouble(Console.ReadLine());

            /*Console.WriteLine("Informe a Média: ");
            novo_aluno.Media = Convert.ToDouble(Console.ReadLine());*/

            lista_alunos.Add(novo_aluno);

            for (int posicao = 0; posicao < lista_alunos.Count; posicao++)
            {
                Console.WriteLine(
                    "Aluno na posição {0} é {1} com a média {2} ", 
                    posicao, 
                    lista_alunos[posicao].Nome,
                    lista_alunos[posicao].Media
                );
            }


            // Como faço para alterar uma nota?
            Console.WriteLine("Vamos alterar a nota de um aluno.");
            Console.WriteLine("Informe a posição do aluno:");
            int posicao_informada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vamos alterar a nota de {0} ", lista_alunos[posicao_informada].Nome);
            Console.WriteLine("Informe a nova Nota do Trabalho, nota atual: {0}", lista_alunos[posicao_informada].Trabalho);
            lista_alunos[posicao_informada].Trabalho = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe a nova Nota do Exercício, nota atual: {0}", lista_alunos[posicao_informada].Exercicios);
            lista_alunos[posicao_informada].Exercicios = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nova Nota do Prova, nota atual: {0}", lista_alunos[posicao_informada].Prova);
            lista_alunos[posicao_informada].Prova = Convert.ToDouble(Console.ReadLine());


            for (int posicao = 0; posicao < lista_alunos.Count; posicao++)
            {
                Console.WriteLine(
                    "Aluno na posição {0} é {1} com a média {2} ",
                    posicao,
                    lista_alunos[posicao].Nome,
                    lista_alunos[posicao].Media
                );
            }


            // Como faço para remover um aluno?
            Console.WriteLine("Vamos remover um aluno");
            Console.WriteLine("Informe a posição do aluno:");
            posicao_informada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vamos REMOVER o {0} do sistema ", lista_alunos[posicao_informada].Nome);
            lista_alunos.RemoveAt(posicao_informada);


            for (int posicao = 0; posicao < lista_alunos.Count; posicao++)
            {
                Console.WriteLine(
                    "Aluno na posição {0} é {1} com a média {2} ",
                    posicao,
                    lista_alunos[posicao].Nome,
                    lista_alunos[posicao].Media
                );
            }


            // Qual foi a média da turma?
            // Vamos a LINQ
            Console.WriteLine("Média da Turma");
            double soma_todas_as_medias = lista_alunos.Sum(posicao => posicao.Media);

            double media_sala = soma_todas_as_medias / lista_alunos.Count;

            Console.WriteLine("A média da Turma é {0} ", media_sala);


            Console.WriteLine("Busca de Aluno");
            string nome_buscado = Console.ReadLine();

            Aluno resultado = lista_alunos.FirstOrDefault(posicao => posicao.Nome == nome_buscado);

            Console.WriteLine("Aluno encontrado: {0} ", resultado.Nome);
            Console.WriteLine("Média: {0} ", resultado.Media);

            Console.ReadKey();
        }
    }
}
