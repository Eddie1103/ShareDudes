using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    public sealed class User
    {
        private string _userName;
        private bool _isAdmin;
        private bool _isBanned;
        private bool _hasPosts;

        public User()
        {
            _userName = string.Empty;
            _isAdmin = false;
            _isBanned = false;
            _hasPosts = false;
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

    }
}