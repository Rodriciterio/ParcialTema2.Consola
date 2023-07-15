namespace ParcialTema2.Windows
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
            label1 = new Label();
            label2 = new Label();
            txtAltura = new TextBox();
            txtBase = new TextBox();
            dgvDatos = new DataGridView();
            colAltura = new DataGridViewTextBoxColumn();
            colBase = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colArista = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            btnCalcular = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el lado de la base: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 27);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(206, 27);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(206, 65);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 3;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colAltura, colBase, colArea, colArista, colVolumen });
            dgvDatos.Dock = DockStyle.Bottom;
            dgvDatos.Location = new Point(0, 231);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 219);
            dgvDatos.TabIndex = 4;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            // 
            // colBase
            // 
            colBase.HeaderText = "Lado Base";
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            // 
            // colArista
            // 
            colArista.HeaderText = "Arista";
            colArista.Name = "colArista";
            colArista.ReadOnly = true;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 132);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 132);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(456, 48);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
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
            Controls.Add(btnSalir);
            Controls.Add(btnCancelar);
            Controls.Add(btnCalcular);
            Controls.Add(dgvDatos);
            Controls.Add(txtBase);
            Controls.Add(txtAltura);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAltura;
        private TextBox txtBase;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colArista;
        private DataGridViewTextBoxColumn colVolumen;
        private Button btnCalcular;
        private Button btnCancelar;
        private Button btnSalir;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}