using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace MarwanMamdohW2_0523016.Models.Entites
{
    public class TeamMember
    {
        public int TeamMemberid { get; set; }
        [MaxLength(100),Required]
        public string name { get; set;}
        [MaxLength(100), SpecialName, Required]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Role { get; set; }
        public IEnumerable<task> tasks { get; set; }
    }
}
