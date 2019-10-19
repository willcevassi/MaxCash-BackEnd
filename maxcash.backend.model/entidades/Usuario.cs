using System;

namespace maxcash.backend.model.entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public string Situacao { get; set; }
    }
}
