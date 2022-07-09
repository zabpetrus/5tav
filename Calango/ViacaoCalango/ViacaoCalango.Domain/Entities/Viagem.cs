using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViacaoCalango.Domain.Entities
{
    public class Viagem
    {
        public Onibus onibus { get; set; }
        public int trechoOrigem { get; set; }
        public int trechoDestino { get; set; }
        public bool ida { get; set; }
        public DateTime dataIda{ get; set; }
        public DateTime dataVolta{ get; set; }
        public DateTime horaEmbarque{ get; set; }
        public float valor { get; set; }
        public bool volta { get; set; }
        public string classe { get; set; }        

    }
}
