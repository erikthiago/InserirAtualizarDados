using InserirAtualizarDados.Models;
using InserirAtualizarDados.Repositories;
using System;
using System.Windows.Forms;

namespace InserirAtualizarDados
{
    public partial class Form1 : Form
    {
        private readonly IBaseRepository _baseRepository;
        private bool atualizacao = false;

        public Form1(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entity entity = new Entity();

            try
            {
                // Se for a inserção de um dado novo
                if (!atualizacao)
                {
                    entity.Id = Guid.NewGuid();
                    entity.Nome = textBox1.Text;
                    entity.Sobrenome = textBox2.Text;
                    _baseRepository.Inserir(entity);
                }
                // Se for atualização de um dados já existente 
                else
                {
                    entity.Id = Guid.Parse(label3.Text);
                    entity.Nome = textBox1.Text;
                    entity.Sobrenome = textBox2.Text;
                    _baseRepository.Alterar(Guid.Parse(label3.Text), entity);
                    label3.Visible = false;
                }

                Buscar();

                textBox1.Text = "";
                textBox2.Text = "";
                label3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // Já carrega os dados existentes no banco no load da aplicação
            Buscar();
            label3.Visible = false;
        }

        private void Buscar()
        {
            listView1.Items.Clear();
            // Faz a pesquisa no banco de dados
            var itens = _baseRepository.Selecionar();

            // Itera sobre os itens encontrados no banco
            foreach (var item in itens)
            {
                // Preenchendo as colunas da listview com os dados do banco
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = item.Id.ToString();
                lvItem.SubItems.Add(item.Nome);
                lvItem.SubItems.Add(item.Sobrenome);
                listView1.Items.Add(lvItem);

                listView1.FindItemWithText(item.Id.ToString());
                listView1.FindItemWithText(item.Nome);
                listView1.FindItemWithText(item.Sobrenome);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            label3.Visible = true;
            atualizacao = true;
            label3.Text = listView1.SelectedItems[0].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
