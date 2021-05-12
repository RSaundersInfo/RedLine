namespace RedLine
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NHeight = new System.Windows.Forms.NumericUpDown();
            this.NWidth = new System.Windows.Forms.NumericUpDown();
            this.NYPosFromCursor = new System.Windows.Forms.NumericUpDown();
            this.NXPosFromCursor = new System.Windows.Forms.NumericUpDown();
            this.NOpacity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.SelectColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NYPosFromCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXPosFromCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(293, 282);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Line Y Distance from Cursor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cursor X at % of Line Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Opacity";
            // 
            // NHeight
            // 
            this.NHeight.Location = new System.Drawing.Point(173, 87);
            this.NHeight.Name = "NHeight";
            this.NHeight.Size = new System.Drawing.Size(83, 20);
            this.NHeight.TabIndex = 7;
            this.NHeight.Enter += new System.EventHandler(this.ControlHasFocus);
            this.NHeight.Leave += new System.EventHandler(this.ControlLostFocus);
            // 
            // NWidth
            // 
            this.NWidth.Location = new System.Drawing.Point(173, 113);
            this.NWidth.Name = "NWidth";
            this.NWidth.Size = new System.Drawing.Size(83, 20);
            this.NWidth.TabIndex = 8;
            this.NWidth.Enter += new System.EventHandler(this.ControlHasFocus);
            this.NWidth.Leave += new System.EventHandler(this.ControlLostFocus);
            // 
            // NYPosFromCursor
            // 
            this.NYPosFromCursor.Location = new System.Drawing.Point(173, 139);
            this.NYPosFromCursor.Name = "NYPosFromCursor";
            this.NYPosFromCursor.Size = new System.Drawing.Size(83, 20);
            this.NYPosFromCursor.TabIndex = 9;
            this.NYPosFromCursor.Enter += new System.EventHandler(this.ControlHasFocus);
            this.NYPosFromCursor.Leave += new System.EventHandler(this.ControlLostFocus);
            // 
            // NXPosFromCursor
            // 
            this.NXPosFromCursor.Location = new System.Drawing.Point(173, 165);
            this.NXPosFromCursor.Name = "NXPosFromCursor";
            this.NXPosFromCursor.Size = new System.Drawing.Size(83, 20);
            this.NXPosFromCursor.TabIndex = 10;
            this.NXPosFromCursor.Enter += new System.EventHandler(this.ControlHasFocus);
            this.NXPosFromCursor.Leave += new System.EventHandler(this.ControlLostFocus);
            // 
            // NOpacity
            // 
            this.NOpacity.Location = new System.Drawing.Point(173, 191);
            this.NOpacity.Name = "NOpacity";
            this.NOpacity.Size = new System.Drawing.Size(83, 20);
            this.NOpacity.TabIndex = 11;
            this.NOpacity.Enter += new System.EventHandler(this.ControlHasFocus);
            this.NOpacity.Leave += new System.EventHandler(this.ControlLostFocus);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 65);
            this.label7.TabIndex = 12;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // ColorLabel
            // 
            this.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorLabel.Location = new System.Drawing.Point(173, 224);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(20, 20);
            this.ColorLabel.TabIndex = 13;
            // 
            // SelectColorButton
            // 
            this.SelectColorButton.Location = new System.Drawing.Point(199, 224);
            this.SelectColorButton.Name = "SelectColorButton";
            this.SelectColorButton.Size = new System.Drawing.Size(57, 20);
            this.SelectColorButton.TabIndex = 14;
            this.SelectColorButton.Text = "Select";
            this.SelectColorButton.UseVisualStyleBackColor = true;
            this.SelectColorButton.Click += new System.EventHandler(this.SelectColorButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 317);
            this.ControlBox = false;
            this.Controls.Add(this.SelectColorButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NOpacity);
            this.Controls.Add(this.NXPosFromCursor);
            this.Controls.Add(this.NYPosFromCursor);
            this.Controls.Add(this.NWidth);
            this.Controls.Add(this.NHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedLine Settings";
            ((System.ComponentModel.ISupportInitialize)(this.NHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NYPosFromCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NXPosFromCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NHeight;
        private System.Windows.Forms.NumericUpDown NWidth;
        private System.Windows.Forms.NumericUpDown NYPosFromCursor;
        private System.Windows.Forms.NumericUpDown NXPosFromCursor;
        private System.Windows.Forms.NumericUpDown NOpacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button SelectColorButton;
    }
}