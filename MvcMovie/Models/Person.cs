using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace MvcMovie.Models
{
    Table("Persons")

    Public class Person
    {
        [Key]
        public string PersonId {get; set}  
        public string Fullname {get; set} 
        public string Address {get; set}
        
    }
}