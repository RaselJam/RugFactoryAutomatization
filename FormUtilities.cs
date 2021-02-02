using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugFactory
{
    static class  FormUtilities
    {
        public static object cboCrudSearchColumn { get; private set; }

        public static bool CheckEnterKeyPressed(KeyEventArgs e)
        {
            // Enter key pressed or not
            return (e.KeyCode ==  Keys.Enter);
                     
        }
        public static void ShowDialog(Form parent, Form child)
        {
          
            child.ShowDialog(parent);
        }
        public static void TuggleButtonText(Button target, string toTuggle)
        {
            target.Text = toTuggle;
        }
        public static  void CleanAllTextBoxes(Form targetToClean)
        
        {
            var textBoxes = targetToClean.Controls.OfType<TextBox>();
            foreach(TextBox t in textBoxes)
            {
                t.Text = string.Empty;
                t.BackColor = Color.White;
            }
        }
        public static void CleanErrorProviderMessage(ErrorProvider provider, Form formToClean)
        {
            foreach (Control c in formToClean.Controls)

            {
                provider.SetError(c, null);
            }

        }
        public static void PrepeareDataGridViewForSearch(DataGridView dataGridView)
        {
            dataGridView.CurrentCell = null;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ClearSelection();

        }
        public static void SearchAGivenDataGridView(DataGridView dataGridView, string query)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if ( cell.FormattedValue.ToString().Contains(query))
                        {
                            
                            row.Visible = true;
                            break;
                        }
                        
                    }
                   

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public static void ResetDataGridView(DataGridView target)
        {
            foreach (DataGridViewRow row in target.Rows)
            {
                row.Visible = true;
            }
        }
        public static Int32 GetIdFromAutoCompleteToolTip(string s)
        {
            //String will come in this format : "Name :{0}", ID; And we want to extract the ID
            int indexOfSeperator = s.IndexOf(',') ;
            if (indexOfSeperator == -1) return -1;
            return Int32.Parse(s.Substring(indexOfSeperator + 1) );
        }
        public static string GetNameFromAutoCompleteToolTip(string s)
        {
            //String will come in this format : "Name :{0}", ID; And we want to extract the ID
            int indexOfSeperator = s.IndexOf(',');
            if (indexOfSeperator == -1) return string.Empty;
            return s.Substring(0, indexOfSeperator);
        }
        public static void MakeRedIFChecked(CheckBox c)
        {
            c.ForeColor = c.Checked ? Color.Red : Color.White;
        }
         public static void BoldME(Control sender, bool tuggle)
        {
            

            sender.Font = new Font(sender.Font.FontFamily,
                                   tuggle? sender.Font.Size +3: sender.Font.Size -3,
                                   tuggle? FontStyle.Bold: FontStyle.Regular);
            sender.Location = new Point(sender.Location.X, 
                                         tuggle? sender.Location.Y -3 : sender.Location.Y +3

                                        );
        }
        public static void AllowOnlyDigit( KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ) e.Handled = true;

            

        }
        public static void AllowOnlyString( KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        /// <summary>
        /// Eanable all Controls Except the provided excepted
        /// </summary>
        /// <param name="target"></param>
        /// <param name="exceptThis"></param>
        public static void EnableControlers (Form target, Control exceptThis)
        {
            
            foreach (Control item in  target.Controls)
            {
                item.Enabled = true;
                if (item == exceptThis) item.Enabled = false;
            }
        }
        /// <summary>
        /// Tuggle Enable/Disable the List of given Controls
        /// </summary>
        /// <param name="controls"></param>
        public static void EnableControlers(List<Control> controls, bool status)
        {
            foreach (Control item in controls)
            {
                item.Enabled = status;
            }
        }
        public static void DisabaleControles( Form target,Control exceptThis)
        {
            foreach (Control item in target.Controls)
            {
                item.Enabled = false;
                if (item == exceptThis || item.GetType() ==typeof(Label)) item.Enabled = true;
               
            }
           
        }
        public static List<CheckBox> GetChecBoxes(Form target,string tag=null)
        {
            List<CheckBox> checkBoxes = new List<CheckBox>();
            bool test = false;
           
                foreach (var item in target.Controls)
                {
                //Optioanl Tag :
                    if (item is CheckBox && (tag==null || ((CheckBox)item).Tag.Equals(tag)))
                    {
                        checkBoxes.Add((CheckBox)item);
                    }
                }    
            return checkBoxes;
        }
        public static List<Int32> GetChecedBoxesId(List<CheckBox> checkBoxes)
        { 
            List<Int32> ids = new List<int>();

            foreach (CheckBox item in checkBoxes)
            {
                if (item.Checked)
                {
                    Int32 id = Int32.Parse(item.Name);
                    ids.Add(id);
                }
            }
           
            return ids;
        }

    }
}
