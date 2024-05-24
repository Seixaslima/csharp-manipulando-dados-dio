using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_manipulando_dados_dio.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        private void Metodo2()
        {
            Metodo3();
        }
        private void Metodo3()
        {
            Metodo4();
        }
        private void Metodo4()
        {
            throw new Exception("Ocorreu uma exeção");
        }
    }
}