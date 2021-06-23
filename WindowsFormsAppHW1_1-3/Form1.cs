using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppHW1_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                double tmp = 0;
                string[] vs = { "Hi, I'm @NiiL2150",
                "I'm interested in programming",
                "I'm currently learning .NET (specifically C# and desktop applications)",
                "I'm looking to collaborate on noting right now",
                "How to reach me: nail.shamsudinov@gmail.com"
                };
                for (int i = 0; i < vs.Length - 1; i++)
                {
                    tmp += vs[i].Length;
                    MessageBox.Show(vs[i], "Resume", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tmp += vs[vs.Length - 1].Length;
                MessageBox.Show(vs[vs.Length - 1], $"{tmp / Convert.ToDouble(vs.Length)} charachters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            {
                Random random = new Random();
                int tmp;
                do
                {
                    tmp = 0;
                    do
                    {
                        tmp++;
                    } while (MessageBox.Show($"Is the number - {random.Next(1, 2001)}?", "Quess the number", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
                } while (tmp == 1 ? MessageBox.Show($"{tmp} attemp\nPlay once more?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes : MessageBox.Show($"{tmp} attemps\nPlay once more?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonRectangle_Click(object sender, MouseEventArgs e)
        {
            if (System.Windows.Forms.MouseButtons.Right == e.Button)
            {
                if (ModifierKeys.HasFlag(Keys.Control))
                {
                    Application.Exit();
                }
                MessageBox.Show($"{Form1.ActiveForm.Size.Width}; {Form1.ActiveForm.Size.Height};");
            }
            else
            {
                MessageBox.Show((sender as Button).Text, "Click", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1.ActiveForm.Text = $"{MousePosition.X-Form1.ActiveForm.Location.X}; {MousePosition.Y-Form1.ActiveForm.Location.Y};";
        }
    }
}
