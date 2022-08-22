using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
   public  class Historico
    {
        public int Id { get; set; }
        public int IdRegistro { get; set; }
        public int IdTecnico { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAcao { get; set; }
    }
}
