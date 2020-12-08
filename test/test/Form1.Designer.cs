namespace test
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startclock = new System.Windows.Forms.Button();
            this.randombutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.loadbutton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(179, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(41, 87);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(114, 45);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "add work";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 2;
            // 
            // startclock
            // 
            this.startclock.Location = new System.Drawing.Point(41, 152);
            this.startclock.Name = "startclock";
            this.startclock.Size = new System.Drawing.Size(114, 46);
            this.startclock.TabIndex = 3;
            this.startclock.Text = "start clock";
            this.startclock.UseVisualStyleBackColor = true;
            this.startclock.Click += new System.EventHandler(this.Startclock_Click);
            // 
            // randombutton
            // 
            this.randombutton.Location = new System.Drawing.Point(41, 204);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(114, 26);
            this.randombutton.TabIndex = 3;
            this.randombutton.Text = "random work";
            this.randombutton.UseVisualStyleBackColor = true;
            this.randombutton.Click += new System.EventHandler(this.Randombutton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount of work";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(44, 236);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(50, 23);
            this.savebutton.TabIndex = 3;
            this.savebutton.Text = "save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(100, 236);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(56, 23);
            this.loadbutton.TabIndex = 3;
            this.loadbutton.Text = "load";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "progress";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "progress";
            this.openFileDialog1.Filter = "Text files|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.randombutton);
            this.Controls.Add(this.startclock);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startclock;
        private System.Windows.Forms.Button randombutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

