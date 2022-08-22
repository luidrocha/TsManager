using System;
using System.Collections.Generic;

namespace TsManager.Domain
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public Login Login { get; set; }
        public int LoginId { get; set; }

       public IEnumerable<UsuarioChamado> Chamados { get; }



    }
}
