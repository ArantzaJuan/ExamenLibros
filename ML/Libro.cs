﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Nombre { get; set; }
        public int NumeroDePaginas { get; set; }
        public string FechaPublicacion { get; set; }
        public string Edicion { get; set; }
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }
        public int IdGenero { get; set; }
        public Autor Autor { get; set; }    

    }
}
