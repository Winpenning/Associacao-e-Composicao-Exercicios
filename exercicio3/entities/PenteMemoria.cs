namespace Associacao_e_Composicao_Exercicios.exercicio3.entities
{
    internal class PenteMemoria
    {
        private double quantidade;

        public PenteMemoria(double quantidade)
        {
            this.quantidade = quantidade;
        }

        public double getquantidade()
        {
            return quantidade;
        }
        public void setquantidade(double quantidade)
        {
            this.quantidade = quantidade;
        }
        public override string ToString()
        {
            return "\nQuantidade de memoria: " + getquantidade() + " GigaBytes";
        }
    }
}
