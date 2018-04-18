namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.frage = new System.Windows.Forms.Label();
            this.antwort1 = new System.Windows.Forms.Label();
            this.antwort2 = new System.Windows.Forms.Label();
            this.antwort3 = new System.Windows.Forms.Label();
            this.antwort4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(165, 247);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(123, 34);
            this.start.TabIndex = 0;
            this.start.Text = "Start a Game";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // frage
            // 
            this.frage.AutoSize = true;
            this.frage.Location = new System.Drawing.Point(52, 34);
            this.frage.Name = "frage";
            this.frage.Size = new System.Drawing.Size(34, 13);
            this.frage.TabIndex = 1;
            this.frage.Text = "Frage";
            // 
            // antwort1
            // 
            this.antwort1.AutoSize = true;
            this.antwort1.Location = new System.Drawing.Point(105, 76);
            this.antwort1.Name = "antwort1";
            this.antwort1.Size = new System.Drawing.Size(48, 13);
            this.antwort1.TabIndex = 2;
            this.antwort1.Text = "antwort1";
            this.antwort1.Click += new System.EventHandler(this.antwort1_Click);
            // 
            // antwort2
            // 
            this.antwort2.AutoSize = true;
            this.antwort2.Location = new System.Drawing.Point(105, 100);
            this.antwort2.Name = "antwort2";
            this.antwort2.Size = new System.Drawing.Size(48, 13);
            this.antwort2.TabIndex = 3;
            this.antwort2.Text = "antwort2";
            this.antwort2.Click += new System.EventHandler(this.antwort2_Click);
            // 
            // antwort3
            // 
            this.antwort3.AutoSize = true;
            this.antwort3.Location = new System.Drawing.Point(105, 126);
            this.antwort3.Name = "antwort3";
            this.antwort3.Size = new System.Drawing.Size(48, 13);
            this.antwort3.TabIndex = 4;
            this.antwort3.Text = "antwort3";
            this.antwort3.Click += new System.EventHandler(this.antwort3_Click);
            // 
            // antwort4
            // 
            this.antwort4.AutoSize = true;
            this.antwort4.Location = new System.Drawing.Point(105, 154);
            this.antwort4.Name = "antwort4";
            this.antwort4.Size = new System.Drawing.Size(48, 13);
            this.antwort4.TabIndex = 5;
            this.antwort4.Text = "antwort4";
            this.antwort4.Click += new System.EventHandler(this.antwort4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 362);
            this.Controls.Add(this.antwort4);
            this.Controls.Add(this.antwort3);
            this.Controls.Add(this.antwort2);
            this.Controls.Add(this.antwort1);
            this.Controls.Add(this.frage);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label frage;
        private System.Windows.Forms.Label antwort1;
        private System.Windows.Forms.Label antwort2;
        private System.Windows.Forms.Label antwort3;
        private System.Windows.Forms.Label antwort4;
    }
}

