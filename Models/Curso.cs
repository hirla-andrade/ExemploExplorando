using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) { 

            Alunos.Add(aluno); 
            }

            public int ObterQuantidadeAlunosMatriculados(){

                int quantidade = Alunos.Count;
                return quantidade;
            }

            public bool RemoverAluno(Pessoa aluno) {
                return Alunos.Remove(aluno);
            }

            public void ListarAlunos(){
                Console.WriteLine($"Alunos do curso de: {Nome}");

                for (int count = 0; count < Alunos.Count; count++) {

                    //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto; // concatenação, string texto concatenou vários pedaços de texto em 1 só
                    string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}"; // interculação é entre "" e tem $, é + legível
                    Console.WriteLine(texto);
                }

            }
    }
}