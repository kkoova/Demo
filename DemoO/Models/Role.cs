using System.ComponentModel.DataAnnotations.Schema;

namespace DemoO.Models
{
    [Table ("Role")]
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
