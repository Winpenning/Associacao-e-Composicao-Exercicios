namespace Associacao_e_Composicao_Exercicios.exercicio3.entities
{
    internal class Fonte
    {
        private double tensao;
        private double corrente;
        public string? marca;

        public Fonte(double tensao, double corrente, string marca)
        {
            this.tensao = tensao;
            this.corrente = corrente;
            this.marca = marca;
        }

        public void settensao(double tensao)
        {
            this.tensao = tensao;
        }
        public double gettensao()
        {
            return tensao;
        }
        public void setcorrente(double corrente)
        {
            this.corrente = corrente;
        }
        public double getcorrente()
        {
            return corrente;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }

        public string getmarca()
        {
            return marca;
        }

        public override string ToString()
        {
            return "\nMarca da fonte: " + getmarca() +
                   "\nTensao eletrica da fonte: " + gettensao() +
                   "\nCorrente eletrica da fonte:" + getcorrente();
        }
    }
}
