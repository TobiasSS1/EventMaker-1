using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMaker.Model
{
    class EventCatalogSingleton : ObservableCollection<Event>
    {
        public EventCatalogSingleton() : Base()
        {
            
        }
    }
}
