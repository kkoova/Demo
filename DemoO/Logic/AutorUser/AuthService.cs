using DemoO.Models;
using DemoOne.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DemoO
{
    public class AuthService
    {
        public UserWithRole Authenticate(string login, string password)
        {
            using (var context = new MyDbContext())
            {
                var userJoin = from u in context.Users
                               join r in context.Roles on u.UserRole equals r.RoleID
                               where u.UserLogin == login && u.UserPassword == password
                               select new UserWithRole
                               {
                                   UserName = u.UserName,
                                   UserSurname = u.UserSurname,
                                   RoleName = r.RoleName,
                               };

                return userJoin.FirstOrDefault();
            }
        }
    }
}
