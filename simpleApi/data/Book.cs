using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace simpleApi.data
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]        
        [DisplayName("book title")]
        public string Title { get; set; }

        [Required]
        [DisplayName("book description")]
        public string Desctiption { get; set; }


        [Required]
        public bool IsRead { get; set; }

        public int? Rate { get; set; }

        public DateTime? ReadDate { get; set; }
        
    }
}
