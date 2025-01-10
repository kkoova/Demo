using System.ComponentModel.DataAnnotations.Schema;

namespace DemoO.Models
{
    [Table("User")]
    public class User
    {
        public int UserID { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int UserRole { get; set; }

        public virtual Role Role { get; set; }
    }
}
