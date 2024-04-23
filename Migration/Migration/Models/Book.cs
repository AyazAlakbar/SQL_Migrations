using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Migration.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }

    }
}
