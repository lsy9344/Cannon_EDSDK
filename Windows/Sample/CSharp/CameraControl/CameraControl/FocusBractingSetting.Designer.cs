namespace CameraControl
{
    partial class FocusBractingSetting
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
            this.focusBracketingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.focusIncrementComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exposureSmoothingComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxShtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // focusBracketingComboBox
            // 
            this.focusBracketingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.focusBracketingComboBox.FormattingEnabled = true;
            this.focusBracketingComboBox.Location = new System.Drawing.Point(23, 43);
            this.focusBracketingComboBox.Name = "focusBracketingComboBox";
            this.focusBracketingComboBox.Size = new System.Drawing.Size(163, 20);
            this.focusBracketingComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Focus Bracketing";
            // 
            // focusIncrementComboBox
            // 
            this.focusIncrementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.focusIncrementComboBox.FormattingEnabled = true;
            this.focusIncrementComboBox.Location = new System.Drawing.Point(23, 149);
            this.focusIncrementComboBox.Name = "focusIncrementComboBox";
            this.focusIncrementComboBox.Size = new System.Drawing.Size(163, 20);
            this.focusIncrementComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Focus increment";
            // 
            // exposureSmoothingComboBox
            // 
            this.exposureSmoothingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exposureSmoothingComboBox.FormattingEnabled = true;
            this.exposureSmoothingComboBox.Location = new System.Drawing.Point(23, 195);
            this.exposureSmoothingComboBox.Name = "exposureSmoothingComboBox";
            this.exposureSmoothingComboBox.Size = new System.Drawing.Size(163, 20);
            this.exposureSmoothingComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exposure smoothing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of shots";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(134, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(14, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxShtNum
            // 
            this.textBoxShtNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxShtNum.Location = new System.Drawing.Point(86, 103);
            this.textBoxShtNum.Name = "textBoxShtNum";
            this.textBoxShtNum.Size = new System.Drawing.Size(100, 19);
            this.textBoxShtNum.TabIndex = 14;
            // 
            // FocusBractingSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 282);
            this.Controls.Add(this.textBoxShtNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exposureSmoothingComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.focusIncrementComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.focusBracketingComboBox);
            this.Controls.Add(this.label1);
            this.Name = "FocusBractingSetting";
            this.Text = "Camera Control";
            this.Load += new System.EventHandler(this.FocusBractingSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox focusBracketingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox focusIncrementComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox exposureSmoothingComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxShtNum;
    }
}