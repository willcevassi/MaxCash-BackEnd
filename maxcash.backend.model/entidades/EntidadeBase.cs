using System;
using System.Collections.Generic;
using System.Linq;

namespace maxcash.backend.model.entidades
{
    public abstract class EntidadeBase
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }   

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public string ObterMensagensValidacao()
        {
            return string.Join(". ", mensagemValidacao);
        }
        public abstract void Validar();
        public bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
