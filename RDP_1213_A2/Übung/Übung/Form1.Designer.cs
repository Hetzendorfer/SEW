namespace Übung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.xmlSumPatientenTextBox = new System.Windows.Forms.TextBox();
            this.xmlSumBehandlungTextBox = new System.Windows.Forms.TextBox();
            this.xmlDifferentBehandlungTextBox = new System.Windows.Forms.TextBox();
            this.xml1BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.xml2BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.xmlMehr2BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.xmlSumTherapiezeitTextBox = new System.Windows.Forms.TextBox();
            this.sqlSumTherapiezeitTextBox = new System.Windows.Forms.TextBox();
            this.sqlMehr2BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.sql2BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.sql1BehandlungTextBox = new System.Windows.Forms.TextBox();
            this.sqlDifferentBehandlungTextBox = new System.Windows.Forms.TextBox();
            this.sqlSumBehandlungTextBox = new System.Windows.Forms.TextBox();
            this.sqlSumPatientenTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.transfer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anzahl Patienten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anzahl Behandlungen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "unterschiedliche Beh.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patienten mit 1er Beh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patienten mit 2 Beh.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patienten mit >2 Beh.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Summe Therapiezeit";
            // 
            // xmlSumPatientenTextBox
            // 
            this.xmlSumPatientenTextBox.Location = new System.Drawing.Point(185, 145);
            this.xmlSumPatientenTextBox.Name = "xmlSumPatientenTextBox";
            this.xmlSumPatientenTextBox.ReadOnly = true;
            this.xmlSumPatientenTextBox.Size = new System.Drawing.Size(46, 20);
            this.xmlSumPatientenTextBox.TabIndex = 7;
            // 
            // xmlSumBehandlungTextBox
            // 
            this.xmlSumBehandlungTextBox.Location = new System.Drawing.Point(185, 179);
            this.xmlSumBehandlungTextBox.Name = "xmlSumBehandlungTextBox";
            this.xmlSumBehandlungTextBox.ReadOnly = true;
            this.xmlSumBehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.xmlSumBehandlungTextBox.TabIndex = 8;
            // 
            // xmlDifferentBehandlungTextBox
            // 
            this.xmlDifferentBehandlungTextBox.Location = new System.Drawing.Point(185, 210);
            this.xmlDifferentBehandlungTextBox.Name = "xmlDifferentBehandlungTextBox";
            this.xmlDifferentBehandlungTextBox.ReadOnly = true;
            this.xmlDifferentBehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.xmlDifferentBehandlungTextBox.TabIndex = 9;
            // 
            // xml1BehandlungTextBox
            // 
            this.xml1BehandlungTextBox.Location = new System.Drawing.Point(185, 239);
            this.xml1BehandlungTextBox.Name = "xml1BehandlungTextBox";
            this.xml1BehandlungTextBox.ReadOnly = true;
            this.xml1BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.xml1BehandlungTextBox.TabIndex = 10;
            // 
            // xml2BehandlungTextBox
            // 
            this.xml2BehandlungTextBox.Location = new System.Drawing.Point(185, 272);
            this.xml2BehandlungTextBox.Name = "xml2BehandlungTextBox";
            this.xml2BehandlungTextBox.ReadOnly = true;
            this.xml2BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.xml2BehandlungTextBox.TabIndex = 11;
            // 
            // xmlMehr2BehandlungTextBox
            // 
            this.xmlMehr2BehandlungTextBox.Location = new System.Drawing.Point(185, 302);
            this.xmlMehr2BehandlungTextBox.Name = "xmlMehr2BehandlungTextBox";
            this.xmlMehr2BehandlungTextBox.ReadOnly = true;
            this.xmlMehr2BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.xmlMehr2BehandlungTextBox.TabIndex = 12;
            // 
            // xmlSumTherapiezeitTextBox
            // 
            this.xmlSumTherapiezeitTextBox.Location = new System.Drawing.Point(185, 327);
            this.xmlSumTherapiezeitTextBox.Name = "xmlSumTherapiezeitTextBox";
            this.xmlSumTherapiezeitTextBox.ReadOnly = true;
            this.xmlSumTherapiezeitTextBox.Size = new System.Drawing.Size(46, 20);
            this.xmlSumTherapiezeitTextBox.TabIndex = 13;
            // 
            // sqlSumTherapiezeitTextBox
            // 
            this.sqlSumTherapiezeitTextBox.Location = new System.Drawing.Point(344, 327);
            this.sqlSumTherapiezeitTextBox.Name = "sqlSumTherapiezeitTextBox";
            this.sqlSumTherapiezeitTextBox.ReadOnly = true;
            this.sqlSumTherapiezeitTextBox.Size = new System.Drawing.Size(46, 20);
            this.sqlSumTherapiezeitTextBox.TabIndex = 20;
            // 
            // sqlMehr2BehandlungTextBox
            // 
            this.sqlMehr2BehandlungTextBox.Location = new System.Drawing.Point(344, 302);
            this.sqlMehr2BehandlungTextBox.Name = "sqlMehr2BehandlungTextBox";
            this.sqlMehr2BehandlungTextBox.ReadOnly = true;
            this.sqlMehr2BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.sqlMehr2BehandlungTextBox.TabIndex = 19;
            // 
            // sql2BehandlungTextBox
            // 
            this.sql2BehandlungTextBox.Location = new System.Drawing.Point(344, 272);
            this.sql2BehandlungTextBox.Name = "sql2BehandlungTextBox";
            this.sql2BehandlungTextBox.ReadOnly = true;
            this.sql2BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.sql2BehandlungTextBox.TabIndex = 18;
            // 
            // sql1BehandlungTextBox
            // 
            this.sql1BehandlungTextBox.Location = new System.Drawing.Point(344, 239);
            this.sql1BehandlungTextBox.Name = "sql1BehandlungTextBox";
            this.sql1BehandlungTextBox.ReadOnly = true;
            this.sql1BehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.sql1BehandlungTextBox.TabIndex = 17;
            // 
            // sqlDifferentBehandlungTextBox
            // 
            this.sqlDifferentBehandlungTextBox.Location = new System.Drawing.Point(344, 210);
            this.sqlDifferentBehandlungTextBox.Name = "sqlDifferentBehandlungTextBox";
            this.sqlDifferentBehandlungTextBox.ReadOnly = true;
            this.sqlDifferentBehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.sqlDifferentBehandlungTextBox.TabIndex = 16;
            // 
            // sqlSumBehandlungTextBox
            // 
            this.sqlSumBehandlungTextBox.Location = new System.Drawing.Point(344, 179);
            this.sqlSumBehandlungTextBox.Name = "sqlSumBehandlungTextBox";
            this.sqlSumBehandlungTextBox.ReadOnly = true;
            this.sqlSumBehandlungTextBox.Size = new System.Drawing.Size(46, 20);
            this.sqlSumBehandlungTextBox.TabIndex = 15;
            // 
            // sqlSumPatientenTextBox
            // 
            this.sqlSumPatientenTextBox.Location = new System.Drawing.Point(344, 145);
            this.sqlSumPatientenTextBox.Name = "sqlSumPatientenTextBox";
            this.sqlSumPatientenTextBox.ReadOnly = true;
            this.sqlSumPatientenTextBox.Size = new System.Drawing.Size(46, 20);
            this.sqlSumPatientenTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "XML";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "SQL";
            // 
            // transfer
            // 
            this.transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.transfer.Location = new System.Drawing.Point(248, 113);
            this.transfer.Name = "transfer";
            this.transfer.Size = new System.Drawing.Size(75, 23);
            this.transfer.TabIndex = 23;
            this.transfer.Text = "Transfer";
            this.transfer.UseVisualStyleBackColor = true;
            this.transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "XML-Datei";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Öffnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Transfer.accb";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "DROP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.transfer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sqlSumTherapiezeitTextBox);
            this.Controls.Add(this.sqlMehr2BehandlungTextBox);
            this.Controls.Add(this.sql2BehandlungTextBox);
            this.Controls.Add(this.sql1BehandlungTextBox);
            this.Controls.Add(this.sqlDifferentBehandlungTextBox);
            this.Controls.Add(this.sqlSumBehandlungTextBox);
            this.Controls.Add(this.sqlSumPatientenTextBox);
            this.Controls.Add(this.xmlSumTherapiezeitTextBox);
            this.Controls.Add(this.xmlMehr2BehandlungTextBox);
            this.Controls.Add(this.xml2BehandlungTextBox);
            this.Controls.Add(this.xml1BehandlungTextBox);
            this.Controls.Add(this.xmlDifferentBehandlungTextBox);
            this.Controls.Add(this.xmlSumBehandlungTextBox);
            this.Controls.Add(this.xmlSumPatientenTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xmlSumPatientenTextBox;
        private System.Windows.Forms.TextBox xmlSumBehandlungTextBox;
        private System.Windows.Forms.TextBox xmlDifferentBehandlungTextBox;
        private System.Windows.Forms.TextBox xml1BehandlungTextBox;
        private System.Windows.Forms.TextBox xml2BehandlungTextBox;
        private System.Windows.Forms.TextBox xmlMehr2BehandlungTextBox;
        private System.Windows.Forms.TextBox xmlSumTherapiezeitTextBox;
        private System.Windows.Forms.TextBox sqlSumTherapiezeitTextBox;
        private System.Windows.Forms.TextBox sqlMehr2BehandlungTextBox;
        private System.Windows.Forms.TextBox sql2BehandlungTextBox;
        private System.Windows.Forms.TextBox sql1BehandlungTextBox;
        private System.Windows.Forms.TextBox sqlDifferentBehandlungTextBox;
        private System.Windows.Forms.TextBox sqlSumBehandlungTextBox;
        private System.Windows.Forms.TextBox sqlSumPatientenTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button transfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button2;
    }
}

