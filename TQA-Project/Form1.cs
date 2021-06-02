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
    public partial class Form1 : Form
    {

        public static List<string> conditions;
        public static List<string> actions;
        public static List<List<string>> valuesOfConditions;
        public static List<List<string>> valuesOfActions;
        public static List<Tuple<List<string>,List<string>>> script;
    


        public Form1()
        {
            InitializeComponent();
            conditions = new List<string>();
            actions = new List<string>();
            valuesOfActions = new List<List<string>>();
            valuesOfConditions = new List<List<string>>();
            script = new List<Tuple<List<string>, List<string>>>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void add_cnd_btn_Click(object sender, EventArgs e)
        {
            conditions.Add(cond_txt.Text);
            string[] values = cond_value_txt.Text.Split(',');
            int c = valuesOfConditions.Count();
            valuesOfConditions.Add(new List<string>());
            foreach (string v  in values)
            {
              valuesOfConditions[c].Add(v);
            }
            cond_txt.Clear();
            cond_value_txt.Clear();
        }

        private void add_acc_btn_Click(object sender, EventArgs e)
        {
            actions.Add(action_txt.Text);
            string[] values = action_values_txt.Text.Split(',');
            int c = valuesOfActions.Count();
            valuesOfActions.Add(new List<string>());
            foreach (string v in values)
            {
                valuesOfActions[c].Add(v);
            }
            action_txt.Clear();
            action_values_txt.Clear();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            string[] values = test_scenario_txt.Text.Split('\n');
            
            int c = 0;
            foreach (string v in values)
            {
                string[] condsActs = v.Split(':');
                string[] cond = condsActs[0].Split(',');
                script.Add(new Tuple<List<string>, List<string>>(new List<string>(), new List<string>()));
                for (int i=0; i<cond.Length; i++)
                {
                    script[c].Item1.Add(cond[i]);
                }
                string[] act = condsActs[1].Split(',');
                for (int i = 0; i < act.Length; i++)
                {
                    script[c].Item2.Add(act[i]);
                }
                //script[c].Item2.Add(cond[cond.Length - 1]);
                c++;
            }



            //reduction
            //the idea is to find 2 cols with the same values for all conditions except for one
            //replace the one with - 
            while (true)
            {
                int reduced = 0;
                for (int i = 0; i < script.Count; i++)
                {
                    for (int j = i + 1; j < script.Count; j++)
                    {
                        int enter = 0;
                        for (int z = 0; z < actions.Count; z++)
                        {
                            if (script[i].Item2[z] == script[j].Item2[z])
                            {
                                enter++;
                               
                            }
                           
                        }
                        if (enter == actions.Count)
                        {
                            int count = 0;
                            int index = -1;
                            for (int k = 0; k < conditions.Count; k++)
                            {
                                if (script[i].Item1[k] != script[j].Item1[k])
                                {
                                    count++;
                                    if (count > 1)
                                        break;
                                    index = k;
                                }
                            }
                            if (count == 1)
                            {
                                reduced++;
                                script.RemoveAt(j);
                                script[i].Item1[index] = "-";
                            }
                        }
                    }
                    
                }
                if (reduced == 0)
                    break;
            }
            
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
