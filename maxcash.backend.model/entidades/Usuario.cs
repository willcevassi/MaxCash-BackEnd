using System;
using System.Collections;
using System.Collections.Generic;
using maxcash.backend.model.enumeradores;

namespace maxcash.backend.model.entidades
{
    public class Usuario : EntidadeBase
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }
        public IEnumerable<Conta> Contas { get; set; }

        public Usuario() { 
        }

        public override void Validar()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informado");
        }
    }
}
