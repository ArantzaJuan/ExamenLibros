﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class Conexion
    {
        public static string ConnectionString()
        {
            return ConnectionManagemet["ZjuanLibros"];
           
        }
    }
}
