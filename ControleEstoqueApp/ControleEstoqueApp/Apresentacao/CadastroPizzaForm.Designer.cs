using System;
using System.Windows.Forms;
using Aplicacao.ControleEstoqueApp.Servicos;
using ControleEstoqueApp.Infraestrutura.Repositorios;

namespace ControleEstoqueApp.Apresentacao
{
    public partial class CadastroPizzaForm : Form
    {
        private readonly PizzaService _pizzaService;

        public CadastroPizzaForm()
        {
            InitializeComponent();
            _pizzaService = new PizzaService(new PizzaRepositorio());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                decimal preco = decimal.Parse(txtPreco.Text);

                _pizzaService.CadastrarPizza(nome, preco);
                MessageBox.Show("Pizza cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    partial class CadastroPizzaForm
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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


        private void InitializeComponent()
        {
            txtPreco = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(416, 114);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(310, 114);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // CadastroPizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(txtPreco);
            Name = "CadastroPizzaForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPreco;
        private TextBox txtNome;
    }
}