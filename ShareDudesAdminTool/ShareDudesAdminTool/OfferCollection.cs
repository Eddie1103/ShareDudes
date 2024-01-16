using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareDudesAdminTool
{
    internal class OfferCollection
    {
        private List<Offer> _offers;

        public Offer[] Offers

        {
            get { return _offers.ToArray(); }
        }

        public OfferCollection()
        {
            _offers = new List<Offer>();
        }

        // Data for userarray
        public void LoadOffer()
        {
            using (var db = Database.Create())
            {
                using (var reader = db.Load("SELECT * FROM offers"))
                {
                    while (reader.Read())
                    {
                        var post = new Offer();

                        var offer = new Offer();
                        offer.Title = Database.GetStringValue(reader, "title");
                        offer.Description = Database.GetStringValue(reader, "text");
                        // status
                        // offer.IsDeactivated = Database.GetBoolValue(reader, "")

                        _offers.Add(post);
                    }
                }
            }
        }
    }
}
