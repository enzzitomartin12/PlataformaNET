using System;
using System.Collections.Generic;

namespace IronMan.Dominio.Modelos
{
    public partial class Prueba
    {
        public Prueba()
        {
            this.Participantes = new List<Participante>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Distancia { get; set; }
        public int Evento_Id { get; set; }
        public bool EstaHabilitado { get; set; }

        public virtual Evento Evento { get; set; }
        public virtual ICollection<Participante> Participantes { get; set; }
    }
}
