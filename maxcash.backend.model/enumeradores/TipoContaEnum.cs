using System;
using System.ComponentModel;

namespace maxcash.backend.model.enumeradores
{
    public enum TipoContaEnum
    {
     
        [Description("Conta Corrente")]
        ContaCorrente = 0,
   
        [Description("Poupança")]
        Poupanca = 1,
       
        [Description("Dinheiro")]
        Dinheiro = 2,
       
        [Description("Investimento")]
        Investimento = 3,
       
        [Description("Outro")]
        Outro = 4
    }
}
