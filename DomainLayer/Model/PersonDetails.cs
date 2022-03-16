using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class PersonDetails
    {
      
        
        public int BookId { get; set; }
       
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Key]
        public int PersonId { get; set; }
        public string IssueDate { get; set; }
        public string ReceivedDate { get; set; }
    }
}
