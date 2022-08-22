using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsManager.Domain
{
    public class Login
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Senha { get; set; }
    }
}
