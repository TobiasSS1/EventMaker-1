using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Popups;

namespace EventMaker.Model
{
    class EventCatalogSingleton
    {
        public ObservableCollection<Event> Events { get; set; }
        public EventCatalogSingleton()
        {
            Events.Add(new Event(1, "Event", "pool party", "Roskilde", new DateTime(2017, 05, 08)));
            Events.Add(new Event(2, "Event2", "cafe", "Slagelse", new DateTime(2017, 08, 08)));
        }

        public void AddEvent()
        {
            //kommer noget
        }

    }
}
