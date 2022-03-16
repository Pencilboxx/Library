using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class PersonDetails
    {
        [Key]
        public int BookId { get; set; }
       
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int PersonId { get; set; }
        public string IssueDate { get; set; }
        public string ReceivedDate { get; set; }
    }
}
