using System;
using System.Windows.Forms;
using System.Drawing;

namespace DataGridView
{
    public partial class New : Form
    {
        const int x_offset_textbox = 256;
        const int x_offset_button = 90;
        const int y_offset = 40;

        public New()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int start_x = (sender as Button).Location.X;
            int location_y = (sender as Button).Location.Y + y_offset;

            TextBox add_textbox = new TextBox();
            add_textbox.Tag = "column_name";
            add_textbox.Location = new Point(start_x-x_offset_textbox, location_y);
            add_textbox.Size = new Size(235,20);

            Button add_button = new Button();
            add_button.Text = "Добавить";
            add_button.Click += button3_Click;
            add_button.Location = new Point(start_x, location_y);

            Button delete_button = new Button();
            delete_button.Text = "Delete";
            delete_button.Click += delete_button_click;
            delete_button.Location = new Point(start_x + x_offset_button, location_y);
            
            

            this.Height += y_offset;
            
            this.Controls.Add(add_textbox);
            this.Controls.Add(add_button);
            this.Controls.Add(delete_button);
            
        }

        private void delete_button_click(object sender, EventArgs e)
        {
            int last_index = this.Controls.IndexOf(sender as Button);
            this.Controls.RemoveAt(last_index--);
            this.Controls.RemoveAt(last_index--);
            this.Controls.RemoveAt(last_index);
            this.Height -= y_offset;
        }
    }
}