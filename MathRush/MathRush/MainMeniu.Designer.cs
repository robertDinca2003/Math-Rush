namespace MathRush
{
    partial class MainMeniu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddingGame = new System.Windows.Forms.Button();
            this.btnSubstractingGame = new System.Windows.Forms.Button();
            this.btnFractionGame = new System.Windows.Forms.Button();
            this.PersonalRecords = new System.Data.DataSet();
            this.LstScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(311, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Rush";
            // 
            // btnAddingGame
            // 
            this.btnAddingGame.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAddingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddingGame.ForeColor = System.Drawing.Color.MintCream;
            this.btnAddingGame.Location = new System.Drawing.Point(312, 228);
            this.btnAddingGame.Name = "btnAddingGame";
            this.btnAddingGame.Size = new System.Drawing.Size(399, 94);
            this.btnAddingGame.TabIndex = 1;
            this.btnAddingGame.Text = "Adding Game";
            this.btnAddingGame.UseVisualStyleBackColor = false;
            this.btnAddingGame.Click += new System.EventHandler(this.btnAddingGame_Click);
            // 
            // btnSubstractingGame
            // 
            this.btnSubstractingGame.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSubstractingGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstractingGame.ForeColor = System.Drawing.Color.MintCream;
            this.btnSubstractingGame.Location = new System.Drawing.Point(312, 341);
            this.btnSubstractingGame.Name = "btnSubstractingGame";
            this.btnSubstractingGame.Size = new System.Drawing.Size(399, 94);
            this.btnSubstractingGame.TabIndex = 2;
            this.btnSubstractingGame.Text = "Substracting Game";
            this.btnSubstractingGame.UseVisualStyleBackColor = false;
            this.btnSubstractingGame.Click += new System.EventHandler(this.btnSubstractingGame_Click);
            // 
            // btnFractionGame
            // 
            this.btnFractionGame.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFractionGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFractionGame.ForeColor = System.Drawing.Color.MintCream;
            this.btnFractionGame.Location = new System.Drawing.Point(312, 452);
            this.btnFractionGame.Name = "btnFractionGame";
            this.btnFractionGame.Size = new System.Drawing.Size(399, 94);
            this.btnFractionGame.TabIndex = 3;
            this.btnFractionGame.Text = "Fraction Game";
            this.btnFractionGame.UseVisualStyleBackColor = false;
            this.btnFractionGame.Click += new System.EventHandler(this.btnFractionGame_Click);
            // 
            // PersonalRecords
            // 
            this.PersonalRecords.DataSetName = "Personalbests";
            // 
            // LstScore
            // 
            this.LstScore.AutoSize = true;
            this.LstScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstScore.ForeColor = System.Drawing.Color.DarkCyan;
            this.LstScore.Location = new System.Drawing.Point(317, 573);
            this.LstScore.Name = "LstScore";
            this.LstScore.Size = new System.Drawing.Size(262, 46);
            this.LstScore.TabIndex = 4;
            this.LstScore.Text = "Last score: 0";
            // 
            // MainMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.LstScore);
            this.Controls.Add(this.btnFractionGame);
            this.Controls.Add(this.btnSubstractingGame);
            this.Controls.Add(this.btnAddingGame);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainMeniu";
            this.Text = "Math Rush";
            ((System.ComponentModel.ISupportInitialize)(this.PersonalRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddingGame;
        private System.Windows.Forms.Button btnSubstractingGame;
        private System.Windows.Forms.Button btnFractionGame;
        private System.Data.DataSet PersonalRecords;
        private System.Windows.Forms.Label LstScore;
    }
}