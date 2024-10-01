namespace DateTime
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
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            dtpBDate = new DateTimePicker();
            cmbCountry = new ComboBox();
            label4 = new Label();
            button3 = new Button();
            label5 = new Label();
            dtpDateTime = new DateTimePicker();
            lblDateTime = new Label();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            button4 = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(451, 53);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(113, 53);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Date From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 61);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Date To";
            // 
            // button1
            // 
            button1.Location = new Point(298, 103);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(576, 152);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 150);
            label3.Name = "label3";
            label3.Size = new Size(189, 15);
            label3.TabIndex = 6;
            label3.Text = "Calculate the DAY of your Birthday";
            // 
            // dtpBDate
            // 
            dtpBDate.Location = new Point(343, 150);
            dtpBDate.Name = "dtpBDate";
            dtpBDate.Size = new Size(200, 23);
            dtpBDate.TabIndex = 7;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(184, 201);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(121, 23);
            cmbCountry.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 209);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Country";
            // 
            // button3
            // 
            button3.Location = new Point(518, 248);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Process";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(184, 256);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "Date / Time";
            label5.Click += label5_Click;
            // 
            // dtpDateTime
            // 
            dtpDateTime.Location = new Point(273, 248);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(239, 23);
            dtpDateTime.TabIndex = 12;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(273, 304);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(38, 15);
            lblDateTime.TabIndex = 13;
            lblDateTime.Text = "label6";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(184, 342);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 14;
            label6.Text = "Enter Date";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(273, 334);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 15;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(497, 334);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Submit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(275, 385);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(38, 15);
            lblMsg.TabIndex = 17;
            lblMsg.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg);
            Controls.Add(button4);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(lblDateTime);
            Controls.Add(dtpDateTime);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(cmbCountry);
            Controls.Add(dtpBDate);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private DateTimePicker dtpBDate;
        private ComboBox cmbCountry;
        private Label label4;
        private Button button3;
        private Label label5;
        private DateTimePicker dtpDateTime;
        private Label lblDateTime;
        private Label label6;
        private DateTimePicker dtpDate;
        private Button button4;
        private Label lblMsg;
    }
}
