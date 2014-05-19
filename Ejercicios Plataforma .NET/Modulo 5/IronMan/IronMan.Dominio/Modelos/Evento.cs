using System;
using System.Collections.Generic;

namespace IronMan.Dominio.Modelos
{
    public partial class Evento
    {
        public Evento()
        {
            this.Pruebas = new List<Prueba>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Comentario { get; set; }
        public bool EstaHabilitado { get; set; }
        public virtual ICollection<Prueba> Pruebas { get; set; }

        public override string ToString()
        { 
            String retorno;
            retorno = "Nombre : " + this.Nombre + "\n";
            retorno = retorno + "Lugar :" + this.Lugar;
            return retorno;
        }
    }
}
