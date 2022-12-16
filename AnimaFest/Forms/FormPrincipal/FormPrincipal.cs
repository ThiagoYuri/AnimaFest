using AnimaFest.Forms.GerenciadorAlocacoes;
using AnimaFest.Forms.GerenciadorProduto;

namespace AnimaFest.Forms
{
    public partial class FormPrincipal : FormDefault
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnOpenFormsAlocacoes_Click(object sender, EventArgs e)
        {
            FormGerenciadorAlocacoes formOn = new FormGerenciadorAlocacoes();
            formOn.ShowDialog();
        }

        private void btnOpenFormProduto_Click(object sender, EventArgs e)
        {
            FormGerenciadorProduto formOn = new FormGerenciadorProduto();
            formOn.ShowDialog();
        }
    }
}
