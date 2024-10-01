namespace DataGridEx
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
            Button btnSearch;
            dataGridView1 = new DataGridView();
            Member = new DataGridViewCheckBoxColumn();
            IDNum = new DataGridViewTextBoxColumn();
            Last = new DataGridViewTextBoxColumn();
            First = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnBeg = new Button();
            btnRew = new Button();
            btnFast = new Button();
            btnEnd = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(386, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Member, IDNum, Last, First, Age, Gender, Email, Phone });
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 301);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Member
            // 
            Member.HeaderText = "";
            Member.Name = "Member";
            // 
            // IDNum
            // 
            IDNum.HeaderText = "ID Number";
            IDNum.Name = "IDNum";
            // 
            // Last
            // 
            Last.HeaderText = "Last Name";
            Last.Name = "Last";
            // 
            // First
            // 
            First.HeaderText = "First Name";
            First.Name = "First";
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.Name = "Age";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone Number";
            Phone.Name = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(220, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(145, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 20);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBeg
            // 
            btnBeg.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnBeg.Location = new Point(310, 386);
            btnBeg.Name = "btnBeg";
            btnBeg.Size = new Size(47, 34);
            btnBeg.TabIndex = 6;
            btnBeg.Text = "<<";
            btnBeg.UseVisualStyleBackColor = true;
            btnBeg.Click += btnBeg_Click;
            // 
            // btnRew
            // 
            btnRew.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnRew.Location = new Point(363, 386);
            btnRew.Name = "btnRew";
            btnRew.Size = new Size(47, 34);
            btnRew.TabIndex = 7;
            btnRew.Text = "<";
            btnRew.UseVisualStyleBackColor = true;
            btnRew.Click += btnRew_Click;
            // 
            // btnFast
            // 
            btnFast.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnFast.Location = new Point(416, 386);
            btnFast.Name = "btnFast";
            btnFast.Size = new Size(47, 34);
            btnFast.TabIndex = 8;
            btnFast.Text = ">";
            btnFast.UseVisualStyleBackColor = true;
            btnFast.Click += btnFast_Click;
            // 
            // btnEnd
            // 
            btnEnd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnEnd.Location = new Point(469, 386);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(47, 34);
            btnEnd.TabIndex = 9;
            btnEnd.Text = ">>";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(btnEnd);
            Controls.Add(btnFast);
            Controls.Add(btnRew);
            Controls.Add(btnBeg);
            Controls.Add(btnDelete);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Member;
        private DataGridViewTextBoxColumn IDNum;
        private DataGridViewTextBoxColumn Last;
        private DataGridViewTextBoxColumn First;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private Label label1;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnBeg;
        private Button btnRew;
        private Button btnFast;
        private Button btnEnd;
    }
}
