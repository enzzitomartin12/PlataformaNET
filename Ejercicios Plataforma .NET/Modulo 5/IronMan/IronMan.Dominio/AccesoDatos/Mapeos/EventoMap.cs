using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using IronMan.Dominio.Modelos;

namespace IronMan.Dominio.AccesoDatos.Mapeos
{
    public class EventoMap : EntityTypeConfiguration<Evento>
    {
        public EventoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired();

            this.Property(t => t.Lugar)
                .IsRequired();

            this.Property(t => t.Comentario)
                .IsRequired();

            this.Property(t => t.EstaHabilitado)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Eventos");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nombre).HasColumnName("Nombre").HasMaxLength(50);
            this.Property(t => t.Fecha).HasColumnName("Fecha");
            this.Property(t => t.Lugar).HasColumnName("Lugar").HasMaxLength(50);
            this.Property(t => t.Comentario).HasColumnName("Comentario").HasMaxLength(500);
            this.Property(t => t.EstaHabilitado).HasColumnName("Habilitado");
        }
    }
}