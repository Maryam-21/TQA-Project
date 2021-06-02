using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TQA_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("column0", "Conditions");
            for (int i = 1; i < Form1.script.Count + 1; i++)
                dataGridView1.Columns.Add("column" + i, "R" + i);
            for (int i = 1; i < Form1.conditions.Count + 1; i++)
            {
                dataGridView1.Rows.Add(Form1.conditions[i - 1]);
            }
            dataGridView1.Rows.Add(" ");
            dataGridView1.Rows.Add("Actions");
            for (int i = 1; i < Form1.actions.Count + 1; i++)
            {
                dataGridView1.Rows.Add(Form1.actions[i - 1]);
            }
            
            for(int i=0; i<Form1.script.Count; i++)
            {
                List<string> c = Form1.script[i].Item1.ToList();
                for (int j = 0; j < c.Count; j++)
                {
                    dataGridView1.Rows[j].Cells[i + 1].Value = c[j];
                }

                List<string> a = Form1.script[i].Item2.ToList();
                for(int j=0; j<a.Count; j++)
                {
                    dataGridView1.Rows[2+Form1.conditions.Count+j].Cells[i+1].Value = a[j];
                }

            }
        }
    }
}
