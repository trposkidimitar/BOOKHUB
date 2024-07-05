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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAboutUS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBiblioteka
            // 
            this.btnBiblioteka.BackColor = System.Drawing.Color.Gray;
            this.btnBiblioteka.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBiblioteka.ForeColor = System.Drawing.Color.Black;
            this.btnBiblioteka.Image = ((System.Drawing.Image)(resources.GetObject("btnBiblioteka.Image")));
            this.btnBiblioteka.Location = new System.Drawing.Point(97, 169);
            this.btnBiblioteka.Name = "btnBiblioteka";
            this.btnBiblioteka.Size = new System.Drawing.Size(230, 200);
            this.btnBiblioteka.TabIndex = 0;
            this.btnBiblioteka.Text = "Library";
            this.btnBiblioteka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBiblioteka.UseVisualStyleBackColor = false;
            this.btnBiblioteka.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(74, 30);
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
            this.btnGame.Location = new System.Drawing.Point(524, 169);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(230, 200);
            this.btnGame.TabIndex = 3;
            this.btnGame.Text = "Game";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnAboutUS);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.btnGame);
            this.panel1.Controls.Add(this.btnBiblioteka);
            this.panel1.Location = new System.Drawing.Point(206, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 501);
            this.panel1.TabIndex = 4;
            // 
            // btnAboutUS
            // 
            this.btnAboutUS.BackColor = System.Drawing.Color.Gray;
            this.btnAboutUS.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAboutUS.Location = new System.Drawing.Point(328, 374);
            this.btnAboutUS.Name = "btnAboutUS";
            this.btnAboutUS.Size = new System.Drawing.Size(194, 54);
            this.btnAboutUS.TabIndex = 5;
            this.btnAboutUS.Text = "About Us";
            this.btnAboutUS.UseVisualStyleBackColor = false;
            this.btnAboutUS.Click += new System.EventHandler(this.btnAboutUS_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(328, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 672);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1280, 719);
            this.MinimumSize = new System.Drawing.Size(1280, 719);
            this.Name = "MenuForm";
            this.Text = "BookHub";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBiblioteka;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAboutUS;
    }
}