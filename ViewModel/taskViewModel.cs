using MarwanMamdohW2_0523016.Models.Entites;
using System.ComponentModel.DataAnnotations;

namespace MarwanMamdohW2_0523016.ViewModel
{
    public class taskViewModel
    {
        public int taskid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int pid { get; set; }
        public int memid { get; set; }
        public IEnumerable<TeamMember> teamMembers { get; set; }
        public IEnumerable<Project> projects { get; set; }
    }
}
