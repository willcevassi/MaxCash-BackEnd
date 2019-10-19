using System;
using maxcash.backend.model.enumeradores;

namespace maxcash.backend.model.entidades
{
    public class Conta : EntidadeBase
    {

        public int ContaId { get; set; }
        public string Nome { get; set; }
        public Decimal Saldo { get; set; }
        public string Cor { get; set; }
        public TipoContaEnum TipoConta { get; set; }
        public bool AdicionaDashBoard { get; set; }

        public Usuario Usuario { get; set; }

        public Conta()
        {
            Saldo = 0;
            TipoConta = 0;
            AdicionaDashBoard = true;
        }

        public override void Validar()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não foi informado");
            if (Usuario == null)
            {
                AdicionarCritica("Usuário não definido");
            }
        }
    }
}
