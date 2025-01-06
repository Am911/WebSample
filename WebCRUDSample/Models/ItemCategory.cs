using System.ComponentModel.DataAnnotations;

namespace WebCRUDSample.Models
{
    public class ItemCategory
    {
        [Key]
        public int pk_typeId { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? IsMedicine { get; set; }
        public string? IsConsumable { get; set; }
        public string? Reamrk { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
