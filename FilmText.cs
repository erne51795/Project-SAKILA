﻿using System;
using System.Collections.Generic;

namespace SAKILA.Models
{
    public partial class FilmText
    {
        public short FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}