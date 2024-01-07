namespace TestePratico.Models
{
    public class Numero
    {
        public int Num { get; set; }
        public string? Divisores { get; set; }
        public string? DivisoresPrimos { get; set; }



        public Numero Decomposicao(int numero)
        {
            this.Num = numero;
            List<int>nDiv = new List<int>();
            List<int>nPrimos = new List<int>();

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    nDiv.Add(i);
                    if (Primo(i))
                    {
                        nPrimos.Add(i);
                    }
                }
            }

            this.Divisores = String.Join(", ", nDiv);
            this.DivisoresPrimos = String.Join(", ", nPrimos);

            return this;
        }
        public bool Primo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            if (numero <= 3)
            {
                return true;
            }              

            if (numero % 2 == 0 || numero % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= numero; i = i + 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
