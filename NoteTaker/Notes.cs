using System.Data;
using System.Media;

namespace NoteTaker
{
    public partial class Notes : Form
    {
        DataTable table;
        public readonly static string menuLocation = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Sounds\menuSelect.wav");
        public static SoundPlayer player = new SoundPlayer(Notes.menuLocation);


        public Notes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Useless...
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Useless...
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);

            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Messages", typeof(string));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 140;

            Console.WriteLine("Hello");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                //txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtTitle.Text = table.Rows[index]["Title"].ToString();
                //txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
                txtMessage.Text = table.Rows[index]["Messages"].ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
        /*private void ToRemindBtn_Click(object sender, EventArgs e)
        {
            var r = new Reminder();
            r.Show();
            this.Close();
        }*/


        private void ToReminderForm_Click(object sender, EventArgs e)
        {
            player.Play();
            var r = new Reminder();
            r.Show();
            this.Hide();

        }
    }
}