using System.Dynamic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Sagep.Domain.Enums;
using Sagep.Domain.Models;
using Sagep.Application.ViewModels;
using System.Collections.Generic;

namespace Sagep.Application.ViewModels
{
    public class ServidorEstadoReforcoEventoViewModel
    {
        public List<EventFullCalendar> Eventos { get; set; }
    }

    public class EventFullCalendar
    {
        public bool AllDay { get; set; }
        public string Title { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Description { get; set; }
        public string ClassName { get; set; }
        public string Rendering { get; set; }
        public string Background { get; set; }
    }
}