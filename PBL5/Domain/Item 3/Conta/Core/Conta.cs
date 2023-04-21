namespace PBL5.Domain.Core
{
    public class Conta
    {
        #region Atributos
        protected decimal Saldo { get; set; }
        #endregion

        #region Construtor
        public Conta(decimal saldo)
        {
            Saldo = saldo;
        }
        #endregion

        #region Métodos
        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual void MostrarSaldo()
        {
            Console.WriteLine($"Saldo: R${Saldo}");
        }
        #endregion
    }
}
