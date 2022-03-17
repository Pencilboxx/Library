using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class PersoBooks
    {
        [Key]
        public int Slid { get; set; }
        public int BookId { get; set; }
        public int PersonId { get; set; }
    }
}
