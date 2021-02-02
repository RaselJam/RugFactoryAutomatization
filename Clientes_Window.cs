using RugFactory.Db;
using System;
using System.Collections;
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
    public partial class Clientes_Window : Form
    {
        private DbAccess dbAccess;
        int? currentclienteId;
        string currentClienteName;
        public Clientes_Window()
        {
            InitializeComponent();
            dbAccess = new DbAccess();
        }

        private void searchThroughDataGridView(object sender, EventArgs e)
        {
            FormUtilities.PrepeareDataGridViewForSearch(dataGrid_Clientes);
            FormUtilities.SearchAGivenDataGridView(dataGrid_Clientes, textbox_Search.Text);
           

        }
       

        private void Clientes_Window_Load(object sender, EventArgs e)
        {
            LoadClienteListDataGrid();
        }

        private void LoadClienteListDataGrid()
        {
          
                dataGrid_Clientes.DataSource = (from cliente in dbAccess.GetClientsList()
                                                select new
                                                {
                                                    cliente.Cliente_Id,
                                                    cliente.Nombre_Apellidos,
                                                    cliente.Movile,
                                                    cliente.Telefono,
                                                    cliente.Email
                                                }).ToList();

                //dataGridView1.DataSource = (from cliente in db.Clientes select new {                                         cliente
                //                           .Cliente_Id, cliente.Nombre_Apellidos, 
                //cliente.Addresses.FirstOrDefault().Full_Address , cliente.Phone_Number.FirstOrDefault().phoneNumber  }).ToList();
            
        }

        private void dataGrid_Clientes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGrid_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_SubmitChange_Click(object sender, EventArgs e)
        {
            string ActionToTake = button_SubmitChange.Text;
            Cliente cliente = GetClienteObjectFromInputs();
            switch (ActionToTake)
            {
                case "Agregar":
                    {
                        addClienteToDB(cliente);
                        break;
                    }
                case "Actualizar":
                    {
                        cliente.Cliente_Id =(int) currentclienteId;
                        updateClienteToDb(cliente);
                        break;
                    }
                default:
                    break;
            }
            
            
            LoadClienteListDataGrid();
            cleanEditTexBoxes();
        }

        private void addClienteToDB(Cliente newcliente)
        {
            dbAccess = new DbAccess();
            dbAccess.Addcliente(newcliente);
        }
        private  void updateClienteToDb(Cliente cliente)
        {
            dbAccess = new DbAccess();
            dbAccess.UpdateCliente(cliente);
        }
        private Cliente GetClienteObjectFromInputs()
        {
            Cliente newCliente = new Cliente();
            string telefono = textBox_Telefono.Text;
            string mobil = textBox_Mobil.Text.Trim();
            string nombre_Apellido = textBox_Nombre.Text.Trim();
            string address = textBox_Address.Text.Trim();
            string email = textBox_Email.Text.Trim();
            newCliente.Nombre_Apellidos = nombre_Apellido;
            newCliente.Address = address;
            newCliente.Movile = mobil;
            newCliente.Telefono = telefono;
            newCliente.Email = email;
           
            return newCliente;
            
        }

        

        

        private void dataGrid_Clientes_MouseClick(object sender, MouseEventArgs e)
        {
            TakeActiveRowToTexBoxes();
            

        }

        private void TakeActiveRowToTexBoxes()
        {
            if (dataGrid_Clientes.Rows.Count.Equals(0)) return;
            int id = (int)dataGrid_Clientes.CurrentRow.Cells[0].Value;
            Cliente clienteToEdit = GetClienteById(id);
            PopulateClienteToTexBoxes(clienteToEdit);
            FormUtilities.TuggleButtonText(button_SubmitChange, "Actualizar");
            button_Eliminar.Enabled = true;
        }

        private void PopulateClienteToTexBoxes(Cliente cliente)
        {
            if (cliente == null) return;
            currentclienteId = cliente.Cliente_Id;

            textBox_Nombre.Text = cliente.Nombre_Apellidos;
            textBox_Address.Text = cliente.Address;
            textBox_Mobil.Text = cliente.Movile;
            textBox_Telefono.Text = cliente.Telefono;
            textBox_Email.Text = cliente.Email;

        }
        private Cliente GetClienteById(int id)
        {
            dbAccess = new DbAccess();
            return dbAccess.GetClienteById(id);
        }
       private void cleanEditTexBoxes()
        {
            FormUtilities.CleanAllTextBoxes(this);
            //textBox_Nombre.Text = String.Empty;
            //textBox_Address.Text = String.Empty;
            //textBox_Mobil.Text = String.Empty;
            //textBox_Telefono.Text = String.Empty;
            //textBox_Email.Text = String.Empty;
            //currentclienteId = null;
            FormUtilities.TuggleButtonText(button_SubmitChange, "Agregar");
            button_Eliminar.Enabled = false;

        }
       

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            currentclienteId = null;
            cleanEditTexBoxes();
            FormUtilities.TuggleButtonText(button_SubmitChange, "Agregar");
            button_Eliminar.Enabled = false;
        }

        private void textBox_Nombre_Validated(object sender, EventArgs e)
        {

        }

        

        private void button_ShowAll_Click(object sender, EventArgs e)
        {
            FormUtilities.ResetDataGridView(dataGrid_Clientes);
        }

        private void dataGrid_Clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AsigneCurrentClienteName();
            AsigneCurrentClienteId();
            TakeMeToMainWindow();

        }
        private void AsigneCurrentClienteName()
        {
            currentClienteName = dataGrid_Clientes.CurrentRow.Cells[1].Value.ToString();
        }
        private void TakeMeToMainWindow()
        {
            MainWindow parent = (MainWindow)this.ParentForm;
            parent.CurrentClienteId = currentclienteId;
            parent.CurrentClienteName = currentClienteName;
            this.Close();
        }
        private void textbox_Search_KeyUp(object sender, KeyEventArgs e)
        {
            searchThroughDataGridView(sender, e);
        }

        private void dataGrid_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if(FormUtilities.CheckEnterKeyPressed(e))
            {
                AsigneCurrentClienteName();
                AsigneCurrentClienteId();
                TakeMeToMainWindow();
            }
        }
        private void AsigneCurrentClienteId()
        {
            currentclienteId = (Int32)dataGrid_Clientes.CurrentRow.Cells[0].Value;


        }

       

        private void dataGrid_Clientes_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            TakeActiveRowToTexBoxes();
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            if (currentclienteId.HasValue && !currentclienteId.Equals(0))
            {
                dbAccess.RemoveCliente((Int32)currentclienteId);
            }
            button_Eliminar.Enabled = false;
            LoadClienteListDataGrid();
        }
    }
}
