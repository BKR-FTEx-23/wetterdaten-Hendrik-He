namespace WetterdatenHeHe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.btnEinlesenDatei = new System.Windows.Forms.Button();
            this.btnSpeichernDatei = new System.Windows.Forms.Button();
            this.btnAuswerten = new System.Windows.Forms.Button();
            this.btnSpeichernEingabe = new System.Windows.Forms.Button();
            this.txtLuftfEingabe = new System.Windows.Forms.TextBox();
            this.txtTempEingabe = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblDurchschnittTemp = new System.Windows.Forms.Label();
            this.lblDurchschnittLuft = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lbl0bis10 = new System.Windows.Forms.Label();
            this.lbl10bis20 = new System.Windows.Forms.Label();
            this.lbl20bis30 = new System.Windows.Forms.Label();
            this.lblTageLuft = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSpeichernDatei);
            this.groupBox1.Controls.Add(this.btnEinlesenDatei);
            this.groupBox1.Location = new System.Drawing.Point(40, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dateioperation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl2);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.DateTimePicker);
            this.groupBox2.Controls.Add(this.txtTempEingabe);
            this.groupBox2.Controls.Add(this.txtLuftfEingabe);
            this.groupBox2.Controls.Add(this.btnSpeichernEingabe);
            this.groupBox2.Location = new System.Drawing.Point(40, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dateneingabe";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTageLuft);
            this.groupBox3.Controls.Add(this.lbl20bis30);
            this.groupBox3.Controls.Add(this.lbl10bis20);
            this.groupBox3.Controls.Add(this.lbl0bis10);
            this.groupBox3.Controls.Add(this.lblMaxTemp);
            this.groupBox3.Controls.Add(this.lblMinTemp);
            this.groupBox3.Controls.Add(this.lblDurchschnittLuft);
            this.groupBox3.Controls.Add(this.lblDurchschnittTemp);
            this.groupBox3.Controls.Add(this.btnAuswerten);
            this.groupBox3.Location = new System.Drawing.Point(345, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 466);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auswertung";
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(709, 27);
            this.txtAusgabe.Multiline = true;
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.Size = new System.Drawing.Size(457, 466);
            this.txtAusgabe.TabIndex = 3;
            // 
            // btnEinlesenDatei
            // 
            this.btnEinlesenDatei.Location = new System.Drawing.Point(25, 39);
            this.btnEinlesenDatei.Name = "btnEinlesenDatei";
            this.btnEinlesenDatei.Size = new System.Drawing.Size(235, 57);
            this.btnEinlesenDatei.TabIndex = 0;
            this.btnEinlesenDatei.Text = "Einlesen Datei";
            this.btnEinlesenDatei.UseVisualStyleBackColor = true;
            this.btnEinlesenDatei.Click += new System.EventHandler(this.btnEinlesenDatei_Click);
            // 
            // btnSpeichernDatei
            // 
            this.btnSpeichernDatei.Location = new System.Drawing.Point(25, 117);
            this.btnSpeichernDatei.Name = "btnSpeichernDatei";
            this.btnSpeichernDatei.Size = new System.Drawing.Size(235, 57);
            this.btnSpeichernDatei.TabIndex = 1;
            this.btnSpeichernDatei.Text = "Speicheren Datei";
            this.btnSpeichernDatei.UseVisualStyleBackColor = true;
            this.btnSpeichernDatei.Click += new System.EventHandler(this.btnSpeichernDatei_Click);
            // 
            // btnAuswerten
            // 
            this.btnAuswerten.Location = new System.Drawing.Point(80, 403);
            this.btnAuswerten.Name = "btnAuswerten";
            this.btnAuswerten.Size = new System.Drawing.Size(178, 57);
            this.btnAuswerten.TabIndex = 2;
            this.btnAuswerten.Text = "Auswerten";
            this.btnAuswerten.UseVisualStyleBackColor = true;
            this.btnAuswerten.Click += new System.EventHandler(this.btnAuswerten_Click);
            // 
            // btnSpeichernEingabe
            // 
            this.btnSpeichernEingabe.Location = new System.Drawing.Point(25, 218);
            this.btnSpeichernEingabe.Name = "btnSpeichernEingabe";
            this.btnSpeichernEingabe.Size = new System.Drawing.Size(178, 42);
            this.btnSpeichernEingabe.TabIndex = 4;
            this.btnSpeichernEingabe.Text = "Speichern";
            this.btnSpeichernEingabe.UseVisualStyleBackColor = true;
            this.btnSpeichernEingabe.Click += new System.EventHandler(this.btnSpeichernEingabe_Click);
            // 
            // txtLuftfEingabe
            // 
            this.txtLuftfEingabe.Location = new System.Drawing.Point(213, 157);
            this.txtLuftfEingabe.Multiline = true;
            this.txtLuftfEingabe.Name = "txtLuftfEingabe";
            this.txtLuftfEingabe.Size = new System.Drawing.Size(52, 39);
            this.txtLuftfEingabe.TabIndex = 6;
            // 
            // txtTempEingabe
            // 
            this.txtTempEingabe.Location = new System.Drawing.Point(213, 112);
            this.txtTempEingabe.Multiline = true;
            this.txtTempEingabe.Name = "txtTempEingabe";
            this.txtTempEingabe.Size = new System.Drawing.Size(52, 39);
            this.txtTempEingabe.TabIndex = 7;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(6, 41);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(254, 29);
            this.DateTimePicker.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(25, 112);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(153, 25);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Temperatur [C°]";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 157);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(177, 25);
            this.lbl2.TabIndex = 10;
            this.lbl2.Text = "Luftfeuchtigkeit [%]";
            // 
            // lblDurchschnittTemp
            // 
            this.lblDurchschnittTemp.AutoSize = true;
            this.lblDurchschnittTemp.Location = new System.Drawing.Point(7, 39);
            this.lblDurchschnittTemp.Name = "lblDurchschnittTemp";
            this.lblDurchschnittTemp.Size = new System.Drawing.Size(219, 25);
            this.lblDurchschnittTemp.TabIndex = 3;
            this.lblDurchschnittTemp.Text = "Durchschnitttemperatur:";
            // 
            // lblDurchschnittLuft
            // 
            this.lblDurchschnittLuft.AutoSize = true;
            this.lblDurchschnittLuft.Location = new System.Drawing.Point(7, 64);
            this.lblDurchschnittLuft.Name = "lblDurchschnittLuft";
            this.lblDurchschnittLuft.Size = new System.Drawing.Size(264, 25);
            this.lblDurchschnittLuft.TabIndex = 4;
            this.lblDurchschnittLuft.Text = "Durchschnittsluftfeuchtigkeit: ";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(7, 89);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(178, 25);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "Minimaltemperatur:";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(7, 117);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(184, 25);
            this.lblMaxTemp.TabIndex = 6;
            this.lblMaxTemp.Text = "Maximaltemperatur:";
            // 
            // lbl0bis10
            // 
            this.lbl0bis10.AutoSize = true;
            this.lbl0bis10.Location = new System.Drawing.Point(7, 169);
            this.lbl0bis10.Name = "lbl0bis10";
            this.lbl0bis10.Size = new System.Drawing.Size(132, 25);
            this.lbl0bis10.TabIndex = 7;
            this.lbl0bis10.Text = "0-10°C Tage:";
            // 
            // lbl10bis20
            // 
            this.lbl10bis20.AutoSize = true;
            this.lbl10bis20.Location = new System.Drawing.Point(7, 194);
            this.lbl10bis20.Name = "lbl10bis20";
            this.lbl10bis20.Size = new System.Drawing.Size(143, 25);
            this.lbl10bis20.TabIndex = 8;
            this.lbl10bis20.Text = "10-20°C Tage:";
            // 
            // lbl20bis30
            // 
            this.lbl20bis30.AutoSize = true;
            this.lbl20bis30.Location = new System.Drawing.Point(6, 219);
            this.lbl20bis30.Name = "lbl20bis30";
            this.lbl20bis30.Size = new System.Drawing.Size(143, 25);
            this.lbl20bis30.TabIndex = 9;
            this.lbl20bis30.Text = "20-30°C Tage:";
            // 
            // lblTageLuft
            // 
            this.lblTageLuft.AutoSize = true;
            this.lblTageLuft.Location = new System.Drawing.Point(7, 255);
            this.lblTageLuft.Name = "lblTageLuft";
            this.lblTageLuft.Size = new System.Drawing.Size(286, 25);
            this.lblTageLuft.TabIndex = 10;
            this.lblTageLuft.Text = "Tage mit Luftfeuchtigkeit >79%:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 558);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpeichernDatei;
        private System.Windows.Forms.Button btnEinlesenDatei;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAuswerten;
        private System.Windows.Forms.TextBox txtAusgabe;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox txtTempEingabe;
        private System.Windows.Forms.TextBox txtLuftfEingabe;
        private System.Windows.Forms.Button btnSpeichernEingabe;
        private System.Windows.Forms.Label lblTageLuft;
        private System.Windows.Forms.Label lbl20bis30;
        private System.Windows.Forms.Label lbl10bis20;
        private System.Windows.Forms.Label lbl0bis10;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblDurchschnittLuft;
        private System.Windows.Forms.Label lblDurchschnittTemp;
    }
}

