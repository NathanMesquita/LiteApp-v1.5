namespace LiteApp.Domain {
    public class Contato {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato() { }

        public Contato(string nome, string telefone) {
            Nome = nome;
            Telefone = telefone;
        }
    }
}