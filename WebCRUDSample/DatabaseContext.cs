using Microsoft.EntityFrameworkCore;
using WebCRUDSample.Models;

namespace WebCRUDSample
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> con) : base(con)
        {
                
        }
        public DbSet<ItemCategory> SAP_ItemType_Mst {  get; set; }
    }
}
