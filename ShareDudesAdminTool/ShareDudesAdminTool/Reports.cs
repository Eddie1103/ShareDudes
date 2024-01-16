using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    public sealed class Reports
    {
        public string _reportText;
        public string _reportTitle;

        public Reports()
        {
            _reportText = string.Empty;
            _reportTitle = string.Empty;
        }

        public string ReportText
        {
            get { return _reportText; }
            set { _reportText = value; }
        }

        public string ReportTitle
        {
            get { return _reportTitle; }
            set { _reportTitle = value; }
        }
    }
}
