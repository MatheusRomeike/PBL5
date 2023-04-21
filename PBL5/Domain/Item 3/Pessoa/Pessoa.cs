using PBL5.Domain.Core;

namespace PBL5.Domain.Item_3.Pessoa
{
    public class Pessoa
    {
        #region Atributos
        public Conta Conta { get; set; }
        #endregion

        #region Métodos
        public void Depositar(decimal valor)
        {
            Conta.Depositar(valor);
        }

        public void GetConta()
        {
            Conta.MostrarSaldo();
        }
        #endregion
    }
}
