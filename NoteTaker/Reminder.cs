using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Reflection;

namespace NoteTaker
{
    public partial class Reminder : Form
    {

        public Reminder()
        {
            InitializeComponent();
        }


        private void ToNotesForm_Click(object sender, EventArgs e)
        {
            Notes.player.Play();
            var r = new Notes();
            r.Show();
            this.Hide();
        }
    }
}
