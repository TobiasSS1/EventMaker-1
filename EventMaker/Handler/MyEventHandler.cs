﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventMaker.Converter;
using EventMaker.Model;
using EventMaker.ViewModel;

namespace EventMaker.Handler
{
    class MyEventHandler
    {
        public EventViewModel ViewModel { get; set; }

        public MyEventHandler(EventViewModel Event)
        {
            this.ViewModel = Event;
        }
        public void CreateEvent()
        {
            Event NewEvent = new Event(ViewModel.Id, ViewModel.Name, ViewModel.Description, ViewModel.Place, DateTimeConverter.DateTimeOffsetAndTimeSetToDateTime(ViewModel.Date, ViewModel.Time));
        }
    }
}
