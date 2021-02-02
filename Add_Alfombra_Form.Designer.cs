namespace RugFactory
{
    partial class Add_Alfombra_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Albaran = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ancho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Largo = new System.Windows.Forms.TextBox();
            this.labelClienteNombre = new System.Windows.Forms.Label();
            this.button_SearchOrAddNewCliente = new System.Windows.Forms.Button();
            this.radioButton_TR = new System.Windows.Forms.RadioButton();
            this.radioButton_MR = new System.Windows.Forms.RadioButton();
            this.textBox_AlbaranApendix = new System.Windows.Forms.TextBox();
            this.textBox_Calidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider_AddAlfombra = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView_EsteCliente = new System.Windows.Forms.DataGridView();
            this.dataGridView_EsteAlbaran = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_AImprimir = new System.Windows.Forms.DataGridView();
            this.buttonResetClienteBox = new System.Windows.Forms.Button();
            this.label_ActiveCliente = new System.Windows.Forms.Label();
            this.button_AddAlfombra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_AddToAlbaran = new System.Windows.Forms.Button();
            this.buttonAddToImprimir = new System.Windows.Forms.Button();
            this.buttonAddAllToAlbaran = new System.Windows.Forms.Button();
            this.buttonAddImprimirTodo = new System.Windows.Forms.Button();
            this.buttonRemoveFromAlbaran = new System.Windows.Forms.Button();
            this.buttonRemoveFromImprimir = new System.Windows.Forms.Button();
            this.falloAlfombraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_AddAlfombra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EsteCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EsteAlbaran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloAlfombraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia Cliente";
            // 
            // textBox_Cliente
            // 
            this.textBox_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Cliente.ForeColor = System.Drawing.Color.White;
            this.textBox_Cliente.Location = new System.Drawing.Point(243, 27);
            this.textBox_Cliente.Name = "textBox_Cliente";
            this.textBox_Cliente.Size = new System.Drawing.Size(233, 34);
            this.textBox_Cliente.TabIndex = 1;
            this.textBox_Cliente.Enter += new System.EventHandler(this.textBox_Cliente_Enter);
            this.textBox_Cliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Cliente_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero de Albaran";
            // 
            // textBox_Albaran
            // 
            this.textBox_Albaran.Enabled = false;
            this.textBox_Albaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Albaran.Location = new System.Drawing.Point(243, 79);
            this.textBox_Albaran.MaxLength = 10;
            this.textBox_Albaran.Name = "textBox_Albaran";
            this.textBox_Albaran.Size = new System.Drawing.Size(159, 34);
            this.textBox_Albaran.TabIndex = 1;
            this.textBox_Albaran.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Albaran_KeyDown);
            this.textBox_Albaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Albaran_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(699, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ancho";
            // 
            // textBox_Ancho
            // 
            this.textBox_Ancho.Enabled = false;
            this.textBox_Ancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ancho.Location = new System.Drawing.Point(872, 27);
            this.textBox_Ancho.MaxLength = 3;
            this.textBox_Ancho.Name = "textBox_Ancho";
            this.textBox_Ancho.Size = new System.Drawing.Size(103, 34);
            this.textBox_Ancho.TabIndex = 1;
            this.textBox_Ancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ancho_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1015, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Largo";
            // 
            // textBox_Largo
            // 
            this.textBox_Largo.Enabled = false;
            this.textBox_Largo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Largo.Location = new System.Drawing.Point(1124, 25);
            this.textBox_Largo.MaxLength = 3;
            this.textBox_Largo.Name = "textBox_Largo";
            this.textBox_Largo.Size = new System.Drawing.Size(103, 34);
            this.textBox_Largo.TabIndex = 2;
            this.textBox_Largo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Largo_KeyPress);
            // 
            // labelClienteNombre
            // 
            this.labelClienteNombre.AutoSize = true;
            this.labelClienteNombre.Location = new System.Drawing.Point(12, 89);
            this.labelClienteNombre.Name = "labelClienteNombre";
            this.labelClienteNombre.Size = new System.Drawing.Size(0, 17);
            this.labelClienteNombre.TabIndex = 2;
            // 
            // button_SearchOrAddNewCliente
            // 
            this.button_SearchOrAddNewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchOrAddNewCliente.Location = new System.Drawing.Point(522, 30);
            this.button_SearchOrAddNewCliente.Name = "button_SearchOrAddNewCliente";
            this.button_SearchOrAddNewCliente.Size = new System.Drawing.Size(154, 31);
            this.button_SearchOrAddNewCliente.TabIndex = 3;
            this.button_SearchOrAddNewCliente.Text = "&Buscar Cliente";
            this.button_SearchOrAddNewCliente.UseVisualStyleBackColor = true;
            this.button_SearchOrAddNewCliente.Click += new System.EventHandler(this.button_SearchOrAddNewCliente_Click);
            // 
            // radioButton_TR
            // 
            this.radioButton_TR.AutoSize = true;
            this.radioButton_TR.Enabled = false;
            this.radioButton_TR.ForeColor = System.Drawing.Color.White;
            this.radioButton_TR.Location = new System.Drawing.Point(628, 87);
            this.radioButton_TR.Name = "radioButton_TR";
            this.radioButton_TR.Size = new System.Drawing.Size(48, 21);
            this.radioButton_TR.TabIndex = 6;
            this.radioButton_TR.TabStop = true;
            this.radioButton_TR.Text = "TR";
            this.radioButton_TR.UseVisualStyleBackColor = true;
            this.radioButton_TR.CheckedChanged += new System.EventHandler(this.radioButton_TR_CheckedChanged);
            // 
            // radioButton_MR
            // 
            this.radioButton_MR.AutoSize = true;
            this.radioButton_MR.Enabled = false;
            this.radioButton_MR.ForeColor = System.Drawing.Color.White;
            this.radioButton_MR.Location = new System.Drawing.Point(526, 87);
            this.radioButton_MR.Name = "radioButton_MR";
            this.radioButton_MR.Size = new System.Drawing.Size(50, 21);
            this.radioButton_MR.TabIndex = 7;
            this.radioButton_MR.TabStop = true;
            this.radioButton_MR.Text = "MR";
            this.radioButton_MR.UseVisualStyleBackColor = true;
            this.radioButton_MR.CheckedChanged += new System.EventHandler(this.radioButtonMR_CheckedChanged);
            // 
            // textBox_AlbaranApendix
            // 
            this.textBox_AlbaranApendix.Enabled = false;
            this.textBox_AlbaranApendix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AlbaranApendix.Location = new System.Drawing.Point(421, 79);
            this.textBox_AlbaranApendix.MaxLength = 2;
            this.textBox_AlbaranApendix.Name = "textBox_AlbaranApendix";
            this.textBox_AlbaranApendix.Size = new System.Drawing.Size(55, 34);
            this.textBox_AlbaranApendix.TabIndex = 1;
            // 
            // textBox_Calidad
            // 
            this.textBox_Calidad.Enabled = false;
            this.textBox_Calidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Calidad.Location = new System.Drawing.Point(872, 72);
            this.textBox_Calidad.MaxLength = 25;
            this.textBox_Calidad.Name = "textBox_Calidad";
            this.textBox_Calidad.Size = new System.Drawing.Size(103, 34);
            this.textBox_Calidad.TabIndex = 3;
            this.textBox_Calidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Calidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(699, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Calidad";
            // 
            // errorProvider_AddAlfombra
            // 
            this.errorProvider_AddAlfombra.ContainerControl = this;
            // 
            // dataGridView_EsteCliente
            // 
            this.dataGridView_EsteCliente.AllowUserToAddRows = false;
            this.dataGridView_EsteCliente.AllowUserToDeleteRows = false;
            this.dataGridView_EsteCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EsteCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_EsteCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EsteCliente.Location = new System.Drawing.Point(679, 202);
            this.dataGridView_EsteCliente.MultiSelect = false;
            this.dataGridView_EsteCliente.Name = "dataGridView_EsteCliente";
            this.dataGridView_EsteCliente.ReadOnly = true;
            this.dataGridView_EsteCliente.RowHeadersWidth = 51;
            this.dataGridView_EsteCliente.RowTemplate.Height = 24;
            this.dataGridView_EsteCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EsteCliente.Size = new System.Drawing.Size(347, 632);
            this.dataGridView_EsteCliente.TabIndex = 8;
            this.dataGridView_EsteCliente.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_EsteCliente_DataBindingComplete);
            this.dataGridView_EsteCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_EsteCliente_MouseClick);
            // 
            // dataGridView_EsteAlbaran
            // 
            this.dataGridView_EsteAlbaran.AllowUserToAddRows = false;
            this.dataGridView_EsteAlbaran.AllowUserToDeleteRows = false;
            this.dataGridView_EsteAlbaran.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EsteAlbaran.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_EsteAlbaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EsteAlbaran.Location = new System.Drawing.Point(1106, 202);
            this.dataGridView_EsteAlbaran.MultiSelect = false;
            this.dataGridView_EsteAlbaran.Name = "dataGridView_EsteAlbaran";
            this.dataGridView_EsteAlbaran.ReadOnly = true;
            this.dataGridView_EsteAlbaran.RowHeadersWidth = 51;
            this.dataGridView_EsteAlbaran.RowTemplate.Height = 24;
            this.dataGridView_EsteAlbaran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EsteAlbaran.Size = new System.Drawing.Size(326, 632);
            this.dataGridView_EsteAlbaran.TabIndex = 8;
            this.dataGridView_EsteAlbaran.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_EsteAlbaran_DataBindingComplete);
            this.dataGridView_EsteAlbaran.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EsteAlbaran_RowEnter);
            this.dataGridView_EsteAlbaran.Leave += new System.EventHandler(this.dataGridView_EsteAlbaran_Leave);
            this.dataGridView_EsteAlbaran.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_EsteAlbaran_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1112, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Del Alabaran :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(687, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Del :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1506, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "A Imprimir :";
            // 
            // dataGridView_AImprimir
            // 
            this.dataGridView_AImprimir.AllowUserToAddRows = false;
            this.dataGridView_AImprimir.AllowUserToDeleteRows = false;
            this.dataGridView_AImprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AImprimir.Location = new System.Drawing.Point(1519, 202);
            this.dataGridView_AImprimir.Name = "dataGridView_AImprimir";
            this.dataGridView_AImprimir.ReadOnly = true;
            this.dataGridView_AImprimir.RowHeadersWidth = 51;
            this.dataGridView_AImprimir.RowTemplate.Height = 24;
            this.dataGridView_AImprimir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_AImprimir.Size = new System.Drawing.Size(347, 632);
            this.dataGridView_AImprimir.TabIndex = 8;
            // 
            // buttonResetClienteBox
            // 
            this.buttonResetClienteBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetClienteBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetClienteBox.Location = new System.Drawing.Point(482, 36);
            this.buttonResetClienteBox.Name = "buttonResetClienteBox";
            this.buttonResetClienteBox.Size = new System.Drawing.Size(18, 23);
            this.buttonResetClienteBox.TabIndex = 5;
            this.buttonResetClienteBox.Text = "X";
            this.buttonResetClienteBox.UseVisualStyleBackColor = true;
            this.buttonResetClienteBox.Visible = false;
            this.buttonResetClienteBox.Click += new System.EventHandler(this.buttonResetClienteBox_Click);
            // 
            // label_ActiveCliente
            // 
            this.label_ActiveCliente.AutoSize = true;
            this.label_ActiveCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ActiveCliente.ForeColor = System.Drawing.Color.White;
            this.label_ActiveCliente.Location = new System.Drawing.Point(755, 149);
            this.label_ActiveCliente.MaximumSize = new System.Drawing.Size(300, 0);
            this.label_ActiveCliente.Name = "label_ActiveCliente";
            this.label_ActiveCliente.Size = new System.Drawing.Size(0, 29);
            this.label_ActiveCliente.TabIndex = 0;
            // 
            // button_AddAlfombra
            // 
            this.button_AddAlfombra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddAlfombra.Location = new System.Drawing.Point(1288, 25);
            this.button_AddAlfombra.Name = "button_AddAlfombra";
            this.button_AddAlfombra.Size = new System.Drawing.Size(267, 51);
            this.button_AddAlfombra.TabIndex = 4;
            this.button_AddAlfombra.Text = "&Añadir Alfombra";
            this.button_AddAlfombra.UseVisualStyleBackColor = true;
            this.button_AddAlfombra.Click += new System.EventHandler(this.button_AddAlfombra_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_AddToAlbaran
            // 
            this.button_AddToAlbaran.Location = new System.Drawing.Point(1032, 408);
            this.button_AddToAlbaran.Name = "button_AddToAlbaran";
            this.button_AddToAlbaran.Size = new System.Drawing.Size(68, 23);
            this.button_AddToAlbaran.TabIndex = 9;
            this.button_AddToAlbaran.Text = ">";
            this.button_AddToAlbaran.UseVisualStyleBackColor = true;
            this.button_AddToAlbaran.Click += new System.EventHandler(this.button_AddToAlbaran_Click);
            // 
            // buttonAddToImprimir
            // 
            this.buttonAddToImprimir.Location = new System.Drawing.Point(1445, 408);
            this.buttonAddToImprimir.Name = "buttonAddToImprimir";
            this.buttonAddToImprimir.Size = new System.Drawing.Size(68, 23);
            this.buttonAddToImprimir.TabIndex = 9;
            this.buttonAddToImprimir.Text = ">";
            this.buttonAddToImprimir.UseVisualStyleBackColor = true;
            // 
            // buttonAddAllToAlbaran
            // 
            this.buttonAddAllToAlbaran.Location = new System.Drawing.Point(1032, 437);
            this.buttonAddAllToAlbaran.Name = "buttonAddAllToAlbaran";
            this.buttonAddAllToAlbaran.Size = new System.Drawing.Size(68, 23);
            this.buttonAddAllToAlbaran.TabIndex = 9;
            this.buttonAddAllToAlbaran.Text = "Todo >";
            this.buttonAddAllToAlbaran.UseVisualStyleBackColor = true;
            this.buttonAddAllToAlbaran.Click += new System.EventHandler(this.buttonAddAllToAlbaran_Click);
            // 
            // buttonAddImprimirTodo
            // 
            this.buttonAddImprimirTodo.Location = new System.Drawing.Point(1445, 437);
            this.buttonAddImprimirTodo.Name = "buttonAddImprimirTodo";
            this.buttonAddImprimirTodo.Size = new System.Drawing.Size(68, 23);
            this.buttonAddImprimirTodo.TabIndex = 9;
            this.buttonAddImprimirTodo.Text = "Todo >";
            this.buttonAddImprimirTodo.UseVisualStyleBackColor = true;
            this.buttonAddImprimirTodo.Click += new System.EventHandler(this.button_AddToAlbaran_Click);
            // 
            // buttonRemoveFromAlbaran
            // 
            this.buttonRemoveFromAlbaran.Location = new System.Drawing.Point(1032, 466);
            this.buttonRemoveFromAlbaran.Name = "buttonRemoveFromAlbaran";
            this.buttonRemoveFromAlbaran.Size = new System.Drawing.Size(68, 23);
            this.buttonRemoveFromAlbaran.TabIndex = 9;
            this.buttonRemoveFromAlbaran.Text = "<";
            this.buttonRemoveFromAlbaran.UseVisualStyleBackColor = true;
            this.buttonRemoveFromAlbaran.Click += new System.EventHandler(this.buttonRemoveFromAlbaran_Click);
            // 
            // buttonRemoveFromImprimir
            // 
            this.buttonRemoveFromImprimir.Location = new System.Drawing.Point(1445, 466);
            this.buttonRemoveFromImprimir.Name = "buttonRemoveFromImprimir";
            this.buttonRemoveFromImprimir.Size = new System.Drawing.Size(68, 23);
            this.buttonRemoveFromImprimir.TabIndex = 9;
            this.buttonRemoveFromImprimir.Text = "<";
            this.buttonRemoveFromImprimir.UseVisualStyleBackColor = true;
            this.buttonRemoveFromImprimir.Click += new System.EventHandler(this.button_AddToAlbaran_Click);
            // 
            // falloAlfombraBindingSource
            // 
            this.falloAlfombraBindingSource.DataSource = typeof(RugFactory.Db.FalloAlfombra);
            // 
            // Add_Alfombra_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1870, 771);
            this.Controls.Add(this.buttonAddToImprimir);
            this.Controls.Add(this.buttonAddImprimirTodo);
            this.Controls.Add(this.buttonAddAllToAlbaran);
            this.Controls.Add(this.buttonRemoveFromImprimir);
            this.Controls.Add(this.buttonRemoveFromAlbaran);
            this.Controls.Add(this.button_AddToAlbaran);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_EsteAlbaran);
            this.Controls.Add(this.dataGridView_AImprimir);
            this.Controls.Add(this.dataGridView_EsteCliente);
            this.Controls.Add(this.radioButton_MR);
            this.Controls.Add(this.radioButton_TR);
            this.Controls.Add(this.buttonResetClienteBox);
            this.Controls.Add(this.button_AddAlfombra);
            this.Controls.Add(this.button_SearchOrAddNewCliente);
            this.Controls.Add(this.labelClienteNombre);
            this.Controls.Add(this.textBox_Largo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_AlbaranApendix);
            this.Controls.Add(this.textBox_Albaran);
            this.Controls.Add(this.textBox_Calidad);
            this.Controls.Add(this.textBox_Ancho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_ActiveCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Cliente);
            this.Controls.Add(this.label1);
            this.Name = "Add_Alfombra_Form";
            this.Text = "Add_Alfombra_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Alfombra_Form_Load);
            this.Enter += new System.EventHandler(this.Add_Alfombra_Form_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_AddAlfombra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EsteCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EsteAlbaran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.falloAlfombraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Albaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Ancho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Largo;
        private System.Windows.Forms.Label labelClienteNombre;
        private System.Windows.Forms.Button button_SearchOrAddNewCliente;
        private System.Windows.Forms.RadioButton radioButton_TR;
        private System.Windows.Forms.RadioButton radioButton_MR;
        private System.Windows.Forms.BindingSource falloAlfombraBindingSource;
        private System.Windows.Forms.TextBox textBox_AlbaranApendix;
        private System.Windows.Forms.TextBox textBox_Calidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider_AddAlfombra;
        private System.Windows.Forms.DataGridView dataGridView_EsteAlbaran;
        private System.Windows.Forms.DataGridView dataGridView_EsteCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_AImprimir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonResetClienteBox;
        private System.Windows.Forms.Label label_ActiveCliente;
        private System.Windows.Forms.Button button_AddAlfombra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_AddToAlbaran;
        private System.Windows.Forms.Button buttonAddToImprimir;
        private System.Windows.Forms.Button buttonAddImprimirTodo;
        private System.Windows.Forms.Button buttonAddAllToAlbaran;
        private System.Windows.Forms.Button buttonRemoveFromImprimir;
        private System.Windows.Forms.Button buttonRemoveFromAlbaran;
    }
}