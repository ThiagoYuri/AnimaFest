using AnimaFest.DAL;
using AnimaFest.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimaFest.Forms.Gerenciador
{
    public partial class FormGerenciador : FormDefault
    {
        public FormGerenciador()
        {
            InitializeComponent();
        }


        public void UpdateDataGrid<TEntity>(Func<TEntity,bool> ?Seach) where TEntity : class
        {
            ContextDb context = new ContextDb();
            List<TEntity> ListResult = context.Set<TEntity>().ToList();
            if(!(Seach is null))
                ListResult = ListResult.Where(Seach).ToList();
            dataGridView1.DataSource = ListResult; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
