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
    public partial class AddAlbaran : Form
    {
        DbAccess dbAccess;
        Cliente owner;
        string albaranNumber;
        Int32 albranId;
        Albaran currentAlbararan;
        public AddAlbaran(Cliente _owner,string _albaranNumber)
        {
            owner = _owner;
            albaranNumber = _albaranNumber;
            InitializeComponent();
            dbAccess = new DbAccess();

        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker_Entrada.Value.Date;


            Albaran albaran = new Albaran()
            {
                Numero_Albaran = textBox_Numero.Text,
                Recogido_Por = textBox_RecogidaPor.Text.Trim().ToUpper(),
                Fecha_Entrada = dateTimePicker_Entrada.Value.Date,
                fecha_Estimada = dateTimePicker_Salida.Value.Date,
                Fecha_BaseDatos = DateTime.Today,
                ClienteCliente_Id = owner.Cliente_Id,
                Is_Active = true,
                NumeroDeAviso = textBox_NumeroAviso.Text.Trim()


            };

            dbAccess.AddAlbaran(albaran);
            currentAlbararan = albaran;
            albaranNumber = albaran.Numero_Albaran;
            takeMeToMainWindow();
            
        }
        private void takeMeToMainWindow()
        {
            MainWindow parent = (MainWindow)this.ParentForm;
            parent.CurrentClienteId = owner.Cliente_Id;
            parent.CurrentClienteName = owner.Nombre_Apellidos;
            parent.CurrentAlbaranInterno = albaranNumber;
            parent.CurrentAlbaran = currentAlbararan;
            Add_Alfombra_Form addAlfombraForm = parent.MdiChildren.FirstOrDefault(c => c.Name == "Add_Alfombra_Form") as Add_Alfombra_Form;
            addAlfombraForm.Focus();
           

            this.Close();
           
        }
        private void AddAlbaran_Load(object sender, EventArgs e)
        {
            textBox_Numero.Text = albaranNumber;
            textBox_Numero.Enabled = false;
            textBox_NumeroAviso.Focus();
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
