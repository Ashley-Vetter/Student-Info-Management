namespace Student_Information_Management.Presentation_Layer
{
    partial class DeleteForm
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
            lblEnterStudentNumber = new Label();
            txtEnterStudentNumber = new TextBox();
            btnDeleteStudent = new Button();
            btnDeleteModule = new Button();
            txtEnterModuleCode = new TextBox();
            label1 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // lblEnterStudentNumber
            // 
            lblEnterStudentNumber.AutoSize = true;
            lblEnterStudentNumber.Location = new Point(19, 30);
            lblEnterStudentNumber.Margin = new Padding(1, 0, 1, 0);
            lblEnterStudentNumber.Name = "lblEnterStudentNumber";
            lblEnterStudentNumber.Size = new Size(125, 15);
            lblEnterStudentNumber.TabIndex = 2;
            lblEnterStudentNumber.Text = "Enter Student Number";
            // 
            // txtEnterStudentNumber
            // 
            txtEnterStudentNumber.Location = new Point(157, 27);
            txtEnterStudentNumber.Margin = new Padding(1);
            txtEnterStudentNumber.Name = "txtEnterStudentNumber";
            txtEnterStudentNumber.Size = new Size(137, 23);
            txtEnterStudentNumber.TabIndex = 3;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(299, 18);
            btnDeleteStudent.Margin = new Padding(2, 1, 2, 1);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(117, 38);
            btnDeleteStudent.TabIndex = 51;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnDeleteModule
            // 
            btnDeleteModule.Location = new Point(299, 75);
            btnDeleteModule.Margin = new Padding(2, 1, 2, 1);
            btnDeleteModule.Name = "btnDeleteModule";
            btnDeleteModule.Size = new Size(117, 38);
            btnDeleteModule.TabIndex = 55;
            btnDeleteModule.Text = "Delete Module";
            btnDeleteModule.UseVisualStyleBackColor = true;
            btnDeleteModule.Click += btnDeleteModule_Click;
            // 
            // txtEnterModuleCode
            // 
            txtEnterModuleCode.Location = new Point(157, 84);
            txtEnterModuleCode.Margin = new Padding(1);
            txtEnterModuleCode.Name = "txtEnterModuleCode";
            txtEnterModuleCode.Size = new Size(137, 23);
            txtEnterModuleCode.TabIndex = 54;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 87);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 53;
            label1.Text = "Enter Module Code";
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(19, 125);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(213, 54);
            btnReturn.TabIndex = 56;
            btnReturn.Text = "Return to main form";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(427, 189);
            Controls.Add(btnReturn);
            Controls.Add(btnDeleteModule);
            Controls.Add(txtEnterModuleCode);
            Controls.Add(label1);
            Controls.Add(btnDeleteStudent);
            Controls.Add(txtEnterStudentNumber);
            Controls.Add(lblEnterStudentNumber);
            Margin = new Padding(1);
            Name = "DeleteForm";
            Text = "DeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblEnterStudentNumber;
        private TextBox txtEnterStudentNumber;
        private Button btnDeleteStudent;
        private Button btnDeleteModule;
        private TextBox txtEnterModuleCode;
        private Label label1;
        private Button btnReturn;
    }
}