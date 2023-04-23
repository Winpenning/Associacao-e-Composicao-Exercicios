using System.Threading.Channels;

namespace Associacao_e_Composicao_Exercicios.Entities
{
    class Computador
    {
        private string modelo;
        private string marca;
        private PlacaMae placamae;
        List<Periferico> perifericos;
        List<Usuario> usuarios;
        public Computador(string modelo, string marca, PlacaMae placaMae)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.placamae = placaMae;
            perifericos = new List<Periferico>();
            usuarios = new List<Usuario>();
        }

        public void setmodelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getmodelo()
        {
            return this.modelo;
        }
        public void setmarca(string marca)
        {
            this.marca = marca;
        }
        public string getmarca()
        {
            return this.marca;
        }

        public PlacaMae getplacamae()
        {
            return this.placamae;
        }
        public void associarperiferico(Periferico periferico)
        {
            this.perifericos.Add(periferico);
        }
        public int qtdsperifericos()
        {
            return perifericos.Count();
        }
        public void associarusuario(Usuario usuario)
        {
            this.usuarios.Add(usuario);
        }
        public List<Usuario> getusuarios()
        {
            return usuarios;
        }
        public override string ToString()
        {
            return "\nModelo do computador: " + getmodelo() +
                   "\nMarca do computador: " + getmarca() +
                   "\n-----------------------------------" +
                   getplacamae() +
                   "\n-----------------------------------" +
                   "\nUsuarios: " + getusuarios();
        }
    }
}
