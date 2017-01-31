using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        public ObservableCollection<Event> Events { get; set; }
        public EventCatalogSingleton() : base()
        {
            Events.Add(new Event() {Id = 1, Name = "Event1", Description = "pool party", Place = "Roskilde", DateTime = new DateTime(2017, 05, 08) });
            Events.Add(new Event() {Id = 2, Name = "Event2", Description = "cafe", Place = "Slagelse", DateTime = new DateTime(2017, 08, 08)});
        }

        public void AddEvent()
        {
            //kommer noget
        }

    }
}
