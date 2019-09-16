using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksShopOnline.Models
{
    public class Category
    {
        [ScaffoldColumn(false)] public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Tên")] public string CategoryName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}