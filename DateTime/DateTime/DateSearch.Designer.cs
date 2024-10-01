namespace DateTime
{
    partial class DateSearch
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
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(165, 132);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 50);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Date From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 92);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Date To";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(165, 42);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(165, 84);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 4;
            // 
            // DateSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "DateSearch";
            Text = "DateSearch";
            Load += DateSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
    }
}