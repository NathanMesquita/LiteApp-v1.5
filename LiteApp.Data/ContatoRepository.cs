using LiteApp.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LiteApp.Data {
    public class ContatoRepository {
        private readonly string caminhoArquivo = "contatos.json";

        public List<Contato> Carregar() {
            if (!File.Exists(caminhoArquivo))
                return new List<Contato>();

            string json = File.ReadAllText(caminhoArquivo);

            // ✅ Aqui está o jeito certo:
            return JsonConvert.DeserializeObject<List<Contato>>(json) ?? new List<Contato>();
        }

        public void Salvar(List<Contato> contatos) {
            string json = JsonConvert.SerializeObject(contatos, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, json);
        }
    }
}