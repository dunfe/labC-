using HE130007_KhoiTran_Lab3.DAL;
using HE130007_KhoiTran_Lab3.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE130007_KhoiTran_Lab3.GUI
{
    public partial class BorrowerGUI : Form
    {
        DataView dv;
        Copy c;
        Reservation r;
        enum errorBorrow
        {
            Ok,
            Connect,
            CopyNotExist,
            CopyReferenced,
            CopyBorrowed,
            CopyReserved
        };
        public BorrowerGUI()
        {
            InitializeComponent();

            DataTable bobd = BorrowerDAO.GetDataTable();
            dataGridView1.DataSource = bobd;

            txtBorrowedDate.Text = DateTime.Now.ToString("dd / MM / yyyy");
            txtDueDate.Text=DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            displayButtons(1);
        }


        

        private void displayButtons(int state)
        {
            switch (state)
            {
                // to enter member and check member
                case 1:
                    txtBorrowerNumber.Enabled = true;
                    btnMember.Enabled = true;

                    txtCopyNumber.Enabled = false;
                    btnCondition.Enabled = false;

                    txtBorrowedDate.Enabled = false;
                    btnBorrow.Enabled = false;

                    break;

                // to check condition
                case 2:
                    txtBorrowerNumber.Enabled = false;
                    btnMember.Enabled = false;

                    txtBorrowedDate.Enabled = true;
                    btnCondition.Enabled = true;

                    txtBorrowedDate.Enabled = false;
                    btnBorrow.Enabled = false;

                    break;
                //to borrow
                case 3:
                    txtBorrowerNumber.Enabled = false;
                    btnMember.Enabled = false;

                    txtCopyNumber.Enabled = false;
                    btnCondition.Enabled = false;

                    txtBorrowedDate.Enabled = true;

                    break;
            }
        }

      
        private void btnMember_Click(object sender, EventArgs e)
        {
            int borrowerNumber;
            try
            {
                borrowerNumber = int.Parse(txtBorrowerNumber.Text);
            }
            catch
            {
                MessageBox.Show("Borrower number must be an integer!");
                txtBorrowerNumber.Focus();
                return;
            }
           
        }
    }
}
