using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    public sealed class Offer
    {
        public bool _isDeactivated;
        public string _title;
        public string _description;
        public bool _hasAttachements;

        public Offer()
        {
            _isDeactivated = false;
            _title = string.Empty;
            _description = string.Empty;
            _hasAttachements = false;
        }

        public bool IsDeactivated
        {
            get { return _isDeactivated; }
            set { _isDeactivated = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
