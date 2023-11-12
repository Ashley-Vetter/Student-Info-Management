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
            lblDelStuNum = new Label();
            lblDelModNum = new Label();
            tbxDelStu = new TextBox();
            tbxDelMod = new TextBox();
            btnDelStu = new Button();
            btnDelMod = new Button();
            SuspendLayout();
            // 
            // lblDelStuNum
            // 
            lblDelStuNum.AutoSize = true;
            lblDelStuNum.Location = new Point(91, 89);
            lblDelStuNum.Name = "lblDelStuNum";
            lblDelStuNum.Size = new Size(128, 15);
            lblDelStuNum.TabIndex = 0;
            lblDelStuNum.Text = "Enter Student Number:";
            // 
            // lblDelModNum
            // 
            lblDelModNum.AutoSize = true;
            lblDelModNum.Location = new Point(91, 169);
            lblDelModNum.Name = "lblDelModNum";
            lblDelModNum.Size = new Size(128, 15);
            lblDelModNum.TabIndex = 1;
            lblDelModNum.Text = "Enter Module Number:";
            // 
            // tbxDelStu
            // 
            tbxDelStu.Location = new Point(309, 86);
            tbxDelStu.Name = "tbxDelStu";
            tbxDelStu.Size = new Size(117, 23);
            tbxDelStu.TabIndex = 2;
            // 
            // tbxDelMod
            // 
            tbxDelMod.Location = new Point(309, 166);
            tbxDelMod.Name = "tbxDelMod";
            tbxDelMod.Size = new Size(117, 23);
            tbxDelMod.TabIndex = 3;
            // 
            // btnDelStu
            // 
            btnDelStu.Location = new Point(450, 86);
            btnDelStu.Name = "btnDelStu";
            btnDelStu.Size = new Size(96, 23);
            btnDelStu.TabIndex = 4;
            btnDelStu.Text = "Delete Student";
            btnDelStu.UseVisualStyleBackColor = true;
            btnDelStu.Click += btnDelStu_Click;
            // 
            // btnDelMod
            // 
            btnDelMod.Location = new Point(450, 166);
            btnDelMod.Name = "btnDelMod";
            btnDelMod.Size = new Size(96, 23);
            btnDelMod.TabIndex = 5;
            btnDelMod.Text = "Delete Module";
            btnDelMod.UseVisualStyleBackColor = true;
            btnDelMod.Click += btnDelMod_Click;
            // 
            // Delete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 214);
            Controls.Add(btnDelMod);
            Controls.Add(btnDelStu);
            Controls.Add(tbxDelMod);
            Controls.Add(tbxDelStu);
            Controls.Add(lblDelModNum);
            Controls.Add(lblDelStuNum);
            Name = "Delete";
            Text = "Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDelStuNum;
        private Label lblDelModNum;
        private TextBox tbxDelStu;
        private TextBox tbxDelMod;
        private Button btnDelStu;
        private Button btnDelMod;
    }
}