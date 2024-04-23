// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using ORM_Migration.Data;
using ORM_Migration.Models;

using var dataContext=new AppDbContext();
var books=dataContext.Books
    .Include(l=>l.Library)
    .ToList();

foreach (var book in books)
{
    Console.WriteLine(book.Name+" "+book.Library.Name);
}
