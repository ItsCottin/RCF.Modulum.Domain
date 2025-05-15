using modulum.Domain.Contracts;
using modulum.Shared.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.DynamicEntity
{
    public class Relationship : AuditableEntity<int>
    {
        [Key]
        public int Id { get; set; }

        public int TabelaOrigemId { get; set; }
        public Table TabelaOrigem { get; set; } = null!;

        public int TabelaDestinoId { get; set; }
        public Table TabelaDestino { get; set; } = null!;

        public string CampoOrigem { get; set; } = null!;
        public string CampoDestino { get; set; } = null!;
        public string NomeConstraint { get; set; } = null!;
        public bool IsObrigatorio { get; set; } = false;
        public string? CampoParaExibicaoRelacionamento { get; set; }
        public TypeRelationshipEnum Tipo { get; set; }
    }
}
