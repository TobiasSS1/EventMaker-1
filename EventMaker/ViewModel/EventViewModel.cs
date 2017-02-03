using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Notifications;
using Windows.UI.Text;
using EventMaker.Common;
using EventMaker.Handler;
using EventMaker.Model;

namespace EventMaker.ViewModel
{
    
     class EventViewModel : INotifyPropertyChanged
    {
        public EventCatalogSingleton Singleton { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Place { get; set; }
        public DateTimeOffset Date { get; set; }
        public TimeSpan Time { get; set; }
        public ICommand CreateEventCommand { get; set; }
        public ICommand DeleteEventCommand { get; set; }
        public MyEventHandler eh { get; set; }
        private Event selectedEvent;

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected virtual void OnPropertyChanged( string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<Event> EventObs { get; set; }

        public Event SelectedEvent
        {
            get { return selectedEvent; }
            set { selectedEvent = value; OnPropertyChanged(nameof(SelectedEvent)); }
        }

        public EventViewModel()
        {
           
            DateTime dt = System.DateTime.Now;
            Date = new DateTimeOffset(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0, new TimeSpan());
            Time = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            eh = new MyEventHandler(this);
            CreateEventCommand = new Common.RelayCommand(eh.CreateEvent);
            DeleteEventCommand = new Common.RelayCommand(eh.DeleteEvent, DeleteEventCanExecute);
            SelectedEvent = new Event();
            EventObs = new ObservableCollection<Event>();
            EventObs = EventCatalogSingleton.Instance.Events;
        }

        private bool DeleteEventCanExecute()
        {
            return this.EventObs.Count > 0;
        }

        

    }
}
