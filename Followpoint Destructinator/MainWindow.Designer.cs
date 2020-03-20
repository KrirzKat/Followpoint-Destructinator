namespace Followpoint_Destructinator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DirectoryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilepathButton = new System.Windows.Forms.Button();
            this.osuSkin = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.unpackedBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(226, 9);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(562, 47);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete!";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DirectoryBox
            // 
            this.DirectoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryBox.Location = new System.Drawing.Point(12, 32);
            this.DirectoryBox.Name = "DirectoryBox";
            this.DirectoryBox.Size = new System.Drawing.Size(177, 24);
            this.DirectoryBox.TabIndex = 1;
            this.DirectoryBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destructinator!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FilepathButton
            // 
            this.FilepathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilepathButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilepathButton.Location = new System.Drawing.Point(195, 32);
            this.FilepathButton.Name = "FilepathButton";
            this.FilepathButton.Size = new System.Drawing.Size(25, 24);
            this.FilepathButton.TabIndex = 3;
            this.FilepathButton.Text = "...";
            this.FilepathButton.UseVisualStyleBackColor = true;
            this.FilepathButton.Click += new System.EventHandler(this.FilepathButton_Click);
            // 
            // osuSkin
            // 
            this.osuSkin.CheckFileExists = false;
            this.osuSkin.Multiselect = true;
            this.osuSkin.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1000, 637);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // unpackedBox
            // 
            this.unpackedBox.AutoSize = true;
            this.unpackedBox.Location = new System.Drawing.Point(140, 9);
            this.unpackedBox.Name = "unpackedBox";
            this.unpackedBox.Size = new System.Drawing.Size(82, 17);
            this.unpackedBox.TabIndex = 5;
            this.unpackedBox.Text = "Unpacked?";
            this.unpackedBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unpackedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilepathButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectoryBox);
            this.Controls.Add(this.DeleteButton);
            this.Name = "Form1";
            this.Text = "Followpoint Destructinator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox DirectoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilepathButton;
        public System.Windows.Forms.OpenFileDialog osuSkin;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox unpackedBox;
    }
}

