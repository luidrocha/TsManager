using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class EquipeAtendimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRegistro { get; set; }
        public Boolean Ativo { get; set; }
    }
}

