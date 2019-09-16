using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetBooks().ForEach(p => context.Books.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category>

            {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Hàng Mẫu"
                },
                new Category
        {
                    CategoryID = 2, CategoryName = "Hàng Mới"
        },
                new Category
        {
                    CategoryID = 3,
                    CategoryName = "Hàng Giảm Giá"
        },
                new Category
        { CategoryID = 4, CategoryName = "Hàng tặng" } }; return categories; }
        private static List<Book> GetBooks()
        {
            var books = new List<Book>
            {                 //book 1 

 new Book
{
    BookID = 1,
   BookName = "combo apple",
 Description = "Gồm laptop,Máy in, Tv, ipad,...",
  ImagePath="hinh1.jpg",
  UnitPrice = 100.000f,
   CategoryID = 1
     },                
  //book 2     
     new Book
    {
          BookID = 2,
          BookName = "combo banasonic",
          Description = "các thiết bị chụp hình ,nghe nhạc ",
         ImagePath ="hinh2.jpg",
 UnitPrice = 40.000f,
 CategoryID = 2
 },                
  //book 3               
  new Book
   {
     BookID = 3,
     BookName = "double kĩ thuật số",
    Description = "bộ đôi điện thoại máy ảnh kĩ thuật số",
                     ImagePath="images22.jpg",
        UnitPrice = 26.730f,
         CategoryID = 2
  },               
   //book 4        
         new Book
     {
   BookID = 4,
       BookName = "double s6",

               Description = "điện thoại adroi và ios hàng 95%",
             ImagePath ="iphone-0.jpg",
   UnitPrice = 45.000f,
  CategoryID = 3
 },               
  //book 5               
  new Book
      {
      BookID = 5,
                  BookName = "Gấu bông qoobee agapi",
                  Description = "Hàng tặng không bán",
  ImagePath="b64a4c1660433cb65501be2eade9caf8.jpg",
  UnitPrice = 0.0f,
  CategoryID = 4
 },

            };
            return books;
        }
    }
}