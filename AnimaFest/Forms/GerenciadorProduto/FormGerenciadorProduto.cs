using AnimaFest.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimaFest.Forms.GerenciadorProduto
{
    public partial class FormGerenciadorProduto : FormDefault
    {
        public FormGerenciadorProduto()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            ContextDb context = new ContextDb();
            //context.Produto
        }
    }
}
