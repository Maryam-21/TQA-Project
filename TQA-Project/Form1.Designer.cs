
namespace TQA_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cond_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cond_value_txt = new System.Windows.Forms.TextBox();
            this.add_cnd_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.action_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.action_values_txt = new System.Windows.Forms.TextBox();
            this.add_acc_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.test_scenario_txt = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Condition";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cond_txt
            // 
            this.cond_txt.Location = new System.Drawing.Point(170, 91);
            this.cond_txt.Name = "cond_txt";
            this.cond_txt.Size = new System.Drawing.Size(125, 27);
            this.cond_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Possible Values";
            // 
            // cond_value_txt
            // 
            this.cond_value_txt.Location = new System.Drawing.Point(498, 88);
            this.cond_value_txt.Name = "cond_value_txt";
            this.cond_value_txt.Size = new System.Drawing.Size(163, 27);
            this.cond_value_txt.TabIndex = 3;
            // 
            // add_cnd_btn
            // 
            this.add_cnd_btn.Location = new System.Drawing.Point(498, 134);
            this.add_cnd_btn.Name = "add_cnd_btn";
            this.add_cnd_btn.Size = new System.Drawing.Size(163, 29);
            this.add_cnd_btn.TabIndex = 4;
            this.add_cnd_btn.Text = "Add Condition";
            this.add_cnd_btn.UseVisualStyleBackColor = true;
            this.add_cnd_btn.Click += new System.EventHandler(this.add_cnd_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Action";
            // 
            // action_txt
            // 
            this.action_txt.Location = new System.Drawing.Point(170, 198);
            this.action_txt.Name = "action_txt";
            this.action_txt.Size = new System.Drawing.Size(125, 27);
            this.action_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Possible Values";
            // 
            // action_values_txt
            // 
            this.action_values_txt.Location = new System.Drawing.Point(498, 201);
            this.action_values_txt.Name = "action_values_txt";
            this.action_values_txt.Size = new System.Drawing.Size(163, 27);
            this.action_values_txt.TabIndex = 8;
            // 
            // add_acc_btn
            // 
            this.add_acc_btn.Location = new System.Drawing.Point(498, 243);
            this.add_acc_btn.Name = "add_acc_btn";
            this.add_acc_btn.Size = new System.Drawing.Size(163, 29);
            this.add_acc_btn.TabIndex = 9;
            this.add_acc_btn.Text = "Add Action";
            this.add_acc_btn.UseVisualStyleBackColor = true;
            this.add_acc_btn.Click += new System.EventHandler(this.add_acc_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Test Scenario";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(498, 438);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(163, 29);
            this.submit_btn.TabIndex = 12;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // test_scenario_txt
            // 
            this.test_scenario_txt.Location = new System.Drawing.Point(167, 291);
            this.test_scenario_txt.Name = "test_scenario_txt";
            this.test_scenario_txt.Size = new System.Drawing.Size(494, 127);
            this.test_scenario_txt.TabIndex = 13;
            this.test_scenario_txt.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Decision Table Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.test_scenario_txt);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_acc_btn);
            this.Controls.Add(this.action_values_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.action_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add_cnd_btn);
            this.Controls.Add(this.cond_value_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cond_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cond_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cond_value_txt;
        private System.Windows.Forms.Button add_cnd_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox action_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox action_values_txt;
        private System.Windows.Forms.Button add_acc_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.RichTextBox test_scenario_txt;
        private System.Windows.Forms.Label label6;
    }
}

