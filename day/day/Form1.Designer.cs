namespace day
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.starcheck = new System.Windows.Forms.CheckBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.usecombo = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // starcheck
            // 
            this.starcheck.AutoSize = true;
            this.starcheck.Location = new System.Drawing.Point(392, 221);
            this.starcheck.Name = "starcheck";
            this.starcheck.Size = new System.Drawing.Size(73, 20);
            this.starcheck.TabIndex = 3;
            this.starcheck.Text = "Starred";
            this.starcheck.UseVisualStyleBackColor = true;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(392, 82);
            this.nametext.Multiline = true;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(169, 103);
            this.nametext.TabIndex = 4;
            // 
            // usecombo
            // 
            this.usecombo.FormattingEnabled = true;
            this.usecombo.Items.AddRange(new object[] {
            "Work",
            "Entertainment",
            "Personal"});
            this.usecombo.Location = new System.Drawing.Point(392, 191);
            this.usecombo.Name = "usecombo";
            this.usecombo.Size = new System.Drawing.Size(121, 24);
            this.usecombo.TabIndex = 5;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(472, 18);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(635, 17);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(75, 23);
            this.readbutton.TabIndex = 7;
            this.readbutton.Text = "Read";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.usecombo);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.starcheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox starcheck;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.ComboBox usecombo;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button readbutton;
    }
}

