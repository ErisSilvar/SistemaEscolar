using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    public class Discente
    {
        static Int32 Serial { get; set; }
        public String Nome { get; set; }
        public Int32 Matricula { get; set; }
        public Telefone FonePrincipal { get; set; }
        public List<Disciplina> DisciplinaMatriculada { get; set; }

        static Discente()
        {
            Serial = 10;
        }

        public Discente()
        {
            DisciplinaMatriculada = new List<Disciplina>();
        }

        public Discente(String nome, Int32 matricula, Telefone telefones)
        {
            Nome = nome;
            Matricula = matricula;
            FonePrincipal = telefones;
            DisciplinaMatriculada = new List<Disciplina>();
        }


        public override String ToString()
        {
            string disciplinas = string.Join(",", DisciplinaMatriculada);
            return $"\nDiscente: \nNome: {Nome} \nSerial: {Serial} \nMatrícula: {Matricula} \nDisciplina Matriculadas: {(DisciplinaMatriculada.Count > 0 ? disciplinas : "Nenhuma")} {FonePrincipal} ";
        }
    }

}
