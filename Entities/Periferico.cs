namespace Associacao_e_Composicao_Exercicios.Entities
{
    class Periferico
    {
        private string nome;
        private string descricao;
        public Periferico(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }
        public void setnome(string nome)
        {
            this.nome = nome;
        }
        public string getnome()
        {
            return this.nome;
        }
        public string getdescricao()
        {
            return descricao;
        }
        public void setdescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public override string ToString()
        {
            return "\nPeriferico: " + getnome() +
                   "\nDescricao: " + getdescricao();
        }
    }
}
