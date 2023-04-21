namespace PBL5.Domain.Item_4
{
    public class Calculadora
    {
        #region Métodos
        public int Somar(int valor1, int valor2)
        {
            Console.WriteLine($"Somando dois valores inteiros, {valor1} e {valor2}");
            return valor1 + valor2;
        }

        public int Somar(List<int> valores)
        {
            Console.WriteLine($"Somando uma lista de valores inteiros, {string.Join(", ", valores)}");
            int resultado = 0;
            valores.ForEach(valor => resultado += valor);
            return resultado;
        }

        public int Subtrair(int valor1, int valor2)
        {
            Console.WriteLine($"Subtraindo dois valores inteiros, {valor1} e {valor2}");
            return valor1 - valor2;
        }

        public int Subtrair(List<int> valores)
        {
            Console.WriteLine($"Subtraindo uma lista de valores inteiros de maneira decrescente, {string.Join(", ", valores)}");
            int? resultado = null;
            valores.OrderByDescending(x => x).ToList().ForEach(valor =>
            {
                if (resultado == null)
                    resultado = valor;
                else
                    resultado -= valor;
            });
            return (int)resultado;
        }

        public int Multiplicar(int valor1, int valor2)
        {
            Console.WriteLine($"Multiplicando dois valores inteiros, {valor1} e {valor2}");
            return valor1 * valor2;
        }

        public List<int> Multiplicar(List<int> valores, int multiplicador)
        {
            Console.WriteLine($"Multiplicando uma lista de valores inteiros por um valor inteiro, {string.Join(", ", valores)} por {multiplicador}");
            List<int> listaResultado = new();
            valores.ForEach(valor => listaResultado.Add(valor * multiplicador));
            return listaResultado;
        }

        public float Dividir(int valor1, int valor2)
        {
            Console.WriteLine($"Dividindo dois valores inteiros, {valor1} e {valor2}");
            if (valor2 == 0)
                throw new DivideByZeroException("Não é possível dividir por zero");
            return (float)valor1 / (float)valor2;
        }

        public float Dividir(List<int> valores)
        {
            Console.WriteLine($"Dividindo a soma dos impares pela soma dos pares de uma lista de valores inteiros, {string.Join(", ", valores)}");
            int somaPares = 0, somaImpares = 0;

            for (int i = 0; i < valores.Count; i++)
            {
                if (i % 2 == 0)
                    somaPares += valores[i];
                else
                    somaImpares += valores[i];
            }

            if (somaImpares == 0)
                throw new DivideByZeroException("Não é possível dividir por zero");

            return (float)somaImpares / (float)somaPares;
        }
        #endregion
    }
}
