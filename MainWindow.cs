using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using RugFactory.Db;

namespace RugFactory
{
    public partial class MainWindow : Form
    {
        
        public Int32? CurrentClienteId { get; set; }
        public string CurrentClienteName { get; set; }
        public Int32? CurrentAlbaranId { get; set; }
        public string CurrentAlbaranInterno { get; set; }
        public Albaran CurrentAlbaran { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            CurrentClienteId = 0;
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            Type childType = typeof(Add_Alfombra_Form);
            Form ChildForm = this.MdiChildren.FirstOrDefault(c => c.GetType() == typeof(Add_Alfombra_Form));
            showChild(ChildForm, childType);
        }
       
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClienteWindow();

        }
        public void ShowClienteWindow()
        {
            using (Clientes_Window clienteChildFrom = new Clientes_Window())
            {
                Type childType = typeof(Clientes_Window);
                Form clienteChildForm = this.MdiChildren.FirstOrDefault(c => c.GetType() == typeof(Clientes_Window));



                showChild(clienteChildForm, childType);

            }



            //Clientes_Window clientes = new Clientes_Window();
            //clientes.MdiParent = this;
            //clientes.Show();
        }
        private void almacenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type childType = typeof(Alfombras_Consultas_Window);
            Form clienteChildForm = this.MdiChildren.FirstOrDefault(c => c.GetType() == typeof(Alfombras_Consultas_Window));
            showChild(clienteChildForm, childType);
            
        }
        //Methods:
        //
        //Show childForm and Make it if it doesnt exists:
        /// <summary>
        /// Show the Child Form, eitherway instantiate it or Bring it to WindoState.Maximized 
        /// if it already exists and minimized.
        /// </summary>
        /// <param name="child"></param>
        /// <param name="childType">The Type of Form to be create if the child is Null</param>
        private void showChild(Form child, Type childType)
        {
            if (child != null)
            {
                child.Activate();
                child.WindowState = FormWindowState.Maximized;
                
            }
            Form newChildForm =(Form) Activator.CreateInstance(childType);
            newChildForm.MdiParent = this;
            newChildForm.Show();
       
            
          
        }

        private void fallosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type childType = typeof(Fallos_Settings_Form);
            Form clienteChildForm = this.MdiChildren.FirstOrDefault(c => c.GetType() == typeof(Fallos_Settings_Form));
            showChild(clienteChildForm, childType);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
