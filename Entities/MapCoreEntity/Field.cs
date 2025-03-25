using RCF.Modulum.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.MapCoreEntity
{
    public class Field
    {
        public Field() 
        {
            IsPrimaryKey = false; 
        }

        public int Id { get; set; }
        public string? NomeColuna { get; set; }
        public string? NomeTela { get; set; }
        public TypeColumnEnum? Tipo { get; set; }
        public int? Tamanho { get; set; }
        public bool IsPrimaryKey { get; set; }

        public int TableId { get; set; }
        public Table Table { get; set; } = null!;
    }
}
