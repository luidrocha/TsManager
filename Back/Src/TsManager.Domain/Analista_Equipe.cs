using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class Analista_Equipe
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public EquipeAtendimento EquipeAtendimento { get; set; }
        public int EquipeId { get; set; }

      
    }
}
