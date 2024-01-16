using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    internal class ReportCollection
    {
        private List<Reports> _report;

        public Reports[] Reports

        {
            get { return _report.ToArray(); }
        }

        public ReportCollection()
        {
            _report = new List<Reports>();
        }

        // Data for userarray
        public void LoadReport()
        {
            using (var db = Database.Create())
            {
                using (var reader = db.Load("SELECT * FROM offer_report"))
                {
                    while (reader.Read())
                    {
                        var post = new Reports();

                        var report = new Reports();
                        report._reportTitle = Database.GetStringValue(reader, "title");
                        report._reportText = Database.GetStringValue(reader, "text");

                        _report.Add(post);
                    }
                }
            }
        }
    }
}
