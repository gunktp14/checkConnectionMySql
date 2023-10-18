namespace checkConnectionMysql
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
            btnCheck = new Button();
            IblSuccess = new Label();
            IblError = new Label();
            SuspendLayout();
            // 
            // btnCheck_Click
            // 
            btnCheck.Location = new Point(110, 32);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(185, 65);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "CHECK !";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // IblSuccess
            // 
            IblSuccess.AutoSize = true;
            IblSuccess.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IblSuccess.ForeColor = Color.ForestGreen;
            IblSuccess.Location = new Point(164, 128);
            IblSuccess.Name = "IblSuccess";
            IblSuccess.Size = new Size(73, 22);
            IblSuccess.TabIndex = 2;
            IblSuccess.Text = "Success!";
            IblSuccess.Click += label1_Click;
            // 
            // IblError
            // 
            IblError.AutoSize = true;
            IblError.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            IblError.ForeColor = Color.Red;
            IblError.Location = new Point(135, 128);
            IblError.Name = "IblError";
            IblError.Size = new Size(129, 22);
            IblError.TabIndex = 3;
            IblError.Text = "Error to connect!";
            IblError.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 201);
            Controls.Add(IblError);
            Controls.Add(IblSuccess);
            Controls.Add(btnCheck);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection MYSQL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCheck;
        private Label IblSuccess;
        private Label IblError;
    }
}