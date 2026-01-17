using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarwanMamdohW2_0523016.Models.Entites
{
    public class task
    {
        [Key]
        public int taskid { get; set; }
        [MaxLength(100), Required]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string Status { get; set; }
        public string Prirority { get; set; }
        public DateTime Date { get; set; }
        public int pid { get; set; }
        [ForeignKey("pid")]
        public Project Project { get; set; }
        public int memid { get; set; }
        [ForeignKey("memid")]
        public TeamMember member { get; set; }

    }
}
