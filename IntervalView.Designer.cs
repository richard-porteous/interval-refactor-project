
namespace interval_refactor_project
{
    partial class IntervalView
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
            this._startField = new System.Windows.Forms.TextBox();
            this._endField = new System.Windows.Forms.TextBox();
            this._lengthField = new System.Windows.Forms.TextBox();
            this.startLBL = new System.Windows.Forms.Label();
            this.endLBL = new System.Windows.Forms.Label();
            this.lengthLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _startField
            // 
            this._startField.Location = new System.Drawing.Point(94, 80);
            this._startField.Name = "_startField";
            this._startField.Size = new System.Drawing.Size(133, 23);
            this._startField.TabIndex = 0;
            this._startField.Text = "0";
            this._startField.LostFocus += new System.EventHandler(this.StartField_LostFocus);
            // 
            // _endField
            // 
            this._endField.Location = new System.Drawing.Point(94, 153);
            this._endField.Name = "_endField";
            this._endField.Size = new System.Drawing.Size(133, 23);
            this._endField.TabIndex = 1;
            this._endField.Text = "0";
            this._endField.LostFocus += new System.EventHandler(this.EndField_LostFocus);
            // 
            // _lengthField
            // 
            this._lengthField.Location = new System.Drawing.Point(94, 230);
            this._lengthField.Name = "_lengthField";
            this._lengthField.Size = new System.Drawing.Size(133, 23);
            this._lengthField.TabIndex = 2;
            this._lengthField.Text = "0";
            this._lengthField.LostFocus += new System.EventHandler(this.LengthField_LostFocus);
            // 
            // startLBL
            // 
            this.startLBL.AutoSize = true;
            this.startLBL.Location = new System.Drawing.Point(22, 83);
            this.startLBL.Name = "startLBL";
            this.startLBL.Size = new System.Drawing.Size(31, 15);
            this.startLBL.TabIndex = 3;
            this.startLBL.Text = "Start";
            // 
            // endLBL
            // 
            this.endLBL.AutoSize = true;
            this.endLBL.Location = new System.Drawing.Point(22, 156);
            this.endLBL.Name = "endLBL";
            this.endLBL.Size = new System.Drawing.Size(27, 15);
            this.endLBL.TabIndex = 4;
            this.endLBL.Text = "End";
            // 
            // lengthLBL
            // 
            this.lengthLBL.AutoSize = true;
            this.lengthLBL.Location = new System.Drawing.Point(22, 233);
            this.lengthLBL.Name = "lengthLBL";
            this.lengthLBL.Size = new System.Drawing.Size(44, 15);
            this.lengthLBL.TabIndex = 5;
            this.lengthLBL.Text = "Length";
            // 
            // IntervalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 450);
            this.Controls.Add(this.lengthLBL);
            this.Controls.Add(this.endLBL);
            this.Controls.Add(this.startLBL);
            this.Controls.Add(this._lengthField);
            this.Controls.Add(this._endField);
            this.Controls.Add(this._startField);
            this.Name = "IntervalWindow";
            this.Text = "Interval Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _startField;
        private System.Windows.Forms.TextBox _endField;
        private System.Windows.Forms.TextBox _lengthField;
        private System.Windows.Forms.Label startLBL;
        private System.Windows.Forms.Label endLBL;
        private System.Windows.Forms.Label lengthLBL;
    }
}

