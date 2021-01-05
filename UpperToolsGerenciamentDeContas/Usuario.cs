using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperToolsGerenciamentDeContas
{
    public interface Usuario
    {
        int IdUsuario { get; set; }
        string Nome { get; set; }
        DateTime DataCadastro { get; set; }
        bool Inserir(string Nome);
        bool Atualizar(int IdUsuario);
        bool Excluir(int IdUsuario);
        bool Login(string Email, string Senha);
        string RecuperarSenha(string Email);
    }
}