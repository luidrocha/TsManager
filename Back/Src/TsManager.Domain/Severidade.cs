using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class Severidade
    {
        public int Id { get; set; }
        public string Classificacao { get; set; }
        public string Descricao { get; set; }
        public Boolean EnviarEmail { get; set; }
    }
}
