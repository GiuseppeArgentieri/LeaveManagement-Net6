using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Common.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required] //il campo successivo è necessario (quando si crea il form)
        public string? Name { get; set; }
        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25) ] //devi mettere un numero tra 1 e 25
        public int DefaultDays { get; set; }
    }
}
