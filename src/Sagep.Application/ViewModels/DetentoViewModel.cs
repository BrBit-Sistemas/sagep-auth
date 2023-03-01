using System;

namespace Sagep.Application.ViewModels
{
    public class DetentoViewModel
    {
        public Guid? Id { get; set; }
        public string Ipen { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
    }
}