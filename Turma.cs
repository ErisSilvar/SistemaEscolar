using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    public class Turma
    {
        public String Nome { get; set; }
        public List<Discente> Alunos { get; set; }

        public Turma()
        {
            Alunos = new List<Discente>();
        }

        public void Matricular(Discente d)
        {
            Alunos.Add(d);
            Console.WriteLine($"{d.Nome} foi matriculado na turma: {Nome}");
        }

        public override String ToString()
        {
            return $"Turma: {Nome}";
        }
    }
}
