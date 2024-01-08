using System.ComponentModel.DataAnnotations.Schema;

namespace TPT_Demo.Models.SharedTables
{
    [Table("Table2")]
    public class Table2 : BaseEntity
    {
        public string PropertyForTable2 { get; set; }
    }
}
