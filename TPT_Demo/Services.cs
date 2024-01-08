using TPT_Demo.Models.Context;
using TPT_Demo.Models.SharedTables;

namespace TPT_Demo
{
    public class Services
    {
        private readonly ContextDataBase _dbContext;
        public Services(ContextDataBase dbContext)
        {
            _dbContext = dbContext;
        }

        public void Method()
        {
            // Retrieve entities from the database
            var entities = _dbContext.BaseEntities.ToList();

            foreach (var entity in entities)
            {
                // Access common properties
                Console.WriteLine($"Common Property - Id: {entity.Id}");

                // Access specific properties based on the type
                if (entity is Table1 table1Entity)
                {
                    Console.WriteLine($"Table1 Property: {table1Entity.PropertyForTable1}");
                }
                else if (entity is Table2 table2Entity)
                {
                    Console.WriteLine($"Table2 Property: {table2Entity.PropertyForTable2}");
                }
                else if (entity is Table3 table3Entity)
                {
                    Console.WriteLine($"Table3 Property: {table3Entity.PropertyForTable3}");
                }
            }
        }
    }

}
