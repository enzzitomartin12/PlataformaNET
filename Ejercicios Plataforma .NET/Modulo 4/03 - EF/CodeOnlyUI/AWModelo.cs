using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.EntityClient;
using CodeOnlyData;

namespace CodeOnlyUI
{
    class AWModelo:ObjectContext
    {
        public AWModelo(EntityConnection connection): base(connection)
        {
            DefaultContainerName = "AWModelo";
        }

        public IObjectSet<Contacto> Contacto
        {
            get { return base.CreateObjectSet<Contacto>(); }
        }

        public IObjectSet<Empleado> Employee
        {
            get { return base.CreateObjectSet<Empleado>(); }
        }
    }
}
