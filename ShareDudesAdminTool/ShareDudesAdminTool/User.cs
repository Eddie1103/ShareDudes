using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    public sealed class User
    {
        private int _id;
        private string _userName;
        private bool _isAdmin;
        private bool _isBanned;
        private bool _hasPosts;

        public User()
        {
            _id = -1;
            _userName = string.Empty;
            _isAdmin = false;
            _isBanned = false;
            _hasPosts = false;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { _isAdmin = value; }
        }

        public bool IsBanned
        {
            get { return _isBanned; }
            set { _isBanned = value; }
        }

        public bool HasPosts
        {
            get { return _hasPosts; }
            set { _hasPosts = value; }
        }

        public static User CreateUser(Npgsql.NpgsqlDataReader reader)
        {
            var newUser = new User();

            newUser.Id = Database.GetIntValue(reader, "user_id");
            newUser.UserName = Database.GetStringValue(reader, "username");
            newUser.IsBanned = Database.GetBoolValue(reader, "banned");
            newUser.IsAdmin = Database.GetBoolValue(reader, "is_admin");

            return newUser;
        }
    }
}