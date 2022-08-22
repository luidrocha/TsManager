using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class Sla
    {
        public int Id { get; set; }
        public string Indicador { get; set; }
        public string Descricao { get; set; }
        public int Tempo { get; set; }
    }
}
