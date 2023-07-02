using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    public class Telefone
    {
        public byte Ddd { get; set; }
        public Int32 Numero { get; set; }

        public override String ToString()
        {
            return String.Format("\nTelefone: {0:(00)} {1:00000-0000}", Ddd, Numero);
        }
    }
}
