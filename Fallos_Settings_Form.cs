using RugFactory.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugFactory
{
    public partial class Fallos_Settings_Form : Form
    {
        DbAccess dbAccess;
        private Int32? currentFalloId;
        public Fallos_Settings_Form()
        {
            InitializeComponent();
            dbAccess = new DbAccess();
           
        }

        private void Fallos_Settings_Form_Load(object sender, EventArgs e)
        {
            loadDataToFallosGridView();
        }
        private void loadDataToFallosGridView()
        {
            dataGridView_Fallos.DataSource = dbAccess.GetAllFallos();
        }
        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                FalloAlfombra fallo = getFalloObjextFromUserInputs();
                switch (button_Submit.Text)
                {
                    case "Actualizar":
                        fallo.FalloId =(int)currentFalloId;
                        dbAccess.UpdateFallo(fallo);
                        break;
                    case "Agregar":
                        dbAccess.AddFallo(fallo);
                        break;
                    
                }

                cleanErrosMessages();
                cleanTextBoxes();
                currentFalloId = null;
                loadDataToFallosGridView();
                textBox_FalloName.CausesValidation = false;
                
            }
        }

        private FalloAlfombra getFalloObjextFromUserInputs()
        {
            FalloAlfombra fallo = new FalloAlfombra();
            string fallo_Nombre = textBox_FalloName.Text.Trim();
            string fallo_Description = textBox_Description.Text.Trim();
            fallo.Nombre = fallo_Nombre;
            fallo.Descripcion = fallo_Description;
            return fallo;
        }

        private void dataGridView_Fallos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView_Fallos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       
        private void PopulateFalloToTexBoxes(FalloAlfombra falloToPublish)
        {
            textBox_FalloName.Text = falloToPublish.Nombre.ToString();
            textBox_Description.Text = falloToPublish.Descripcion.ToString();
            currentFalloId = falloToPublish.FalloId;

        }
        private void  cleanTextBoxes()
        {
            FormUtilities.CleanAllTextBoxes(this);
        }

        private void textBox_FalloName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_FalloName.Text))
            {
                e.Cancel = true;
                errorProviderFallo.SetError(textBox_FalloName, "Porfavor, Indique el Nombre de Fallo");
            }
            else
            {
                errorProviderFallo.SetError(textBox_FalloName, null);
            }
        }
        private void cleanErrosMessages()
        {
            FormUtilities.CleanErrorProviderMessage(errorProviderFallo, this);
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            cleanTextBoxes();
            cleanErrosMessages();
            currentFalloId = null;
            button_Submit.Text = "Agregar";
          
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (currentFalloId != null)
            {
                dbAccess.RemoveFallo(dbAccess.GetFalloById((int)currentFalloId));
                loadDataToFallosGridView();
            }
        }

        private void dataGridView_Fallos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            publishToEditBoxes();
        }
        private void publishToEditBoxes()
        {
            if (dataGridView_Fallos.Rows.Count.Equals(0)) return;
            if (dataGridView_Fallos.CurrentRow == null) return;
            int falloId = (int)dataGridView_Fallos.CurrentRow.Cells[0].Value;
            FalloAlfombra CurrentFallo = new FalloAlfombra();
            CurrentFallo.FalloId = falloId;
            CurrentFallo.Nombre = dataGridView_Fallos.CurrentRow.Cells[1].Value.ToString();
            CurrentFallo.Descripcion = dataGridView_Fallos.CurrentRow.Cells[2].Value.ToString();
            PopulateFalloToTexBoxes(CurrentFallo);
            FormUtilities.TuggleButtonText(button_Submit, "Actualizar");
        }
    }
}
