namespace Student_Information_Management.Presentation_Layer
{
    partial class Delete
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
            btnDelStu = new Button();
            btnDelMod = new Button();
            tbxDelStu = new TextBox();
            tbxDelMod = new TextBox();
            lblDelStuNum = new Label();
            lblDelModCode = new Label();
            btnToMain = new Button();
            SuspendLayout();
            // 
            // btnDelStu
            // 
            btnDelStu.Location = new Point(367, 55);
            btnDelStu.Margin = new Padding(2, 1, 2, 1);
            btnDelStu.Name = "btnDelStu";
            btnDelStu.Size = new Size(102, 22);
            btnDelStu.TabIndex = 0;
            btnDelStu.Text = "Delete Student";
            btnDelStu.UseVisualStyleBackColor = true;
            btnDelStu.Click += btnDelStu_Click;
            // 
            // btnDelMod
            // 
            btnDelMod.Location = new Point(367, 104);
            btnDelMod.Margin = new Padding(2, 1, 2, 1);
            btnDelMod.Name = "btnDelMod";
            btnDelMod.Size = new Size(102, 22);
            btnDelMod.TabIndex = 1;
            btnDelMod.Text = "Delete Module";
            btnDelMod.UseVisualStyleBackColor = true;
            btnDelMod.Click += btnDelMod_Click;
            // 
            // tbxDelStu
            // 
            tbxDelStu.Location = new Point(182, 55);
            tbxDelStu.Margin = new Padding(2, 1, 2, 1);
            tbxDelStu.Name = "tbxDelStu";
            tbxDelStu.Size = new Size(174, 23);
            tbxDelStu.TabIndex = 2;
            // 
            // tbxDelMod
            // 
            tbxDelMod.Location = new Point(182, 104);
            tbxDelMod.Margin = new Padding(2, 1, 2, 1);
            tbxDelMod.Name = "tbxDelMod";
            tbxDelMod.Size = new Size(174, 23);
            tbxDelMod.TabIndex = 3;
            // 
            // lblDelStuNum
            // 
            lblDelStuNum.AutoSize = true;
            lblDelStuNum.Location = new Point(39, 57);
            lblDelStuNum.Margin = new Padding(2, 0, 2, 0);
            lblDelStuNum.Name = "lblDelStuNum";
            lblDelStuNum.Size = new Size(128, 15);
            lblDelStuNum.TabIndex = 4;
            lblDelStuNum.Text = "Enter Student Number:";
            // 
            // lblDelModCode
            // 
            lblDelModCode.AutoSize = true;
            lblDelModCode.Location = new Point(39, 105);
            lblDelModCode.Margin = new Padding(2, 0, 2, 0);
            lblDelModCode.Name = "lblDelModCode";
            lblDelModCode.Size = new Size(112, 15);
            lblDelModCode.TabIndex = 5;
            lblDelModCode.Text = "Enter Module Code:";
            // 
            // btnToMain
            // 
            btnToMain.Location = new Point(210, 147);
            btnToMain.Name = "btnToMain";
            btnToMain.Size = new Size(117, 23);
            btnToMain.TabIndex = 6;
            btnToMain.Text = "Exit to Main Form";
            btnToMain.UseVisualStyleBackColor = true;
            btnToMain.Click += btnToMain_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 182);
            Controls.Add(btnToMain);
            Controls.Add(lblDelModCode);
            Controls.Add(lblDelStuNum);
            Controls.Add(tbxDelMod);
            Controls.Add(tbxDelStu);
            Controls.Add(btnDelMod);
            Controls.Add(btnDelStu);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelStu;
        private Button btnDelMod;
        private TextBox tbxDelStu;
        private TextBox tbxDelMod;
        private Label lblDelStuNum;
        private Label lblDelModCode;
        private Button btnToMain;
    }
}