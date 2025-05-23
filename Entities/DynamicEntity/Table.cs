﻿using modulum.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.DynamicEntity
{
    public class Table : AuditableEntity<int>
    {

        [Key]
        public int Id { get; set; }
        public string? NomeTabela { get; set; }
        public string? NomeTela { get; set; }
        public string? CampoPK { get; set; }
        public int IdUsuario { get; set; } 

        public List<Field> Fields { get; set; } = new();

        public List<Relationship> RelacionamentosComoOrigem { get; set; } = new();
        public List<Relationship> RelacionamentosComoDestino { get; set; } = new();
    }
}
