using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form2 : Form
    {
        public Form2(string name, string secondName, string number_class, decimal count, bool simple)
        {
            InitializeComponent();
            //груп бокс
            var groupBox = new GroupBox();
            groupBox.Dock = DockStyle.Fill;
            groupBox.Text = $"{secondName} {name} {number_class}";

            var panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.AutoScroll = true; 
            groupBox.Controls.Add(panel);
            //столбцы и строчки 
            //var column = new TableLayoutPanel();
            //column.Dock = DockStyle.Fill;
            //column.ColumnCount = 2;
            //column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            //column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            //column.RowCount = ((int)count) + 1;


            var click = new Button();
            click.Text = "Ответить";
            var Final = new SplitContainer();
            Final.Orientation = System.Windows.Forms.Orientation.Horizontal;
            Final.Dock = DockStyle.Top;
            Final.Panel1.Controls.Add(click);
            click.Click += new EventHandler(onSubmitClick);
            panel.Controls.Add(Final);





            for (int i = 0; i < count; i++)
            {
                var splitcont = new SplitContainer();
                splitcont.Orientation = System.Windows.Forms.Orientation.Horizontal;
                splitcont.Dock = DockStyle.Top;

                var column = new TableLayoutPanel();
                column.Dock = DockStyle.Fill;
                column.ColumnCount = 2;
                column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                var text = new Label();
                if (simple)
                {
                    text.Text = $"____________________ Изи {count - i}____________________";
                }
                else
                {
                    text.Text = $"____________________ Хард {count - i}____________________";
                }
                text.AutoSize = false;
                text.Dock = DockStyle.Fill;
                text.TextAlign = ContentAlignment.MiddleCenter;

                var answer1 = new RadioButton();
                answer1.Dock = DockStyle.Left;
                if (!simple)
                {
                    answer1.Text = "хард_1";
                }
                else
                {
                    answer1.Text = "изи_1";
                }

                var answer2 = new RadioButton();
                answer1.Dock = DockStyle.Right;
                if (!simple)
                {
                    answer2.Text = "хард_2";
                }
                else
                {
                    answer2.Text = "изи_2";
                }


                splitcont.Panel1.Controls.Add(text);
                splitcont.Panel2.Controls.Add(column);
                column.Controls.Add(answer1, 0, 0);
                column.Controls.Add(answer2, 1, 0);
                panel.Controls.Add(splitcont);
            }
            
            this.Controls.Add(groupBox);
        }

        
        private void onSubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("оп оп первая лаба готова");
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
