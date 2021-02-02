namespace RugFactory
{
    partial class Clientes_Window
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textbox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_SubmitChange = new System.Windows.Forms.Button();
            this.phoneNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGrid_Clientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Mobil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Telefono = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_ShowAll = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_Search
            // 
            this.textbox_Search.Location = new System.Drawing.Point(139, 33);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.Size = new System.Drawing.Size(270, 22);
            this.textbox_Search.TabIndex = 0;
            this.textbox_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_Search_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda";
            // 
            // button_SubmitChange
            // 
            this.button_SubmitChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitChange.Location = new System.Drawing.Point(958, 643);
            this.button_SubmitChange.Name = "button_SubmitChange";
            this.button_SubmitChange.Size = new System.Drawing.Size(102, 33);
            this.button_SubmitChange.TabIndex = 14;
            this.button_SubmitChange.Text = "Agregar";
            this.button_SubmitChange.UseVisualStyleBackColor = true;
            this.button_SubmitChange.Click += new System.EventHandler(this.button_SubmitChange_Click);
            // 
            // dataGrid_Clientes
            // 
            this.dataGrid_Clientes.AllowUserToAddRows = false;
            this.dataGrid_Clientes.AllowUserToDeleteRows = false;
            this.dataGrid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Clientes.Location = new System.Drawing.Point(48, 96);
            this.dataGrid_Clientes.Name = "dataGrid_Clientes";
            this.dataGrid_Clientes.ReadOnly = true;
            this.dataGrid_Clientes.RowHeadersWidth = 51;
            this.dataGrid_Clientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGrid_Clientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid_Clientes.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.dataGrid_Clientes.RowTemplate.Height = 24;
            this.dataGrid_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Clientes.Size = new System.Drawing.Size(1009, 541);
            this.dataGrid_Clientes.StandardTab = true;
            this.dataGrid_Clientes.TabIndex = 9;
            this.dataGrid_Clientes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGrid_Clientes_DataBindingComplete);
            this.dataGrid_Clientes.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Clientes_RowValidated);
            this.dataGrid_Clientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGrid_Clientes_KeyDown);
            this.dataGrid_Clientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Clientes_MouseClick);
            this.dataGrid_Clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Clientes_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre y apellido";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(242, 645);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(197, 27);
            this.textBox_Nombre.TabIndex = 10;
            this.textBox_Nombre.Validated += new System.EventHandler(this.textBox_Nombre_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 645);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mobil";
            // 
            // textBox_Mobil
            // 
            this.textBox_Mobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mobil.Location = new System.Drawing.Point(524, 645);
            this.textBox_Mobil.Name = "textBox_Mobil";
            this.textBox_Mobil.Size = new System.Drawing.Size(169, 27);
            this.textBox_Mobil.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fijo";
            // 
            // textBox_Telefono
            // 
            this.textBox_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Telefono.Location = new System.Drawing.Point(765, 645);
            this.textBox_Telefono.Name = "textBox_Telefono";
            this.textBox_Telefono.Size = new System.Drawing.Size(169, 27);
            this.textBox_Telefono.TabIndex = 13;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Address.Location = new System.Drawing.Point(242, 687);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(197, 135);
            this.textBox_Address.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(524, 687);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(169, 27);
            this.textBox_Email.TabIndex = 14;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(958, 691);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(102, 33);
            this.button_Cancel.TabIndex = 15;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_ShowAll
            // 
            this.button_ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowAll.Location = new System.Drawing.Point(578, 26);
            this.button_ShowAll.Name = "button_ShowAll";
            this.button_ShowAll.Size = new System.Drawing.Size(212, 34);
            this.button_ShowAll.TabIndex = 2;
            this.button_ShowAll.Text = "Demostrar Todo";
            this.button_ShowAll.UseVisualStyleBackColor = true;
            this.button_ShowAll.Click += new System.EventHandler(this.button_ShowAll_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(RugFactory.Db.Cliente);
            // 
            // button_Eliminar
            // 
            this.button_Eliminar.Enabled = false;
            this.button_Eliminar.Location = new System.Drawing.Point(831, 691);
            this.button_Eliminar.Name = "button_Eliminar";
            this.button_Eliminar.Size = new System.Drawing.Size(103, 33);
            this.button_Eliminar.TabIndex = 16;
            this.button_Eliminar.Text = "Eliminar";
            this.button_Eliminar.UseVisualStyleBackColor = true;
            this.button_Eliminar.Click += new System.EventHandler(this.button_Eliminar_Click);
            // 
            // Clientes_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 818);
            this.Controls.Add(this.button_Eliminar);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Mobil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGrid_Clientes);
            this.Controls.Add(this.button_SubmitChange);
            this.Controls.Add(this.button_ShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_Search);
            this.Name = "Clientes_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientesWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_SubmitChange;
        private System.Windows.Forms.BindingSource phoneNumberBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGrid_Clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Mobil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Telefono;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_ShowAll;
        private System.Windows.Forms.Button button_Eliminar;
    }
}