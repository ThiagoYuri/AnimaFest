namespace AnimaFest.Forms
{
    partial class FormPrincipal
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOpenFormProduto = new System.Windows.Forms.Button();
            this.btnOpenFormsAlocacoes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(68, 251);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(726, 595);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnOpenFormProduto
            // 
            this.btnOpenFormProduto.Location = new System.Drawing.Point(68, 552);
            this.btnOpenFormProduto.Name = "btnOpenFormProduto";
            this.btnOpenFormProduto.Size = new System.Drawing.Size(269, 43);
            this.btnOpenFormProduto.TabIndex = 4;
            this.btnOpenFormProduto.Text = "Gerenciar Produtos";
            this.btnOpenFormProduto.UseVisualStyleBackColor = true;
            this.btnOpenFormProduto.Click += new System.EventHandler(this.btnOpenFormProduto_Click);
            // 
            // btnOpenFormsAlocacoes
            // 
            this.btnOpenFormsAlocacoes.Location = new System.Drawing.Point(68, 490);
            this.btnOpenFormsAlocacoes.Name = "btnOpenFormsAlocacoes";
            this.btnOpenFormsAlocacoes.Size = new System.Drawing.Size(269, 43);
            this.btnOpenFormsAlocacoes.TabIndex = 4;
            this.btnOpenFormsAlocacoes.Text = "Gerenciar Alocacoes";
            this.btnOpenFormsAlocacoes.UseVisualStyleBackColor = true;
            this.btnOpenFormsAlocacoes.Click += new System.EventHandler(this.btnOpenFormsAlocacoes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimaFest.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenFormsAlocacoes);
            this.Controls.Add(this.btnOpenFormProduto);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormPrincipal";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private DataGridView dataGridView1;
        private Button btnOpenFormProduto;
        private Button btnOpenFormsAlocacoes;
        private PictureBox pictureBox1;
    }
}