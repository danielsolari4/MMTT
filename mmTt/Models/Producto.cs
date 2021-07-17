using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmTt.Models
{

    public class SizesPaths
    {
        public string Size1Path { get; set; }
        public string Size2Path { get; set; }
        public string Size3Path { get; set; }
        public string Size4Path { get; set; }
        public string Size5Path { get; set; }
    }

    public class Producto
    {
        public string Description { get; set; }
        public List<string> Keywords { get; set; }
        public string MediaUrl { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public List<string> Categories_Name { get; set; }
        public SizesPaths SizesPaths { get; set; }
        public DateTime PublicationDate { get; set; }
    }


}