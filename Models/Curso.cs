using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_manipulando_dados_dio.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AddAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Alunos do curso de {Nome}:");
                for (int Contador = 0; Contador < Alunos.Count; Contador++)
                {
                    //Concatenação de string
                    string texto = "Nº " + (Contador + 1) + " - " + Alunos[Contador].NomeCompleto;
                    Console.WriteLine(texto);
                }
            }
        }
    }
}