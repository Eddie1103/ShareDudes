using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    public class User
    {
        private int _userId;
        private string _userName;
        private bool _isAdmin;
        private bool _isBan;
        private bool _hasPosts;

        public User()
        {
            _userId = 0;
            _userName = string.Empty;
            _isAdmin = false;
            _isBan = false;
            _hasPosts = false;
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
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

        public bool IsBan
        {
            get { return _isBan; }
            set { _isBan = value; }
        }

        public bool HasPosts
        {
            get { return _hasPosts; }
            set { _hasPosts = value; }
        }
    }
}