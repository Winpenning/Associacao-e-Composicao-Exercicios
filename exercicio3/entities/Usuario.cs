namespace Associacao_e_Composicao_Exercicios.exercicio3.entities
{
    class Usuario
    {
        private string nome;
        private List<Computador> computadores;
        public Usuario(string nome)
        {
            this.nome = nome;
            computadores = new List<Computador>();
        }
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public string getnome()
        {
            return nome;
        }
        public void associarcomputador(Computador computador)
        {
            computadores.Add(computador);
        }

        public List<Computador> getcomputadores()
        {
            return computadores;
        }

        public override string ToString()
        {
            return "\nNome: " + getnome() +
                   "\nComputador(es): " + getcomputadores();
        }
    }
}
