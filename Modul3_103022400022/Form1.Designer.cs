namespace Modul3_103022400022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            cmbSatuanAkhir = new ComboBox();
            cmbSatuanAwal = new ComboBox();
            label5 = new Label();
            txtNilaiAwal = new TextBox();
            txtNilaiAkhir = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 95);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Satuan Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 95);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(309, 204);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 2;
            label3.Text = "Nilai Akhir";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 95);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Nilai Awal";
            // 
            // cmbSatuanAkhir
            // 
            cmbSatuanAkhir.FormattingEnabled = true;
            cmbSatuanAkhir.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Reamur" });
            cmbSatuanAkhir.Location = new Point(84, 242);
            cmbSatuanAkhir.Name = "cmbSatuanAkhir";
            cmbSatuanAkhir.Size = new Size(164, 33);
            cmbSatuanAkhir.TabIndex = 7;
            // 
            // cmbSatuanAwal
            // 
            cmbSatuanAwal.FormattingEnabled = true;
            cmbSatuanAwal.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Reamur" });
            cmbSatuanAwal.Location = new Point(84, 133);
            cmbSatuanAwal.Name = "cmbSatuanAwal";
            cmbSatuanAwal.Size = new Size(164, 33);
            cmbSatuanAwal.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 204);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 9;
            label5.Text = "Satuan Akhir";
            // 
            // txtNilaiAwal
            // 
            txtNilaiAwal.Location = new Point(309, 133);
            txtNilaiAwal.Name = "txtNilaiAwal";
            txtNilaiAwal.Size = new Size(223, 31);
            txtNilaiAwal.TabIndex = 10;
            // 
            // txtNilaiAkhir
            // 
            txtNilaiAkhir.Location = new Point(309, 244);
            txtNilaiAkhir.Name = "txtNilaiAkhir";
            txtNilaiAkhir.ReadOnly = true;
            txtNilaiAkhir.Size = new Size(223, 31);
            txtNilaiAkhir.TabIndex = 11;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(627, 133);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 34);
            btnConvert.TabIndex = 12;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConvert);
            Controls.Add(txtNilaiAkhir);
            Controls.Add(txtNilaiAwal);
            Controls.Add(label5);
            Controls.Add(cmbSatuanAwal);
            Controls.Add(cmbSatuanAkhir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "(Celcius, Fahrenheit, Kelvin, ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private ComboBox cmbSatuanAkhir;
        private ComboBox cmbSatuanAwal;
        private Label label5;
        private TextBox txtNilaiAwal;
        private TextBox txtNilaiAkhir;
        private Button btnConvert;
    }
}
