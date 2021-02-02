namespace RugFactory
{
    partial class Fallos_Settings_Form
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_Fallos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FalloName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.errorProviderFallo = new System.Windows.Forms.ErrorProvider(this.components);
            this.falloAlfombraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fallos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloAlfombraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Fallos
            // 
            this.dataGridView_Fallos.AllowUserToAddRows = false;
            this.dataGridView_Fallos.AllowUserToDeleteRows = false;
            this.dataGridView_Fallos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fallos.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Fallos.Name = "dataGridView_Fallos";
            this.dataGridView_Fallos.ReadOnly = true;
            this.dataGridView_Fallos.RowHeadersWidth = 51;
            this.dataGridView_Fallos.RowTemplate.Height = 24;
            this.dataGridView_Fallos.Size = new System.Drawing.Size(788, 450);
            this.dataGridView_Fallos.TabIndex = 0;
            this.dataGridView_Fallos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Fallos_DataBindingComplete);
            this.dataGridView_Fallos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Fallos_RowEnter);
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Fallo";
            // 
            // textBox_FalloName
            // 
            this.textBox_FalloName.Location = new System.Drawing.Point(128, 490);
            this.textBox_FalloName.MaxLength = 20;
            this.textBox_FalloName.Name = "textBox_FalloName";
            this.textBox_FalloName.Size = new System.Drawing.Size(213, 22);
            this.textBox_FalloName.TabIndex = 1;
            this.textBox_FalloName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_FalloName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(128, 549);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(213, 99);
            this.textBox_Description.TabIndex = 2;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(444, 486);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(134, 45);
            this.button_Submit.TabIndex = 3;
            this.button_Submit.Text = "Agregar";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(444, 549);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(134, 45);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(444, 615);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(134, 45);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Eliminar";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // errorProviderFallo
            // 
            this.errorProviderFallo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProviderFallo.ContainerControl = this;
            // 
            // falloAlfombraBindingSource
            // 
            this.falloAlfombraBindingSource.DataSource = typeof(RugFactory.Db.FalloAlfombra);
            // 
            // Fallos_Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 711);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_FalloName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Fallos);
            this.Name = "Fallos_Settings_Form";
            this.Text = "Fallos_Settings_Form";
            this.Load += new System.EventHandler(this.Fallos_Settings_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fallos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloAlfombraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Fallos;
        private System.Windows.Forms.BindingSource falloAlfombraBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FalloName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ErrorProvider errorProviderFallo;
    }
}