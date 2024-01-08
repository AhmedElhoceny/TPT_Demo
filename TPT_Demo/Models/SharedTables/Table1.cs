using System.ComponentModel.DataAnnotations.Schema;

namespace TPT_Demo.Models.SharedTables
{
    [Table("Table1")]
    public class Table1 : BaseEntity
    {
        public string PropertyForTable1 { get; set; }
    }
}
