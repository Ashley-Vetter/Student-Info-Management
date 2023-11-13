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
            SuspendLayout();
            // 
            // btnDelStu
            // 
            btnDelStu.Location = new Point(681, 118);
            btnDelStu.Name = "btnDelStu";
            btnDelStu.Size = new Size(189, 46);
            btnDelStu.TabIndex = 0;
            btnDelStu.Text = "Delete Student";
            btnDelStu.UseVisualStyleBackColor = true;
            btnDelStu.Click += btnDelStu_Click;
            // 
            // btnDelMod
            // 
            btnDelMod.Location = new Point(681, 221);
            btnDelMod.Name = "btnDelMod";
            btnDelMod.Size = new Size(189, 46);
            btnDelMod.TabIndex = 1;
            btnDelMod.Text = "Delete Module";
            btnDelMod.UseVisualStyleBackColor = true;
            // 
            // tbxDelStu
            // 
            tbxDelStu.Location = new Point(338, 118);
            tbxDelStu.Name = "tbxDelStu";
            tbxDelStu.Size = new Size(319, 39);
            tbxDelStu.TabIndex = 2;
            // 
            // tbxDelMod
            // 
            tbxDelMod.Location = new Point(338, 221);
            tbxDelMod.Name = "tbxDelMod";
            tbxDelMod.Size = new Size(319, 39);
            tbxDelMod.TabIndex = 3;
            // 
            // lblDelStuNum
            // 
            lblDelStuNum.AutoSize = true;
            lblDelStuNum.Location = new Point(73, 121);
            lblDelStuNum.Name = "lblDelStuNum";
            lblDelStuNum.Size = new Size(259, 32);
            lblDelStuNum.TabIndex = 4;
            lblDelStuNum.Text = "Enter Student Number:";
            // 
            // lblDelModCode
            // 
            lblDelModCode.AutoSize = true;
            lblDelModCode.Location = new Point(73, 224);
            lblDelModCode.Name = "lblDelModCode";
            lblDelModCode.Size = new Size(227, 32);
            lblDelModCode.TabIndex = 5;
            lblDelModCode.Text = "Enter Module Code:";
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 350);
            Controls.Add(lblDelModCode);
            Controls.Add(lblDelStuNum);
            Controls.Add(tbxDelMod);
            Controls.Add(tbxDelStu);
            Controls.Add(btnDelMod);
            Controls.Add(btnDelStu);
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
    }
}