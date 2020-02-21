using System;
using System.Collections.Generic;
using System.Text;

namespace SiggaTesteWS.Model
{
    // Criação das entidades do meu dominio Photos
    class PhotoDomain
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
