using System.Data;

namespace Note_Taking
{
    public partial class NoteTaker : Form
    {

        DataTable table;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            dvgNote.DataSource = table;
        }

        

       //the buttons did not work without this one still seems like new and view buttons not working
        private void NoteTaker_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            dvgNote.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text);
            btnNew.PerformClick();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int index = dvgNote.CurrentCell.RowIndex;
            if (index > -1)
            {
                textTitle.Text = table.Rows[index].ItemArray[0].ToString();
                textMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dvgNote.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }
    }
}