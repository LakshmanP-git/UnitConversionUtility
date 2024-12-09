namespace UnitConversionUtility
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
            tbc_Volume = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            txt_Tons = new TextBox();
            txt_Kilos = new TextBox();
            txt_Pounds = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_Convert = new Button();
            tbc_Volume.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tbc_Volume
            // 
            tbc_Volume.Controls.Add(tabPage2);
            tbc_Volume.Controls.Add(tabPage1);
            tbc_Volume.Location = new Point(1, 1);
            tbc_Volume.Name = "tbc_Volume";
            tbc_Volume.SelectedIndex = 0;
            tbc_Volume.Size = new Size(369, 450);
            tbc_Volume.TabIndex = 7;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(361, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Volume";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_Tons);
            tabPage1.Controls.Add(txt_Kilos);
            tabPage1.Controls.Add(txt_Pounds);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btn_Convert);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(361, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Weight";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Tons
            // 
            txt_Tons.Location = new Point(147, 234);
            txt_Tons.Name = "txt_Tons";
            txt_Tons.Size = new Size(163, 23);
            txt_Tons.TabIndex = 13;
            // 
            // txt_Kilos
            // 
            txt_Kilos.Location = new Point(147, 149);
            txt_Kilos.Name = "txt_Kilos";
            txt_Kilos.Size = new Size(163, 23);
            txt_Kilos.TabIndex = 12;
            // 
            // txt_Pounds
            // 
            txt_Pounds.Location = new Point(147, 73);
            txt_Pounds.Name = "txt_Pounds";
            txt_Pounds.Size = new Size(163, 23);
            txt_Pounds.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(61, 226);
            label3.Name = "label3";
            label3.Size = new Size(43, 28);
            label3.TabIndex = 10;
            label3.Text = "Ton";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(61, 141);
            label2.Name = "label2";
            label2.Size = new Size(54, 28);
            label2.TabIndex = 9;
            label2.Text = "Kilos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 68);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 8;
            label1.Text = "Pounds";
            // 
            // btn_Convert
            // 
            btn_Convert.Font = new Font("Segoe UI", 13F);
            btn_Convert.Location = new Point(164, 312);
            btn_Convert.Name = "btn_Convert";
            btn_Convert.Size = new Size(109, 42);
            btn_Convert.TabIndex = 7;
            btn_Convert.Text = "Convert";
            btn_Convert.UseVisualStyleBackColor = true;
            btn_Convert.Click += btn_Convert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(tbc_Volume);
            Name = "Form1";
            Text = "Form1";
            tbc_Volume.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc_Volume;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TextBox txt_Tons;
        private TextBox txt_Kilos;
        private TextBox txt_Pounds;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Convert;
    }
}
