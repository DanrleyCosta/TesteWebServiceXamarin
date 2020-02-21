using System;
using System.Collections.Generic;
using System.Text;

namespace SiggaTesteWS.Model
{
    // Criação das entidades do meu dominio Comentários 
    class CommentsDomain
    {
        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
