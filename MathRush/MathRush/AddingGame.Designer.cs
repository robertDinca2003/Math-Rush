namespace MathRush
{
    partial class AddingGame
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
            this.components = new System.ComponentModel.Container();
            this.Submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Label();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultsum = new System.Windows.Forms.TextBox();
            this.answerText = new System.Windows.Forms.TextBox();
            this.firstelem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.surrender = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkCyan;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.MintCream;
            this.Submit.Location = new System.Drawing.Point(669, 457);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(304, 107);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.surrender);
            this.panel1.Controls.Add(this.Timer);
            this.panel1.Controls.Add(this.Scorelabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.resultsum);
            this.panel1.Controls.Add(this.answerText);
            this.panel1.Controls.Add(this.firstelem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 664);
            this.panel1.TabIndex = 1;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.DarkCyan;
            this.Timer.Location = new System.Drawing.Point(558, 155);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(400, 84);
            this.Timer.TabIndex = 8;
            this.Timer.Text = "Time Left:  00:15";
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.Scorelabel.Location = new System.Drawing.Point(31, 155);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(224, 84);
            this.Scorelabel.TabIndex = 7;
            this.Scorelabel.Text = "Score: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 84);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adding Game";
            // 
            // resultsum
            // 
            this.resultsum.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsum.Location = new System.Drawing.Point(755, 298);
            this.resultsum.Name = "resultsum";
            this.resultsum.ReadOnly = true;
            this.resultsum.Size = new System.Drawing.Size(218, 91);
            this.resultsum.TabIndex = 5;
            this.resultsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerText
            // 
            this.answerText.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerText.Location = new System.Drawing.Point(402, 298);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(218, 91);
            this.answerText.TabIndex = 4;
            this.answerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstelem
            // 
            this.firstelem.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstelem.Location = new System.Drawing.Point(45, 298);
            this.firstelem.Name = "firstelem";
            this.firstelem.ReadOnly = true;
            this.firstelem.Size = new System.Drawing.Size(218, 91);
            this.firstelem.TabIndex = 3;
            this.firstelem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(617, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 253);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(259, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 253);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // t
            // 
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // surrender
            // 
            this.surrender.BackColor = System.Drawing.Color.DarkCyan;
            this.surrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surrender.ForeColor = System.Drawing.Color.MintCream;
            this.surrender.Location = new System.Drawing.Point(45, 457);
            this.surrender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surrender.Name = "surrender";
            this.surrender.Size = new System.Drawing.Size(304, 107);
            this.surrender.TabIndex = 9;
            this.surrender.Text = "Surrender";
            this.surrender.UseVisualStyleBackColor = false;
            this.surrender.Click += new System.EventHandler(this.surrender_Click);
            // 
            // AddingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "AddingGame";
            this.Text = "AddingGame";
            this.Load += new System.EventHandler(this.AddingGame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox firstelem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultsum;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.Button surrender;
    }
}