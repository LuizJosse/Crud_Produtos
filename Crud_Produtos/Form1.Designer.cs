namespace Crud_Produtos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            ID = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            lstProdutos = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(192, 255, 192);
            btnAdicionar.Location = new Point(37, 184);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(255, 192, 192);
            btnRemover.Location = new Point(181, 184);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 34);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(192, 192, 255);
            btnEditar.Location = new Point(338, 184);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(37, 26);
            ID.Name = "ID";
            ID.Size = new Size(30, 25);
            ID.TabIndex = 4;
            ID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(98, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(98, 91);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(251, 31);
            txtNome.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 91);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Nome";
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 25;
            lstProdutos.Location = new Point(36, 276);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(570, 129);
            lstProdutos.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(454, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(660, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lstProdutos);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(ID);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Name = "Form1";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnEditar;
        private Label ID;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label1;
        private ListBox lstProdutos;
        private PictureBox pictureBox1;
    }
}