using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class BookDetails
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Edition { get; set; }

    }
}
