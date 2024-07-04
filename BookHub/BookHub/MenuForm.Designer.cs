namespace BookHub
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnBiblioteka = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBiblioteka
            // 
            this.btnBiblioteka.BackColor = System.Drawing.Color.Gray;
            this.btnBiblioteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBiblioteka.ForeColor = System.Drawing.Color.Black;
            this.btnBiblioteka.Image = ((System.Drawing.Image)(resources.GetObject("btnBiblioteka.Image")));
            this.btnBiblioteka.Location = new System.Drawing.Point(322, 243);
            this.btnBiblioteka.Name = "btnBiblioteka";
            this.btnBiblioteka.Size = new System.Drawing.Size(230, 200);
            this.btnBiblioteka.TabIndex = 0;
            this.btnBiblioteka.Text = "Библиотека";
            this.btnBiblioteka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiblioteka.UseVisualStyleBackColor = false;
            this.btnBiblioteka.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblName.Location = new System.Drawing.Point(299, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(682, 136);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "BOOK HUB";
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Gray;
            this.btnGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGame.ForeColor = System.Drawing.Color.Black;
            this.btnGame.Image = ((System.Drawing.Image)(resources.GetObject("btnGame.Image")));
            this.btnGame.Location = new System.Drawing.Point(716, 243);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(230, 200);
            this.btnGame.TabIndex = 3;
            this.btnGame.Text = "Игра";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 672);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBiblioteka);
            this.Name = "MenuForm";
            this.Text = "BookHub";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBiblioteka;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGame;
    }
}