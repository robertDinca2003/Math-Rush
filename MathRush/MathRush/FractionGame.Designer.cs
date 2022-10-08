namespace MathRush
{
    partial class FractionGame
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
            this.surrender = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.fractionlabel = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.resultsum = new System.Windows.Forms.TextBox();
            this.answerText = new System.Windows.Forms.TextBox();
            this.firstelem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.scndelem = new System.Windows.Forms.TextBox();
            this.scndanswertxt = new System.Windows.Forms.TextBox();
            this.scndresultsum = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // surrender
            // 
            this.surrender.BackColor = System.Drawing.Color.DarkCyan;
            this.surrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surrender.ForeColor = System.Drawing.Color.MintCream;
            this.surrender.Location = new System.Drawing.Point(60, 519);
            this.surrender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surrender.Name = "surrender";
            this.surrender.Size = new System.Drawing.Size(304, 107);
            this.surrender.TabIndex = 19;
            this.surrender.Text = "Surrender";
            this.surrender.UseVisualStyleBackColor = false;
            this.surrender.Click += new System.EventHandler(this.surrender_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.ForeColor = System.Drawing.Color.DarkCyan;
            this.Timer.Location = new System.Drawing.Point(573, 147);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(400, 84);
            this.Timer.TabIndex = 18;
            this.Timer.Text = "Time Left:  00:15";
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.Scorelabel.Location = new System.Drawing.Point(46, 147);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(224, 84);
            this.Scorelabel.TabIndex = 17;
            this.Scorelabel.Text = "Score: 0";
            // 
            // fractionlabel
            // 
            this.fractionlabel.AutoSize = true;
            this.fractionlabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fractionlabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.fractionlabel.Location = new System.Drawing.Point(46, 34);
            this.fractionlabel.Name = "fractionlabel";
            this.fractionlabel.Size = new System.Drawing.Size(390, 84);
            this.fractionlabel.TabIndex = 16;
            this.fractionlabel.Text = "Fraction Game";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkCyan;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.MintCream;
            this.Submit.Location = new System.Drawing.Point(709, 519);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(304, 107);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // resultsum
            // 
            this.resultsum.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsum.Location = new System.Drawing.Point(795, 234);
            this.resultsum.Name = "resultsum";
            this.resultsum.ReadOnly = true;
            this.resultsum.Size = new System.Drawing.Size(218, 91);
            this.resultsum.TabIndex = 15;
            this.resultsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answerText
            // 
            this.answerText.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerText.Location = new System.Drawing.Point(423, 234);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(218, 91);
            this.answerText.TabIndex = 14;
            this.answerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstelem
            // 
            this.firstelem.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstelem.Location = new System.Drawing.Point(60, 234);
            this.firstelem.Name = "firstelem";
            this.firstelem.ReadOnly = true;
            this.firstelem.Size = new System.Drawing.Size(218, 91);
            this.firstelem.TabIndex = 13;
            this.firstelem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(628, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 253);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(270, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 253);
            this.label1.TabIndex = 11;
            this.label1.Text = "*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(36, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 23);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(401, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 23);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(771, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 23);
            this.panel3.TabIndex = 21;
            // 
            // scndelem
            // 
            this.scndelem.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndelem.Location = new System.Drawing.Point(60, 386);
            this.scndelem.Name = "scndelem";
            this.scndelem.ReadOnly = true;
            this.scndelem.Size = new System.Drawing.Size(218, 91);
            this.scndelem.TabIndex = 22;
            this.scndelem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scndanswertxt
            // 
            this.scndanswertxt.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndanswertxt.Location = new System.Drawing.Point(423, 386);
            this.scndanswertxt.Name = "scndanswertxt";
            this.scndanswertxt.Size = new System.Drawing.Size(218, 91);
            this.scndanswertxt.TabIndex = 23;
            this.scndanswertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scndresultsum
            // 
            this.scndresultsum.Font = new System.Drawing.Font("Poppins", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scndresultsum.Location = new System.Drawing.Point(795, 386);
            this.scndresultsum.Name = "scndresultsum";
            this.scndresultsum.ReadOnly = true;
            this.scndresultsum.Size = new System.Drawing.Size(218, 91);
            this.scndresultsum.TabIndex = 24;
            this.scndresultsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // t
            // 
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // FractionGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.scndresultsum);
            this.Controls.Add(this.scndanswertxt);
            this.Controls.Add(this.scndelem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.surrender);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.Scorelabel);
            this.Controls.Add(this.fractionlabel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.resultsum);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.firstelem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "FractionGame";
            this.Text = "FractionGame";
            this.Load += new System.EventHandler(this.AddingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button surrender;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Label fractionlabel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox resultsum;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.TextBox firstelem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox scndelem;
        private System.Windows.Forms.TextBox scndanswertxt;
        private System.Windows.Forms.TextBox scndresultsum;
        private System.Windows.Forms.Timer t;
    }
}