using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpperToolsGerenciamentDeContas
{
    public class Arquivo
    {
        public string Nome
        {
            get => default;
            set
            {
            }
        }

        public int IdArquivo
        {
            get => default;
            set
            {
            }
        }

        public decimal Tamanho
        {
            get => default;
            set
            {
            }
        }

        public TipoArquivo TipoArquivo
        {
            get => default;
            set
            {
            }
        }

        public string Caminho
        {
            get => default;
            set
            {
            }
        }

        public bool Adicionar(Byte[] Arquivo)
        {
            throw new System.NotImplementedException();
        }

        public bool EXcluir(string Nome, string Caminho)
        {
            throw new System.NotImplementedException();
        }
    }
}