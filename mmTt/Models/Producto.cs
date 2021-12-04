﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mmTt.Models
{



    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MediaUrl { get; set; }
        public string CategoryName { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; }
    }


}