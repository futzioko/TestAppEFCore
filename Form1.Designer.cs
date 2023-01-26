
namespace Test
{
    partial class StudentForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.textBoxGroupLabel = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.textBoxStudentLabel = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentNumberGroupLabel = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.comboBoxGroupNumber = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxGroups, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 15;
            this.listBoxGroups.Location = new System.Drawing.Point(403, 3);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(394, 444);
            this.listBoxGroups.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxGroupNumber, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxGroupLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddGroup, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStudentLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStudentName, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStudentNumberGroupLabel, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddStudent, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxGroupNumber, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGroupNumber.Location = new System.Drawing.Point(3, 45);
            this.textBoxGroupNumber.Multiline = true;
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(388, 36);
            this.textBoxGroupNumber.TabIndex = 1;
            // 
            // textBoxGroupLabel
            // 
            this.textBoxGroupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGroupLabel.Location = new System.Drawing.Point(3, 3);
            this.textBoxGroupLabel.Multiline = true;
            this.textBoxGroupLabel.Name = "textBoxGroupLabel";
            this.textBoxGroupLabel.ReadOnly = true;
            this.textBoxGroupLabel.Size = new System.Drawing.Size(388, 36);
            this.textBoxGroupLabel.TabIndex = 0;
            this.textBoxGroupLabel.Text = "Введите номер добавляемой группы:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddGroup.Location = new System.Drawing.Point(3, 87);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(388, 36);
            this.buttonAddGroup.TabIndex = 2;
            this.buttonAddGroup.Text = "Добавить группу";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // textBoxStudentLabel
            // 
            this.textBoxStudentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentLabel.Location = new System.Drawing.Point(3, 129);
            this.textBoxStudentLabel.Multiline = true;
            this.textBoxStudentLabel.Name = "textBoxStudentLabel";
            this.textBoxStudentLabel.ReadOnly = true;
            this.textBoxStudentLabel.Size = new System.Drawing.Size(388, 57);
            this.textBoxStudentLabel.TabIndex = 3;
            this.textBoxStudentLabel.Text = "Введите имя добавляемого студента:";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentName.Location = new System.Drawing.Point(3, 192);
            this.textBoxStudentName.Multiline = true;
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(388, 57);
            this.textBoxStudentName.TabIndex = 4;
            // 
            // textBoxStudentNumberGroupLabel
            // 
            this.textBoxStudentNumberGroupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentNumberGroupLabel.Location = new System.Drawing.Point(3, 255);
            this.textBoxStudentNumberGroupLabel.Multiline = true;
            this.textBoxStudentNumberGroupLabel.Name = "textBoxStudentNumberGroupLabel";
            this.textBoxStudentNumberGroupLabel.ReadOnly = true;
            this.textBoxStudentNumberGroupLabel.Size = new System.Drawing.Size(388, 57);
            this.textBoxStudentNumberGroupLabel.TabIndex = 5;
            this.textBoxStudentNumberGroupLabel.Text = "Введите номер группы студента:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddStudent.Location = new System.Drawing.Point(3, 381);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(388, 60);
            this.buttonAddStudent.TabIndex = 7;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // comboBoxGroupNumber
            // 
            this.comboBoxGroupNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxGroupNumber.FormattingEnabled = true;
            this.comboBoxGroupNumber.Location = new System.Drawing.Point(3, 318);
            this.comboBoxGroupNumber.Name = "comboBoxGroupNumber";
            this.comboBoxGroupNumber.Size = new System.Drawing.Size(388, 23);
            this.comboBoxGroupNumber.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.TextBox textBoxGroupLabel;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxStudentLabel;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentNumberGroupLabel;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ComboBox comboBoxGroupNumber;
    }
}

