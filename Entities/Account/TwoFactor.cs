using modulum.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.Account
{
    public class TwoFactor : AuditableEntity<int>
    {
        [Key]
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string? Code { get; set; }
        public bool IsUsed { get; set; }
    }
}
