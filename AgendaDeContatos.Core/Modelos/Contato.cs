﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaDeContatos.Core.Modelos
{
    public class Contato : EntidadeBase
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime? Nascimento { get; set; }
        public ICollection<Telefone> Telefones { get; set; }       
    }   
}
