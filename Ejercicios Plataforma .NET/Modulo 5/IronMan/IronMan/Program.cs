using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronMan.Dominio.Modelos;
using IronMan.Dominio.AccesoDatos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using IronMan.Gestores;
using IronMan.DTO;
using IronMan.Repositorio;


namespace IronMan
{
    class Program
    {
        static void Main(string[] args)
        {

            Program programa = new Program();
            
            try
            {
                using (EventoGestor _eGestor = new EventoGestor())
                {
                    IList<EventoDTO> _eLista = _eGestor.Listar();
                   foreach (Evento e in _eLista)
                    {
                        Console.WriteLine(e.Id);
                        Console.WriteLine(e.Nombre);
                        Console.WriteLine(e.Lugar);
                        Console.WriteLine(e.Fecha.ToString());
                        Console.WriteLine(e.Comentario);
                        Console.WriteLine(e.EstaHabilitado);
                        Console.WriteLine("-----------");

                    }

               using (var ctx = new IronManContext())
               {
                     
                    PruebaRepositorio _prueba = new PruebaRepositorio(ctx);
                    IQueryable<Prueba> _pLista = _prueba.GetTodos();
                  

                //    var _eventos = from e in ctx.Eventos
                //                   where e.Lugar == "Santa Fe"
                //                   select e;
                //    var _e = _eventos.GetTodosByLugar("Rosario").SingleOrDefault();
                //    Console.WriteLine(_e.ToString());

                //    _e.Nombre = _e.Nombre + "(MOD)";
                //    _eventos.Guardar(_e, _e.Id);

                      foreach (Prueba p in _pLista)
                      {
                          Console.WriteLine(p.Id);
                          Console.WriteLine(p.Tipo);
                          Console.WriteLine(p.Distancia);
                          Console.WriteLine(p.EstaHabilitado);
                          Console.WriteLine(p.Evento_Id);
                          Console.WriteLine("-----------");
                         
                       }

                //    Console.WriteLine("Va a agregar");
                //    Console.ReadKey();
                //    var _evento = new Evento();
                //    _evento.Nombre = "Por la vida";
                //    _evento.Lugar = "La Paz";
                //    _evento.Fecha = new DateTime(2014, 8, 25);
                //    _evento.Comentario = "Sin";
                //    _eventos.Guardar(_evento, _evento.Id);

                //    ctx.Eventos.Add(_evento);
                //    ctx.SaveChanges();

                //    Console.WriteLine("Nueva lectura");
                //    Console.ReadKey();

                //    var _eventos2 = from e in ctx.Eventos
                //                    select e;
                //    foreach (Evento e in _eventos2)
                //    {
                //        Console.WriteLine(e.ToString());
                  }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

            Console.ReadKey();
        }

        public void InicializarEventos()
        {
            //Llenado Inicial de Eventos
            try
            {
                using (var ctx = new IronManContext())
                {
                    
                    var _evento1 = new Evento();
                    _evento1.Nombre = "Por el Rio";
                    _evento1.Lugar = "Parana";
                    _evento1.Fecha = new DateTime(2014, 5, 10);
                    _evento1.Comentario = "Sin";
                    _evento1.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento1);

                    var _evento2 = new Evento();
                    _evento2.Nombre = "Corremos Todo";
                    _evento2.Lugar = "Santa Fe";
                    _evento2.Fecha = new DateTime(2014, 7, 23);
                    _evento2.Comentario = "Sin";
                    _evento2.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento2);

                    var _evento3 = new Evento();
                    _evento3.Nombre = "XMV";
                    _evento3.Lugar = "Rosario";
                    _evento3.Fecha = new DateTime(2014, 6, 25);
                    _evento3.Comentario = "Sin";
                    _evento3.EstaHabilitado = true;

                    ctx.Eventos.Add(_evento3);

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

        }

        public void InicializarPruebas()
        {
            //Llenado Inicial de Eventos
            try
            {
                using (var ctx = new IronManContext())
                {

                    var _evento = from e in ctx.Eventos
                                  where e.Nombre == "Por el Rio"
                                  select e;

                    var ev = _evento.SingleOrDefault();

                    if (ev != null)
                    {
                        var _prueba1 = new Prueba();
                        _prueba1.Tipo = "Pedestre";
                        _prueba1.Distancia = "5 K";
                        _prueba1.Evento_Id = ev.Id;
                        _prueba1.EstaHabilitado = true;
                        ctx.Pruebas.Add(_prueba1);
                    }

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }

        }
    }
}
