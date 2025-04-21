using modulum.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities
{
    public class NugetPacote : AuditableEntity<int>
    {
        public int Id { get; set; }
        public string Pacote { get; set; }
        public string RequestedVersion { get; set; }
        public string ResolvedVersion { get; set; }
        public string Framework { get; set; }
        public string PacoteRaiz { get; set; }
    }
}
