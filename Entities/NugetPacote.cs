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
        public string? Nome { get; set; }
        public string? Versao { get; set; }
    }
}
