using WebCRUDSample.Interface;
using WebCRUDSample.Models;

namespace WebCRUDSample.Services
{
    public class SItemCategory : IItemCategory
    {
        private readonly DatabaseContext db;
        public SItemCategory(DatabaseContext Db)
        {
                this.db = Db;
        }

        public List<ItemCategory> ItemCategoryList()
        {
            List<ItemCategory> IC = db.SAP_ItemType_Mst.ToList();
            return IC;
        }
    }
}
