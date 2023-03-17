using System.Data;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        DataTable contacts = new DataTable();
        bool editing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts.Columns.Add("First Name");
            contacts.Columns.Add("Last Name");
            contacts.Columns.Add("Phone number");
            contacts.Columns.Add("E-mail adress");

            // Set data source
            dataGridView1.DataSource = contacts;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frstn.Text = " ";
            secn.Text = " ";
            phonen.Text = " ";
            mailtb.Text = " ";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frstn.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
            secn.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            phonen.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[2].ToString();
            mailtb.Text = contacts.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["First Name"] = frstn.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Last Name"] = secn.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Phone Number"] = phonen.Text;
                contacts.Rows[dataGridView1.CurrentCell.RowIndex]["E-mail adress"] = mailtb.Text;
            }
            else
            {
                contacts.Rows.Add(frstn.Text, secn.Text, phonen.Text, mailtb.Text);
            }
            frstn.Text = " ";
            secn.Text = " ";
            phonen.Text = " ";
            mailtb.Text = " ";
            editing = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                contacts.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Randul nu este valid !!");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            contacts.Rows[dataGridView1.CurrentCell.RowIndex]["First Name"] = frstn.Text;
            contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Last Name"] = secn.Text;
            contacts.Rows[dataGridView1.CurrentCell.RowIndex]["Phone Number"] = phonen.Text;
            contacts.Rows[dataGridView1.CurrentCell.RowIndex]["E-mail adress"] = mailtb.Text;
            editing = true;
        }
    }
}