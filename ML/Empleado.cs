﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {

        public int? IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string ApellidoPaterno { get; set; }



        public DateTime? FechaIngreso { get; set; }

        public byte[] FotoEmpleado { get; set; }

    }
}
