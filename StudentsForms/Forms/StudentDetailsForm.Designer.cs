namespace StudentsForms.Forms
{
    partial class StudentDetailsForm
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            labelDebt = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            textBoxCourse = new TextBox();
            label5 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(89, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "אשר תשלום";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "אזור אישי";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(626, 88);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 4;
            label2.Text = "הקורסים שלך";
            // 
            // labelDebt
            // 
            labelDebt.AutoSize = true;
            labelDebt.Location = new Point(99, 32);
            labelDebt.Name = "labelDebt";
            labelDebt.Size = new Size(103, 20);
            labelDebt.TabIndex = 5;
            labelDebt.Text = "יתרה לתשלום ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 104);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 6;
            label4.Text = "הכנס סכום לתשלום";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(394, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(329, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 374);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 8;
            label3.Text = "הרשמה לקורס חדש";
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(405, 411);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.Size = new Size(136, 27);
            textBoxCourse.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 411);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 10;
            label5.Text = "ID קורס";
            // 
            // button2
            // 
            button2.Location = new Point(295, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "אשר תשלום";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(textBoxCourse);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(labelDebt);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "StudentDetailsForm";
            Text = "StudentDetailsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label labelDebt;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBoxCourse;
        private Label label5;
        private Button button2;
    }
}