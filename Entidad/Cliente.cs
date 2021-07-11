﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente: Entity
    {        
        public string Identificacion { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string Direccion { get; private set; }  
        public double Salario { get; private set; }
    }
}
