using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefone telefone1 = new Telefone
            {
                Ddd = 11,
                Numero = 987654321
            };

            Telefone telefone2 = new Telefone
            {
                Ddd = 22,
                Numero = 123456789
            };

            Telefone telefone3 = new Telefone
            {
                Ddd = 11,
                Numero = 569365898
            };

            Telefone telefone4 = new Telefone
            {
                Ddd = 38,
                Numero = 345981376
            };

            Telefone telefone5 = new Telefone
            {
                Ddd = 11,
                Numero = 487254876
            };


            Discente discente1 = new Discente("João", 12345, telefone1);
            Discente discente2 = new Discente("Maria", 54321, telefone2);
            Discente discente3 = new Discente("Renan", 65898, telefone3);
            Discente discente4 = new Discente("José", 65348, telefone4);
            Discente discente5 = new Discente("Fábio", 65098, telefone5);



            Disciplina disciplinaMatematica = new Disciplina() { Nome = "Matematica" };

            Disciplina disciplinaPortugues = new Disciplina() { Nome = "Potugues" };

            Disciplina disciplinaHistoria = new Disciplina() { Nome = "Historia" };

            Disciplina disciplinaArtes = new Disciplina();
            disciplinaArtes.Nome = "Artes";

            List<Disciplina> disciplinas = new List<Disciplina>();
            disciplinas.Add(disciplinaHistoria);
            disciplinas.Add(disciplinaPortugues);
            disciplinas.Add(disciplinaArtes);
            disciplinas.Add(disciplinaMatematica);

            Turma turma = new Turma();
            turma.Nome = "Turma A";
            turma.Matricular(discente1);
            turma.Matricular(discente2);
            turma.Matricular(discente3);


            Turma turma2 = new Turma();
            turma2.Nome = "Turma B";
            turma2.Matricular(discente4);
            turma2.Matricular(discente5);

            disciplinaMatematica.Matricular(discente1);
            disciplinaPortugues.Matricular(discente1);

            disciplinaArtes.Matricular(discente5);
            disciplinaHistoria.Matricular(discente5);

            disciplinaArtes.Matricular(discente2);
            disciplinaHistoria.Matricular(discente4);

            Console.WriteLine("\n" + turma.ToString());
            Console.WriteLine("Alunos da Turma:");
            foreach (var aluno in turma.Alunos)
            {
                Console.WriteLine(aluno.Nome.ToString());
            }

            Console.WriteLine("\n" + turma2.ToString());
            Console.WriteLine("Alunos da Turma:");
            foreach (var aluno in turma2.Alunos)
            {
                Console.WriteLine(aluno.Nome.ToString());
            }

            Console.ReadLine();
        }

    }
}

