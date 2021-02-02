using Lextm.SharpSnmpLib.Security;
using RugFactory.Db;
using RugFactory.View_Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml;


namespace RugFactory
{
    public partial class Add_Alfombra_Form : Form
    {
        private Cliente currentcliente;
        private List<Alfombra> ownedAlfombrasByCurrentCliente;
        private Int32? currentAlbaranId;
        private DbAccess dbAccess;
        Int32? currentClienteId;
        string currentclienteName;
        int? currentAlfombraId;
        AlfombraView currentViewModel;
        Alfombra currentAlfombra;
        Albaran currentAlbaran;
        public Add_Alfombra_Form()
        {
            dbAccess = new DbAccess();
            InitializeComponent();
        }

        

        private void Add_Alfombra_Form_Load(object sender, EventArgs e)
        {
            textBox_Cliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_Cliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            textBox_Cliente.AutoCompleteCustomSource = dbAccess.GetAllClientesName();
            ///
            radioButton_MR.Checked = true;
            var fallos = dbAccess.GetAllFallos();
            Control[] controls = new Control[fallos.Count];
            CheckBox checkbox;
            for (int i=0; i<fallos.Count; i++)
            {

                checkbox = new CheckBox();
                checkbox.Enabled = true;
                checkbox.AutoSize = true;
                checkbox.Font = new Font(checkbox.Font.FontFamily, 14);
                checkbox.ForeColor = Color.White;
                checkbox.Cursor = Cursors.Hand;
                checkbox.CheckedChanged += Checkbox_CheckedChanged;
                checkbox.Tag = "Fallos";
                checkbox.Name = fallos.ElementAt(i).FalloId.ToString();
                checkbox.Text = fallos.ElementAt(i).Nombre;
                //Set the horizontal location of first and second column of check boxes
                checkbox.Location = i < 8 ? new Point(20,(i * 40) + 140) : new Point(250,((i-8)*40)+140);
           
                controls[i]=checkbox;

            }
            this.Controls.AddRange(controls);
            textBox_Cliente.Focus();
       

        }

        //<Cliente++++++++++++++++++++++++++++++++++++++++++++++>

        private void asigneCurrentCliente()
        {
            MainWindow parentForm = (MainWindow)this.MdiParent;

            currentClienteId = parentForm.CurrentClienteId;
            if (currentClienteId == 0 || currentClienteId == null) { prepareFormCliente(false); return; }
            currentcliente = dbAccess.GetClienteById((Int32)currentClienteId);
            currentclienteName = parentForm.CurrentClienteName;
            prepareFormCliente(true);


        }
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            FormUtilities.MakeRedIFChecked((CheckBox)sender);
        }

        private void textBox_Cliente_Enter(object sender, EventArgs e)
        {
            showToolTip(sender, "Si No Hay Resultado clikea en Buscar mas especifico");
          
        }

        private void showToolTip(object sender,string message)
        {
            TextBox tb = (TextBox)sender;
            ToolTip tt = new ToolTip();
            int visiableTime = 5000;
            tt.Show(message, tb, 100, 100, visiableTime);
        }

        private void textBox_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            currentClienteId = -1;
            buttonResetClienteBox.Visible = false;
            textBox_Cliente.BackColor = Color.Red;
            if (FormUtilities.CheckEnterKeyPressed(e))
            {
                int id = FormUtilities.GetIdFromAutoCompleteToolTip(textBox_Cliente.Text);
                currentClienteId = id;
                if (currentClienteId == -1) {showToolTip(sender, "Si No Hay Resultado clickea en Buscar mas especifico"); return; }
                currentclienteName = FormUtilities.GetNameFromAutoCompleteToolTip(textBox_Cliente.Text);
                currentcliente = dbAccess.GetClienteById((Int32)currentClienteId);
                prepareFormCliente(true);

              
            }

        }
        private void buttonResetClienteBox_Click(object sender, EventArgs e)
        {
            currentcliente = null;
            prepareFormCliente(false);

        }
        private void button_SearchOrAddNewCliente_Click(object sender, EventArgs e)
        {
            MainWindow mainform = (MainWindow)this.MdiParent;
            mainform.ShowClienteWindow();
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++>
        //Albaran :
        private void makeNewAlbaran(Albaran albaran)
        {
            dbAccess.AddAlbaran(albaran);
        }
        private void textBox_Albaran_KeyDown(object sender, KeyEventArgs e)
        {

            if (FormUtilities.CheckEnterKeyPressed(e) && textBox_Albaran.Text.Length > 3)
            {
                string numeroDeAlbaran = textBox_Albaran.Text.Trim().ToUpper();
                Albaran albaran = dbAccess.GetAlbaranByNumeroInterno(numeroDeAlbaran);
                if (albaran == null)

                {
                    if (MessageBox.Show("Este albaran no Existe,Desea Añadirlo", "Atencion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AddAlbaran addAlbaranForm = new AddAlbaran(currentcliente, numeroDeAlbaran);
                        addAlbaranForm.MdiParent = this.MdiParent;
                        addAlbaranForm.Show();

                    }
                    return;
                }
                currentAlbaran = albaran;
                currentAlbaranId = albaran.Albaran_Id;
                List<Alfombra> alfombrasDeAlbaran = dbAccess.GetThisAlbaranAlfombras((Int32)currentAlbaranId);
                publishAlfombrasToDataGridView(dataGridView_EsteAlbaran, alfombrasDeAlbaran);
                prepareFormAlbaran(true);




            }

        }
        private void asigneCurrentAlbaran()
        {
            MainWindow parentForm = (MainWindow)this.MdiParent;
            currentAlbaranId = parentForm.CurrentAlbaranId;
            if (currentAlbaranId == 0 || currentAlbaranId == null) { prepareFormAlbaran(false); return; }
            currentAlbaran = parentForm.CurrentAlbaran;
            prepareFormAlbaran(true);
        }
        //****************************************************
        //Alfombras :





        //****************



        private void Add_Alfombra_Form_Enter(object sender, EventArgs e)
        {
            asigneCurrentCliente();
            asigneCurrentAlbaran();
        }
       
       

        private void radioButton_TR_CheckedChanged(object sender, EventArgs e)
        {
            FormUtilities.BoldME((Control)sender,(radioButton_TR.Checked));
          
        }

        private void radioButtonMR_CheckedChanged(object sender, EventArgs e)
        {
            FormUtilities.BoldME((Control)sender, (radioButton_MR.Checked));
        }


        //DataGrids :
        private void publishAlfombrasToDataGridView(DataGridView dataGridView, List<Alfombra> alfombras)
        {

            dataGridView.DataSource = (from alfombra in alfombras
                                       select new
                                       {
                                           ID = alfombra.Alfombra_Id,
                                           size = string.Format("{0} X {1}", alfombra.Ancho, alfombra.Largo),
                                           alfombra.Calidad

                                       }).ToList();
            
            
        }
        private void dataGridView_EsteCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_EsteCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //*******************
        //local Methods++++++++++++++++++++++++++++++++
   
        private void prepareFormCliente(bool haseCurrentCliente)
        {
            switch (haseCurrentCliente)
            {
                case true:
                    textBox_Cliente.Text = currentclienteName;
                    textBox_Cliente.Enabled = false;
                    textBox_Cliente.BackColor = Color.Aqua;
                    textBox_Cliente.Cursor = Cursors.No;
                    buttonResetClienteBox.Visible = true;
                    buttonResetClienteBox.Enabled = true;
                    string showName = currentclienteName.Length > 20 ? currentclienteName.Substring(0, 20) : currentclienteName;
                    label_ActiveCliente.Text = string.Format("{0} : Id : {1}", showName, currentClienteId);
                    textBox_Albaran.Enabled = true;
                    textBox_Albaran.Focus();
                    textBox_Albaran.BackColor = Color.Red;
                    
                    //Get The Alfombras of this Client:
                    ownedAlfombrasByCurrentCliente = getAlfombrasOfCliente();
                    publishAlfombrasToDataGridView(dataGridView_EsteCliente, ownedAlfombrasByCurrentCliente);
                    break
                        ;
                case false:
                    FormUtilities.CleanAllTextBoxes(this);
                    FormUtilities.DisabaleControles(this, textBox_Cliente);

                    button_SearchOrAddNewCliente.Enabled = true;
                    buttonResetClienteBox.Visible = false;
                    textBox_Cliente.BackColor = Color.Red;
                    textBox_Cliente.Focus();
                    textBox_Cliente.Cursor = Cursors.Default;
                    break
                        ;
                default:
                    break;
            }
        }   
        private void prepareFormAlbaran(bool hasAlbaran)
        {
            tuggleEnableFallosCheckBoxes(hasAlbaran);
            tuggleEnableAlfombraDetailInput(hasAlbaran);
            radioButton_MR.Enabled = hasAlbaran;
            radioButton_TR.Enabled = hasAlbaran;
            textBox_Albaran.Enabled = !hasAlbaran;
            switch (hasAlbaran)
            {
                case true:
                   
                    textBox_Albaran.BackColor = Color.Aqua;
                    textBox_Albaran.Cursor = Cursors.No;
                    button_AddAlfombra.Enabled = true;
                    dataGridView_EsteCliente.Enabled = true;
                    break;
                case false:

                    textBox_Albaran.BackColor =default;
                    textBox_Albaran.Cursor = default;
                    dataGridView_EsteCliente.Enabled = false;

                    break;

                default:
                    break;
            }
        }
        private void tuggleEnableAlfombraDetailInput(bool value)
        {
            textBox_Ancho.Enabled = value;
            textBox_Largo.Enabled = value;
            textBox_Calidad.Enabled = value;
        }
        private void tuggleEnableFallosCheckBoxes(bool value)
        {
            var checkBoxes = FormUtilities.GetChecBoxes(this, "Fallos");
            foreach (var item in checkBoxes)
            {
                item.Enabled = value;
            }
        }
        private List<CheckBox> getFallosCheckBoxes()
        {
            List<CheckBox> checkBoxes = FormUtilities.GetChecBoxes(this, "Fallos");
            
            return checkBoxes;
        }
        private List<Alfombra> getAlfombrasOfCliente()
        {
           return dbAccess.GetThisClienteAlfombras(currentcliente);
        }
        private void button_AddAlfombra_Click(object sender, EventArgs e)
        {
            string ActionToTake = button_AddAlfombra.Text;
            Alfombra targetAlfombra = getAlfombraModelFromInputs();
            switch (ActionToTake)
            {
                case "Agregar":
                    {
                      

                        currentAlfombraId = dbAccess.AddAlfombra(targetAlfombra);
                       
                        break;
                    }
                case "Actualizar":
                    {
                        dbAccess.Updatealfombra(targetAlfombra);

                        break;
                    }
                default:
                    break;
            }

            var alfombrasofCliente = dbAccess.GetThisClienteAlfombras(currentcliente);
            publishAlfombrasToDataGridView(dataGridView_EsteCliente, alfombrasofCliente);
        }
        private Alfombra getAlfombraModelFromInputs()
        {
            Alfombra alfombra = new Alfombra() {
                Alfombra_Id =(int) currentAlfombraId,
                Ancho = short.Parse(textBox_Ancho.Text.Trim()),
                Largo = short.Parse(textBox_Largo.Text.Trim()),
                Calidad = textBox_Calidad.Text.Trim(),
                 

            };

            var fallos  = getFallosFromInput();
            alfombra.FalloAlfombras = fallos;
            alfombra.ClienteCliente_Id =(Int32) currentClienteId;
            var prefix = getPrefix();
            alfombra.Prefix_Albaran = prefix;
         
            
            
            return alfombra;
        }
        private string getPrefix()
        {
            string value = radioButton_TR.Checked ? "TR" : radioButton_MR.Checked ? "MR" : string.Empty;
            return value;
        }
        private ICollection<FalloAlfombra> getFallosFromInput()
        {
            ICollection<FalloAlfombra> fallos;
           
            List<CheckBox> checkBoxes = getFallosCheckBoxes();
            List<Int32> ids = FormUtilities.GetChecedBoxesId(checkBoxes);
           
            fallos = dbAccess.GetFallosByIds(ids.ToArray());
            return fallos;
        }
       
        
        
        
        
        
        
        //KeyPress :
        private void textBox_Ancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtilities.AllowOnlyDigit(e);
        }

        private void textBox_Largo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtilities.AllowOnlyDigit(e);
        }

        private void textBox_Calidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtilities.AllowOnlyString(e);
        }
        private void textBox_Albaran_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtilities.AllowOnlyDigit(e);
        }

       
        //unordered added func:
        private void dataGridView_EsteCliente_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewClicked((DataGridView)sender, button_AddToAlbaran, buttonAddToImprimir);
            publishSelectedAlfombraToEdit();
        }
        private void publishSelectedAlfombraToEdit()
        {
            if (currentAlfombra == null) return;
            textBox_Largo.Text = currentAlfombra.Largo.ToString();
            textBox_Ancho.Text = currentAlfombra.Ancho.ToString();
            textBox_Calidad.Text = currentAlfombra.Calidad;
            radioButton_TR.Checked = currentAlfombra.Prefix_Albaran == "TR";
            radioButton_MR.Checked = currentAlfombra.Prefix_Albaran == "MR";

            var fallos = dbAccess.GetThisAlfombraFallos(currentAlfombra).Select(c => c.FalloId);
           

            List<CheckBox> checkBoxes = getFallosCheckBoxes();
            foreach (var item in checkBoxes)
            {
                item.Checked= fallos.Contains(Int32.Parse(item.Name)) ;
            }
            button_AddAlfombra.Text = "Actualizar";
          
           

        }
        
        private void dataGridViewClicked (DataGridView gridview, Button toEnable, Button toDisable)
        {
            asigneCurrecntAlfombraViewModel(gridview);

            bool enabaleButton = currentViewModel.DataGridViewOwner.Equals(gridview.Name);
            toEnable.Enabled = enabaleButton;
            toEnable.BackColor = Color.Aqua;
            toDisable.Enabled = !enabaleButton;
            toDisable.BackColor = default;
        }
        private void asigneCurrecntAlfombraViewModel(DataGridView gridView)
        {
            AlfombraView targetView = GetView_OfClickedAlfombra(gridView);
            currentViewModel = targetView;
            Alfombra alfombra = dbAccess.GetAlfombraById(targetView.Id);
            currentAlfombra = alfombra;
            currentAlfombraId = targetView.Id;
        }
       private void button_AddToAlbaran_Click(object sender, EventArgs e)
        {
            List<Alfombra> allredyAddedAlf = dbAccess.GetThisAlbaranAlfombras(currentAlbaran);
            if (allredyAddedAlf.FirstOrDefault(c=> c.Alfombra_Id.Equals(currentAlfombra.Alfombra_Id))!= null ){ return; }
            try
            {
                dbAccess.AddAlfombraToAlbaran(currentAlbaran, currentAlfombra);
                List<Alfombra> alfombras = dbAccess.GetThisAlbaranAlfombras(currentAlbaran);
                publishAlfombrasToDataGridView(dataGridView_EsteAlbaran, alfombras);
            }
            catch (Exception)
            {

                throw;
            }
            dataGridView_EsteAlbaran.Enabled = true;

        }
        private Alfombra getAlfombraById( Int32 id)
        {
           return dbAccess.GetAlfombraById(id);

        }
        private Int32 getIdOfClickedAlfombraInGridView(DataGridView gridView)
        {
           
              return   Int32.Parse(gridView.CurrentRow.Cells[0].Value.ToString());
           

        }
        private AlfombraView GetView_OfClickedAlfombra(DataGridView gridView)
        {
            DataGridViewRow row = gridView.CurrentRow;
            int id = Int32.Parse(row.Cells[0].Value.ToString());
            string size = row.Cells[1].Value.ToString();
            string calidad = row.Cells[2].Value.ToString();
            AlfombraView viewModel = new AlfombraView(id,size,calidad,gridView.Name);
            return viewModel;
        }

        private void dataGridView_EsteAlbaran_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_EsteAlbaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataGridView_EsteAlbaran.Rows.Count > 0) dataGridView_EsteAlbaran.Enabled = true;
        }

        private void dataGridView_EsteAlbaran_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridViewClicked((DataGridView)sender, buttonAddToImprimir, button_AddToAlbaran);
        }

        private void buttonAddAllToAlbaran_Click(object sender, EventArgs e)
        {
            if (!(dataGridView_EsteAlbaran.Enabled) ||  dataGridView_EsteCliente.Rows.Count ==0) { return; }
            List<Alfombra> alfombras = dbAccess.GetThisClienteAlfombras(currentcliente);
            dbAccess.AddAlfombraToAlbaran(currentAlbaran, alfombras);
            publishAlfombrasToDataGridView(dataGridView_EsteAlbaran, alfombras);

        }

       

        private void dataGridView_EsteAlbaran_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            buttonRemoveFromAlbaran.Enabled = true;
            buttonRemoveFromAlbaran.BackColor = Color.Aqua;
        }

        private void dataGridView_EsteAlbaran_Leave(object sender, EventArgs e)
        {
            //buttonRemoveFromAlbaran.Enabled = false;
            buttonAddToImprimir.Enabled = false;
            buttonAddToImprimir.BackColor = default;
            buttonRemoveFromAlbaran.BackColor = default;
        }

        private void buttonRemoveFromAlbaran_Click(object sender, EventArgs e)
        {
            if (!dataGridView_EsteAlbaran.Enabled || currentAlfombra == null) return;
            dbAccess.RemoveAlfombraFromAlbaran(currentAlbaran, currentAlfombra);
            publishAlfombrasToDataGridView(dataGridView_EsteAlbaran, dbAccess.GetThisAlbaranAlfombras(currentAlbaran));
            publishAlfombrasToDataGridView(dataGridView_EsteCliente, dbAccess.GetThisClienteAlfombras(currentcliente));
        }



        //**********************


    }
}


