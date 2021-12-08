﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    
    public class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}