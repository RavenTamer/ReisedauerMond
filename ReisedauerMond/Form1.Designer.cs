namespace ReisedauerMond
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
            this.radiodays = new System.Windows.Forms.RadioButton();
            this.radiohours = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculate = new System.Windows.Forms.Button();
            this.speedbox = new System.Windows.Forms.NumericUpDown();
            this.labelspeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedbox)).BeginInit();
            this.SuspendLayout();
            // 
            // radiodays
            // 
            this.radiodays.AutoSize = true;
            this.radiodays.Location = new System.Drawing.Point(6, 54);
            this.radiodays.Name = "radiodays";
            this.radiodays.Size = new System.Drawing.Size(69, 19);
            this.radiodays.TabIndex = 0;
            this.radiodays.TabStop = true;
            this.radiodays.Text = "in Tagen";
            this.radiodays.UseVisualStyleBackColor = true;
            // 
            // radiohours
            // 
            this.radiohours.AutoSize = true;
            this.radiohours.Location = new System.Drawing.Point(81, 54);
            this.radiohours.Name = "radiohours";
            this.radiohours.Size = new System.Drawing.Size(82, 19);
            this.radiohours.TabIndex = 1;
            this.radiohours.TabStop = true;
            this.radiohours.Text = "in Stunden";
            this.radiohours.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculate);
            this.groupBox1.Controls.Add(this.speedbox);
            this.groupBox1.Controls.Add(this.labelspeed);
            this.groupBox1.Controls.Add(this.radiodays);
            this.groupBox1.Controls.Add(this.radiohours);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reisedauer zum Mond berechnen";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(6, 140);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(200, 25);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Reisedauer berechnen";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(138, 91);
            this.speedbox.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(68, 23);
            this.speedbox.TabIndex = 3;
            // 
            // labelspeed
            // 
            this.labelspeed.AutoSize = true;
            this.labelspeed.Location = new System.Drawing.Point(6, 93);
            this.labelspeed.Name = "labelspeed";
            this.labelspeed.Size = new System.Drawing.Size(126, 15);
            this.labelspeed.TabIndex = 2;
            this.labelspeed.Text = "Geschwindigkeit km/h";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reisedauer";
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(93, 208);
            this.resultbox.Name = "resultbox";
            this.resultbox.ReadOnly = true;
            this.resultbox.Size = new System.Drawing.Size(125, 23);
            this.resultbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 249);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton radiodays;
        private RadioButton radiohours;
        private GroupBox groupBox1;
        private Button calculate;
        private NumericUpDown speedbox;
        private Label labelspeed;
        private Label label1;
        private TextBox resultbox;
    }
}