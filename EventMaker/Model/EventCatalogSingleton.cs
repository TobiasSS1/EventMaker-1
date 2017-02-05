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
        private static  readonly EventCatalogSingleton instance = new EventCatalogSingleton();

        public static EventCatalogSingleton Instance
        {
            get { return  instance; }
           
        }

        public ObservableCollection<Event> Events { get; set; }
        private EventCatalogSingleton()
        {

            Events = new ObservableCollection<Event>();

            Events.Add(new Event(1, "Event", "pool party", "Roskilde", new DateTime(2017, 05, 08)));
            Events.Add(new Event(2, "Event2", "cafe", "Slagelse", new DateTime(2017, 08, 08)));
        }

        public Persistency.PersistencyService pservice { get; set; }
        public void AddEvent(Event eventToAdd)
        {
            Events.Add(eventToAdd);



        }
        public void RemoveEvent(Event eventToRemove)
        {
            Events.Remove(eventToRemove);

        }

    }
}

