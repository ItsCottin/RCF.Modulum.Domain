using modulum.Domain.Contracts;
using modulum.Shared.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.DynamicEntity
{
    public class Field : AuditableEntity<int>
    {
        public Field() 
        {
            IsPrimaryKey = false; 
        }

        [Key]
        public int Id { get; set; }
        public string? NomeCampoBase { get; set; }
        public string? NomeCampoTela { get; set; }
        public TypeColumnEnum? Tipo { get; set; }
        public int? Tamanho { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsObrigatorio { get; set; }
        public int TableId { get; set; }

        [JsonIgnore]
        public Table Table { get; set; } = null!;
    }
}
