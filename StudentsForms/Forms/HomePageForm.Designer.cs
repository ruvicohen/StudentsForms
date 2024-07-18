namespace StudentsForms.Forms
{
    partial class HomePageForm
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
            buttonSaveDetails = new Button();
            label1 = new Label();
            textBoxNameInterested = new TextBox();
            label2 = new Label();
            textBoxCourseID = new TextBox();
            textBoxPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxTZ = new TextBox();
            textBoxNameStudent = new TextBox();
            buttonToDeshbord = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSaveDetails
            // 
            buttonSaveDetails.Location = new Point(56, 279);
            buttonSaveDetails.Name = "buttonSaveDetails";
            buttonSaveDetails.Size = new Size(94, 29);
            buttonSaveDetails.TabIndex = 1;
            buttonSaveDetails.Text = "שלח";
            buttonSaveDetails.UseVisualStyleBackColor = true;
            buttonSaveDetails.Click += buttonSaveDetails_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 19);
            label1.Name = "label1";
            label1.Size = new Size(197, 20);
            label1.TabIndex = 2;
            label1.Text = "מכללת נמרודי- ברוכים הבאים";
            label1.Click += label1_Click;
            // 
            // textBoxNameInterested
            // 
            textBoxNameInterested.Location = new Point(25, 127);
            textBoxNameInterested.Name = "textBoxNameInterested";
            textBoxNameInterested.Size = new Size(125, 27);
            textBoxNameInterested.TabIndex = 3;
            textBoxNameInterested.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 79);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "הקורסים שלנו";
            // 
            // textBoxCourseID
            // 
            textBoxCourseID.Location = new Point(25, 225);
            textBoxCourseID.Name = "textBoxCourseID";
            textBoxCourseID.Size = new Size(125, 27);
            textBoxCourseID.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(25, 172);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 79);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 7;
            label3.Text = "השארת פרטים לחזרה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 356);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 8;
            label4.Text = "אזור אישי";
            // 
            // textBoxTZ
            // 
            textBoxTZ.Location = new Point(337, 395);
            textBoxTZ.Name = "textBoxTZ";
            textBoxTZ.Size = new Size(125, 27);
            textBoxTZ.TabIndex = 9;
            textBoxTZ.TextChanged += textBoxTZ_TextChanged;
            // 
            // textBoxNameStudent
            // 
            textBoxNameStudent.Location = new Point(566, 393);
            textBoxNameStudent.Name = "textBoxNameStudent";
            textBoxNameStudent.Size = new Size(125, 27);
            textBoxNameStudent.TabIndex = 10;
            // 
            // buttonToDeshbord
            // 
            buttonToDeshbord.Location = new Point(218, 393);
            buttonToDeshbord.Name = "buttonToDeshbord";
            buttonToDeshbord.Size = new Size(94, 29);
            buttonToDeshbord.TabIndex = 11;
            buttonToDeshbord.Text = "כנס";
            buttonToDeshbord.UseVisualStyleBackColor = true;
            buttonToDeshbord.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(512, 188);
            dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 228);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 13;
            label5.Text = "קורס ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 179);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 14;
            label6.Text = "טלפון";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 134);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 15;
            label7.Text = "שם מלא";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 396);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 16;
            label8.Text = "ת.ז.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(697, 393);
            label9.Name = "label9";
            label9.Size = new Size(63, 20);
            label9.TabIndex = 17;
            label9.Text = "שם מלא";
            // 
            // HomePageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(buttonToDeshbord);
            Controls.Add(textBoxNameStudent);
            Controls.Add(textBoxTZ);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxCourseID);
            Controls.Add(label2);
            Controls.Add(textBoxNameInterested);
            Controls.Add(label1);
            Controls.Add(buttonSaveDetails);
            Name = "HomePageForm";
            Text = "HomePageForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSaveDetails;
        private Label label1;
        private TextBox textBoxNameInterested;
        private Label label2;
        private TextBox textBoxCourseID;
        private TextBox textBoxPhone;
        private Label label3;
        private Label label4;
        private TextBox textBoxTZ;
        private TextBox textBoxNameStudent;
        private Button buttonToDeshbord;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}