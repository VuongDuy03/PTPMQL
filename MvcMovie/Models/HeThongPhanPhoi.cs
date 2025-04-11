using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    [Table("HeThongPhanPhoi")]
    public class HeThongPhanPhoi
    {
        public string? MaHTPP{get; set;}
        public string? TenHTPP{get; set;}
    }
    
}