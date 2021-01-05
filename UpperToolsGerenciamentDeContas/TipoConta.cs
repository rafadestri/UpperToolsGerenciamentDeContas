using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperToolsGerenciamentDeContas
{
    public class TipoConta
    {
        public int IdTipoConta
        {
            get => default;
            set
            {
            }
        }

        public string Nome
        {
            get => default;
            set
            {
            }
        }

        public string Descricao
        {
            get => default;
            set
            {
            }
        }

        public bool Inserir(string Descricao, string Nome)
        {
            throw new System.NotImplementedException();
        }

        public bool Atualizar(int IdTipoConta)
        {
            throw new System.NotImplementedException();
        }

        public bool Excluir(string IdTipoConta)
        {
            throw new System.NotImplementedException();
        }
    }
}