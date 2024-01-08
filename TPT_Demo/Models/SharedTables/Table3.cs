using System.ComponentModel.DataAnnotations.Schema;

namespace TPT_Demo.Models.SharedTables
{
    [Table("Table3")]
    public class Table3 : BaseEntity
    {
        public string PropertyForTable3 { get; set; }
    }
}
