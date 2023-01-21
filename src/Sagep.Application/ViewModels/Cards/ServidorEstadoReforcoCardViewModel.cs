using System.Collections;
using System;
using System.Collections.Generic;
using Sagep.Domain.Models;
using Sagep.Domain.Enums;

namespace Sagep.Application.ViewModels.Cards
{
    public class ServidorEstadoReforcoCardViewModel
    {
        public string CurrentMonthLabel { get; set; }
        public string SecondMonthLabel { get; set; }
        public string ThirdMonthLabel { get; set; }
        public int CurrentMonthTotal { get; set; }
        public int SecondMonthTotal { get; set; }
        public int ThirdMonthTotal { get; set; }
    }
}