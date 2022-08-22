using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class TipoRegistro
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Sla Sla { get; set; }
        public int SlaId { get; set; }

    }
}
