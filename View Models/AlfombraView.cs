using RugFactory.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RugFactory.View_Models
{
    class AlfombraView
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public string Calidad { get; set; }
        public string DataGridViewOwner { get; set; }
        public AlfombraView(Alfombra model)
        {
            Id = model.Alfombra_Id;
            Size = string.Format("{0} X {1}", model.Ancho, model.Largo);
            Calidad = model.Calidad;
        }
        public AlfombraView(int id, string size, string calidad,string dataGridView)
        {
            Id = id;
            Size = size;
            Calidad = calidad;
            DataGridViewOwner = dataGridView;
        }
    }
   
}
