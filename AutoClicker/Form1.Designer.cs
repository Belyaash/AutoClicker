namespace AutoClicker;

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
            this.Interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBoxLeftRight = new System.Windows.Forms.GroupBox();
            this.RightButton = new System.Windows.Forms.RadioButton();
            this.LeftButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoubleButton = new System.Windows.Forms.RadioButton();
            this.OneButton = new System.Windows.Forms.RadioButton();
            this.SetCursorPosition = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XPosition = new System.Windows.Forms.TextBox();
            this.YPosition = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.GroupBoxLeftRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Interval
            // 
            this.Interval.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Interval.Location = new System.Drawing.Point(278, 20);
            this.Interval.MaxLength = 12;
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(162, 32);
            this.Interval.TabIndex = 0;
            this.Interval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Interval_KeyPress);
            this.Interval.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Interval_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set clicker interval in ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set click options";
            // 
            // GroupBoxLeftRight
            // 
            this.GroupBoxLeftRight.Controls.Add(this.RightButton);
            this.GroupBoxLeftRight.Controls.Add(this.LeftButton);
            this.GroupBoxLeftRight.Location = new System.Drawing.Point(22, 128);
            this.GroupBoxLeftRight.Name = "GroupBoxLeftRight";
            this.GroupBoxLeftRight.Size = new System.Drawing.Size(182, 45);
            this.GroupBoxLeftRight.TabIndex = 3;
            this.GroupBoxLeftRight.TabStop = false;
            // 
            // RightButton
            // 
            this.RightButton.AutoSize = true;
            this.RightButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightButton.Location = new System.Drawing.Point(79, 11);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(82, 27);
            this.RightButton.TabIndex = 1;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // LeftButton
            // 
            this.LeftButton.AutoSize = true;
            this.LeftButton.Checked = true;
            this.LeftButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftButton.Location = new System.Drawing.Point(6, 11);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(69, 27);
            this.LeftButton.TabIndex = 0;
            this.LeftButton.TabStop = true;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoubleButton);
            this.groupBox1.Controls.Add(this.OneButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // DoubleButton
            // 
            this.DoubleButton.AutoSize = true;
            this.DoubleButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoubleButton.Location = new System.Drawing.Point(79, 11);
            this.DoubleButton.Name = "DoubleButton";
            this.DoubleButton.Size = new System.Drawing.Size(96, 27);
            this.DoubleButton.TabIndex = 1;
            this.DoubleButton.Text = "Double";
            this.DoubleButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.AutoSize = true;
            this.OneButton.Checked = true;
            this.OneButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.Location = new System.Drawing.Point(6, 11);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(69, 27);
            this.OneButton.TabIndex = 0;
            this.OneButton.TabStop = true;
            this.OneButton.Text = "One";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // SetCursorPosition
            // 
            this.SetCursorPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SetCursorPosition.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetCursorPosition.Location = new System.Drawing.Point(210, 96);
            this.SetCursorPosition.Name = "SetCursorPosition";
            this.SetCursorPosition.Size = new System.Drawing.Size(241, 34);
            this.SetCursorPosition.TabIndex = 5;
            this.SetCursorPosition.Text = "Set cursor position (F3)";
            this.SetCursorPosition.UseVisualStyleBackColor = false;
            this.SetCursorPosition.Click += new System.EventHandler(this.SetCursorPosition_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(280, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(376, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y";
            // 
            // XPosition
            // 
            this.XPosition.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XPosition.Location = new System.Drawing.Point(247, 185);
            this.XPosition.Name = "XPosition";
            this.XPosition.ReadOnly = true;
            this.XPosition.Size = new System.Drawing.Size(90, 32);
            this.XPosition.TabIndex = 8;
            this.XPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YPosition
            // 
            this.YPosition.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YPosition.Location = new System.Drawing.Point(343, 185);
            this.YPosition.Name = "YPosition";
            this.YPosition.ReadOnly = true;
            this.YPosition.Size = new System.Drawing.Size(90, 32);
            this.YPosition.TabIndex = 8;
            this.YPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(22, 247);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(182, 61);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start(F2)";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopButton.Location = new System.Drawing.Point(247, 247);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(180, 61);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "Stop(F12)";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(452, 324);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.YPosition);
            this.Controls.Add(this.XPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetCursorPosition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBoxLeftRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Interval);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoClicker";
            this.GroupBoxLeftRight.ResumeLayout(false);
            this.GroupBoxLeftRight.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private TextBox Interval;
    private Label label1;
    private Label label2;
    private GroupBox GroupBoxLeftRight;
    private RadioButton RightButton;
    private RadioButton LeftButton;
    private GroupBox groupBox1;
    private RadioButton DoubleButton;
    private RadioButton OneButton;
    private Button SetCursorPosition;
    private Label label3;
    private Label label4;
    private TextBox XPosition;
    private TextBox YPosition;
    private Button StartButton;
    private Button StopButton;
}
