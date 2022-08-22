using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
   public class Chamado
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public TipoRegistro TipoRegistro { get; set; }
        public int TipoRegistroId { get; set; }

        public Severidade Severidade { get; set; }
        public int SeveridadeId { get; set; }

        public Anexo Anexo { get; set; }
        public int AnexoId { get; set; }

        public string Localizacao { get; set; }
        public string Descricao { get; set; }

        public Analista_Equipe Analista_Equipe { get; set; }
        public int EquipeId { get; set; }
        public int TecnicoId { get; set; }
        public DateTime DataRegistro { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }

        public IEnumerable<Historico> historicos { get; }



    }
}
