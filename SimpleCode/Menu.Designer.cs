namespace SimpleCode
{
    partial class Menu
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
            this.BStartGame = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.BHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BStartGame
            // 
            this.BStartGame.Location = new System.Drawing.Point(85, 46);
            this.BStartGame.Name = "BStartGame";
            this.BStartGame.Size = new System.Drawing.Size(111, 44);
            this.BStartGame.TabIndex = 0;
            this.BStartGame.Text = "Играть";
            this.BStartGame.UseVisualStyleBackColor = true;
            this.BStartGame.Click += new System.EventHandler(this.BStartGame_Click);
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(85, 223);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(111, 52);
            this.BExit.TabIndex = 1;
            this.BExit.Text = "Выход";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // BHelp
            // 
            this.BHelp.Location = new System.Drawing.Point(85, 131);
            this.BHelp.Name = "BHelp";
            this.BHelp.Size = new System.Drawing.Size(111, 52);
            this.BHelp.TabIndex = 2;
            this.BHelp.Text = "Инструкция";
            this.BHelp.UseVisualStyleBackColor = true;
            this.BHelp.Click += new System.EventHandler(this.BHelp_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 362);
            this.Controls.Add(this.BHelp);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BStartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BStartGame;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BHelp;
    }
}