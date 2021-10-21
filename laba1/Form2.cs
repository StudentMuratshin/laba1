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

            //столбцы и строчки 
            var column = new TableLayoutPanel();
            column.Dock = DockStyle.Fill;
            column.ColumnCount = 2;
            column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            column.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66));
            column.RowCount = ((int)count) + 1;
            column.AutoScroll = true;
            
            
            groupBox.Controls.Add(column);

            for (int r = 0; r < column.RowCount - 1; ++r)
            {
                var radio = new TableLayoutPanel();
                radio.Dock = DockStyle.Top;
                radio.ColumnCount = 2;
                radio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                radio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                //radio.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                var task = new Label();
                task.Dock = DockStyle.Top;
                if (simple)
                {
                    task.Text = $"Изи #{r + 1}";
                }
                else
                {
                    task.Text = $"Хард #{r + 1}";
                }


                column.Controls.Add(task, 0, r);

                var answer1 = new RadioButton();
                answer1.Dock = DockStyle.Top;
                if (!simple)
                {
                    answer1.Text = "этот";
                }
                else
                {
                    answer1.Text = "этот";
                }

                var answer2 = new RadioButton();
                answer2.Dock = DockStyle.Top;
                if (!simple)
                {
                    answer2.Text = "или этот";
                }
                else
                {
                    answer2.Text = "не этот";
                }


                radio.Controls.Add(answer1, 0, 0);
                radio.Controls.Add(answer2, 1, 0);
                column.Controls.Add(radio, 1, r);

            }
            var mainAnswer = new Button();
            mainAnswer.Text = "тыкать";
            mainAnswer.Dock = DockStyle.Top;
            mainAnswer.Click += new EventHandler(onSubmitClick);
            column.Controls.Add(mainAnswer, 0, column.RowCount);
            this.Controls.Add(groupBox);
        }
        private void onSubmitClick(object sender, EventArgs e)
        {
            MessageBox.Show("тыкнута тыкалка");
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       
    }
}
