namespace Student_Information_Management.Presentation_Layer
{
    partial class Module
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtModule = new TextBox();
            txtModuleName = new TextBox();
            txtModuleDesc = new TextBox();
            txtModuleLinks = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 96);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 0;
            label1.Text = "ModuleCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 207);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 1;
            label2.Text = "ModuleName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(139, 333);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 2;
            label3.Text = "ModuleDescription";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 478);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 3;
            label4.Text = "ModuleLinks";
            label4.Click += label4_Click;
            // 
            // txtModule
            // 
            txtModule.Location = new Point(381, 90);
            txtModule.Margin = new Padding(6, 6, 6, 6);
            txtModule.Name = "txtModule";
            txtModule.Size = new Size(349, 39);
            txtModule.TabIndex = 4;
            // 
            // txtModuleName
            // 
            txtModuleName.Location = new Point(381, 207);
            txtModuleName.Margin = new Padding(6, 6, 6, 6);
            txtModuleName.Name = "txtModuleName";
            txtModuleName.Size = new Size(349, 39);
            txtModuleName.TabIndex = 5;
            // 
            // txtModuleDesc
            // 
            txtModuleDesc.Location = new Point(381, 326);
            txtModuleDesc.Margin = new Padding(6, 6, 6, 6);
            txtModuleDesc.Name = "txtModuleDesc";
            txtModuleDesc.Size = new Size(349, 39);
            txtModuleDesc.TabIndex = 6;
            // 
            // txtModuleLinks
            // 
            txtModuleLinks.Location = new Point(381, 471);
            txtModuleLinks.Margin = new Padding(6, 6, 6, 6);
            txtModuleLinks.Name = "txtModuleLinks";
            txtModuleLinks.Size = new Size(349, 39);
            txtModuleLinks.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(381, 604);
            button1.Margin = new Padding(6, 6, 6, 6);
            button1.Name = "button1";
            button1.Size = new Size(254, 49);
            button1.TabIndex = 8;
            button1.Text = "Add Module";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(768, 604);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(254, 49);
            button2.TabIndex = 9;
            button2.Text = "Update Module";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Module
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtModuleLinks);
            Controls.Add(txtModuleDesc);
            Controls.Add(txtModuleName);
            Controls.Add(txtModule);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Module";
            Text = "Module";
            Load += Module_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtModule;
        private TextBox txtModuleName;
        private TextBox txtModuleDesc;
        private TextBox txtModuleLinks;
        private Button button1;
        private Button button2;
    }
}