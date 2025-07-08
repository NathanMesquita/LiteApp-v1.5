using LiteApp.Data;
using LiteApp.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LiteAppSolution {
    public partial class Form1 : Form {
        private List<Contato> listaContatos = new List<Contato>();
        private ContatoRepository repositorio = new ContatoRepository();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            listaContatos = repositorio.Carregar();
            AtualizarLista();

            btnExcluir.Enabled = false;
            lstContatos.SelectedIndexChanged += lstContatos_SelectedIndexChanged;
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            string nome = txtNome.Text.Trim();
            string telefone = txtTelefone.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            Contato novoContato = new Contato(nome, telefone);
            listaContatos.Add(novoContato);
            repositorio.Salvar(listaContatos);

            AtualizarLista();
            LimparCampos();
        }

        private void AtualizarLista() {
            lstContatos.Items.Clear();
            foreach (var contato in listaContatos)
            {
                lstContatos.Items.Add($"{contato.Nome} - {contato.Telefone}");
            }
        }

        private void LimparCampos() {
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            int indice = lstContatos.SelectedIndex;

            if (indice == -1)
            {
                MessageBox.Show("Selecione um contato para excluir.");
                return;
            }

            // Confirmação opcional
            var confirmar = MessageBox.Show("Deseja realmente excluir este contato?", "Confirmação", MessageBoxButtons.YesNo);
            if (confirmar != DialogResult.Yes)
                return;

            listaContatos.RemoveAt(indice);
            repositorio.Salvar(listaContatos);
            AtualizarLista();
        }
        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e) {
            btnExcluir.Enabled = lstContatos.SelectedIndex != -1;
        }
    }
}