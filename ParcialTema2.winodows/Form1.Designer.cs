namespace ParcialTema2.winodows
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
            components = new System.ComponentModel.Container();
            txtAltura = new TextBox();
            txtBase = new TextBox();
            btnCancelar = new Button();
            btnOk = new Button();
            label2 = new Label();
            label1 = new Label();
            dgvDatos = new DataGridView();
            ColAltura = new DataGridViewTextBoxColumn();
            ColBase = new DataGridViewTextBoxColumn();
            ColArista = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColVolumen = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(242, 57);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 13;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(242, 10);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 12;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(253, 120);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(108, 120);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 13);
            label2.Name = "label2";
            label2.Size = new Size(171, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingrese la base de la piramide  :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 60);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 8;
            label1.Text = "Ingrese la altura de la piramide :";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { ColAltura, ColBase, ColArista, ColArea, ColVolumen });
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(0, 219);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 231);
            dgvDatos.TabIndex = 7;
            // 
            // ColAltura
            // 
            ColAltura.HeaderText = "Altura";
            ColAltura.Name = "ColAltura";
            ColAltura.ReadOnly = true;
            // 
            // ColBase
            // 
            ColBase.HeaderText = "Lado Base";
            ColBase.Name = "ColBase";
            ColBase.ReadOnly = true;
            // 
            // ColArista
            // 
            ColArista.HeaderText = "Arista";
            ColArista.Name = "ColArista";
            ColArista.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.HeaderText = "Area";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            ColVolumen.HeaderText = "Volumen";
            ColVolumen.Name = "ColVolumen";
            ColVolumen.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltura;
        private TextBox txtBase;
        private Button btnCancelar;
        private Button btnOk;
        private Label label2;
        private Label label1;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColBase;
        private DataGridViewTextBoxColumn ColArista;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}