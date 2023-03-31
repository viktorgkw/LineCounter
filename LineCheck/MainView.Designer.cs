namespace LineCheck
{
    partial class MainView
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnSelect = new Button();
            lblResult = new Label();
            checkMarkdown = new CheckBox();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.MediumOrchid;
            btnSelect.Location = new Point(128, 197);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(240, 50);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select Directory";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(12, 9);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(460, 114);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result will be shown here.";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // checkMarkdown
            // 
            checkMarkdown.BackColor = Color.Transparent;
            checkMarkdown.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            checkMarkdown.ForeColor = Color.White;
            checkMarkdown.Location = new Point(128, 126);
            checkMarkdown.Name = "checkMarkdown";
            checkMarkdown.Size = new Size(240, 49);
            checkMarkdown.TabIndex = 2;
            checkMarkdown.Text = "Include Markdown Files?";
            checkMarkdown.UseVisualStyleBackColor = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 259);
            Controls.Add(checkMarkdown);
            Controls.Add(lblResult);
            Controls.Add(btnSelect);
            Name = "MainView";
            Text = "LineCheck";
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnSelect;
        private Label lblResult;
        private CheckBox checkMarkdown;
    }
}