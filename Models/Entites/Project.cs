using System.ComponentModel.DataAnnotations;

namespace MarwanMamdohW2_0523016.Models.Entites
{
    public class Project
    {
        public int Projectid { get; set;  }
        [MaxLength(100),Required]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<task> tasks { get; set; }
    }
}
