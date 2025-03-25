using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Domain.Entities.MapCoreEntity
{
    public class Table
    {
        public int Id { get; set; }
        public string? NomeTabela { get; set; }
        public string? NomeTela { get; set; }
        public string? JsonObject { get; set; }
        public string? TelaObject { get; set; }

        public List<Field> Fields { get; set; } = new();
    }
}
