namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtNameLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCourseandGrade = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CourseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.credit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.letterGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calclatedPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxCourseandGrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(139, 25);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(389, 20);
            this.txtStudentNumber.TabIndex = 1;
            this.txtStudentNumber.TextChanged += new System.EventHandler(this.txtStudentNumber_TextChanged);
            this.txtStudentNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStudentNumber_KeyDown);
            // 
            // txtNameLastName
            // 
            this.txtNameLastName.Location = new System.Drawing.Point(139, 71);
            this.txtNameLastName.Name = "txtNameLastName";
            this.txtNameLastName.Size = new System.Drawing.Size(389, 20);
            this.txtNameLastName.TabIndex = 3;
            this.txtNameLastName.TextChanged += new System.EventHandler(this.txtNameLastName_TextChanged);
            this.txtNameLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameLastName_KeyDown);
            this.txtNameLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameLastName_KeyPress);
            this.txtNameLastName.Leave += new System.EventHandler(this.txtNameLastName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nane and Last Name";
            // 
            // groupBoxCourseandGrade
            // 
            this.groupBoxCourseandGrade.Controls.Add(this.button1);
            this.groupBoxCourseandGrade.Controls.Add(this.comboBox2);
            this.groupBoxCourseandGrade.Controls.Add(this.comboBox1);
            this.groupBoxCourseandGrade.Location = new System.Drawing.Point(85, 136);
            this.groupBoxCourseandGrade.Name = "groupBoxCourseandGrade";
            this.groupBoxCourseandGrade.Size = new System.Drawing.Size(627, 115);
            this.groupBoxCourseandGrade.TabIndex = 4;
            this.groupBoxCourseandGrade.TabStop = false;
            this.groupBoxCourseandGrade.Text = "Courses and Grades Selection";
            this.groupBoxCourseandGrade.Enter += new System.EventHandler(this.groupBoxCourseandGrade_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert Into list View";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 57);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseName,
            this.credit,
            this.letterGrade,
            this.creditPoint,
            this.calclatedPoint});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(85, 307);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(654, 147);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CourseName
            // 
            this.CourseName.Text = "Course Name";
            this.CourseName.Width = 100;
            // 
            // credit
            // 
            this.credit.Text = "Credit";
            // 
            // letterGrade
            // 
            this.letterGrade.Text = "Letter Grade";
            // 
            // creditPoint
            // 
            this.creditPoint.Text = "Credit Point";
            // 
            // calclatedPoint
            // 
            this.calclatedPoint.Text = "Calculated Point";
            this.calclatedPoint.Width = 132;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(390, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Row";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(614, 470);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(98, 20);
            this.txtGpa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 515);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBoxCourseandGrade);
            this.Controls.Add(this.txtNameLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GPA Calculation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCourseandGrade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtNameLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCourseandGrade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CourseName;
        private System.Windows.Forms.ColumnHeader credit;
        private System.Windows.Forms.ColumnHeader letterGrade;
        private System.Windows.Forms.ColumnHeader creditPoint;
        private System.Windows.Forms.ColumnHeader calclatedPoint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.Label label3;
    }
}

