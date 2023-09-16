namespace Crud_Produtos
{
    public partial class Form1 : Form
    {
        private List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string nome = txtNome.Text;

            Produto produto = new Produto(id, nome);
            produtos.Add(produto);

            LimparCampos();
            AtualizarListaProdutos();
        }

        private void AtualizarListaProdutos()
        {
            lstProdutos.Items.Clear();

            foreach (Produto produto in produtos)
            {
                lstProdutos.Items.Add($"{produto.ID} - {produto.Nome}");
            }
        }

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string novoNome = txtNome.Text;

            Produto produto = produtos.Find(p => p.ID == id);
            if (produto != null)
            {
                produto.Nome = novoNome;
                LimparCampos();
                AtualizarListaProdutos();
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            Produto produto = produtos.Find(p => p.ID == id);
            if (produto != null)
            {
                produtos.Remove(produto);
                LimparCampos();
                AtualizarListaProdutos();
            }
            else
            {
                MessageBox.Show("Produto não encontrado!");
            }
        }
    }
}

