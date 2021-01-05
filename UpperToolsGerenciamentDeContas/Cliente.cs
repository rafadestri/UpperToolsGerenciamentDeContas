using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperToolsGerenciamentDeContas
{
    public class Cliente : Usuario
    {
        public bool EhCliente
        {
            get => default;
            set
            {
            }
        }

        public int IdUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Nome { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataCadastro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Atualizar(int IdUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int IdUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Inserir(string Nome)
        {
            throw new NotImplementedException();
        }

        public bool Login(string Email, string Senha)
        {
            throw new NotImplementedException();
        }

        public string RecuperarSenha(string Email)
        {
            throw new NotImplementedException();
        }
    }
}