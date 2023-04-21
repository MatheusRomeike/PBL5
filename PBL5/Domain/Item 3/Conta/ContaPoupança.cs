using PBL5.Domain.Core;

namespace PBL5.Domain
{
    public class ContaPoupança : Conta
    {
        #region Construtor
        public ContaPoupança(decimal saldo) : base(saldo)
        {
        }
        #endregion

        #region Métodos
        public override void MostrarSaldo()
        {
            Console.WriteLine($"Saldo: R${Math.Round((Saldo * 1.005m), 2)}");
        }
        #endregion
    }
}
