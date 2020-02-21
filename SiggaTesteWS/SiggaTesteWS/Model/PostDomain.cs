using System;
using System.Collections.Generic;
using System.Text;

namespace SiggaTesteWS.Model
{
    // Criação das entidades do meu dominio Posts
    class PostDomain
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
