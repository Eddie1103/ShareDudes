using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShareDudesAdminTool
{
    public class UserCollection
    {
        private List<User> _users;

        public User[] Users
        {
            get { return _users.ToArray(); }
        }

        public UserCollection()
        {
            _users = new List<User>();
        }


        // Data for userarray
        public void LoadUser()
        {
            using (var db = Database.Create())
            {
                using (var reader = db.Load("SELECT * FROM users"))
                {
                    while (reader.Read())
                    {
                        var user = new User();
                        user.UserName = Database.GetStringValue(reader, "username");
                        user.IsBanned = Database.GetBoolValue(reader, "banned");
                        user.IsAdmin = Database.GetBoolValue(reader, "is_admin");

                        _users.Add (user);
                    }
                }
            }
        }
    }
}
