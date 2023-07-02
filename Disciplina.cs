using System;
using System.Collections.Generic;


namespace SistemaEscolar
{
    public class Disciplina
    {
        public String Nome { get; set; }

        public Disciplina()
        {

        }

        public void Matricular(Discente d)
        {
            d.DisciplinaMatriculada.Add(this);
            Console.WriteLine($"{d.Nome} foi matriculado na disciplina: {Nome}");
        }

        public override String ToString()
        {
            return $"{Nome}";
        }
    }
}

