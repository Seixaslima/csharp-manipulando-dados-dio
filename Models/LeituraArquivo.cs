using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_manipulando_dados_dio.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, String[] Linhas, int NumeroLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}