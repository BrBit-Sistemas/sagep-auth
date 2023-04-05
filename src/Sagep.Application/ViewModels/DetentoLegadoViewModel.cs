using System;

namespace Sagep.Application.ViewModels
{
    public class DetentoLegadoViewModel
    {
        public Guid? Id { get; set; }
        public int IdLegado { get; set; }
        public string Id_unity { get; set; }
        public string Id_inmate { get; set; }
        public string Contact_name { get; set; }
        public string Contact_nickname  { get; set; }
        public string Contact_id_status { get; set; }
        public string Contact_document_1 { get; set; }
        public string Contact_document_2 { get; set; }
        public string Code_pront { get; set; }
        public string Dt_prison { get; set; }
        public string Id_situation { get; set; }
        public string Id_regime { get; set; }
        public string Cel { get; set; }
        public string Block { get; set; }
        public string Pavilion { get; set; }
        public string Floor { get; set; }
        public string Gallery { get; set; }
        public string Pagination { get; set; }
    }
}