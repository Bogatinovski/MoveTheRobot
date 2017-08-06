namespace MoveTheRobot
{
    partial class CreateConfiguratonForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.motorName = new System.Windows.Forms.TextBox();
            this.motorMinValue = new System.Windows.Forms.NumericUpDown();
            this.motorMaxValue = new System.Windows.Forms.NumericUpDown();
            this.addMotorBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.motorsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.motorMinValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorMaxValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(395, 352);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(314, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // motorName
            // 
            this.motorName.Location = new System.Drawing.Point(12, 36);
            this.motorName.Name = "motorName";
            this.motorName.Size = new System.Drawing.Size(100, 20);
            this.motorName.TabIndex = 3;
            // 
            // motorMinValue
            // 
            this.motorMinValue.Location = new System.Drawing.Point(131, 36);
            this.motorMinValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.motorMinValue.Name = "motorMinValue";
            this.motorMinValue.Size = new System.Drawing.Size(83, 20);
            this.motorMinValue.TabIndex = 7;
            // 
            // motorMaxValue
            // 
            this.motorMaxValue.Location = new System.Drawing.Point(234, 36);
            this.motorMaxValue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.motorMaxValue.Name = "motorMaxValue";
            this.motorMaxValue.Size = new System.Drawing.Size(83, 20);
            this.motorMaxValue.TabIndex = 8;
            // 
            // addMotorBtn
            // 
            this.addMotorBtn.Location = new System.Drawing.Point(394, 34);
            this.addMotorBtn.Name = "addMotorBtn";
            this.addMotorBtn.Size = new System.Drawing.Size(73, 23);
            this.addMotorBtn.TabIndex = 9;
            this.addMotorBtn.Text = "Add Motor";
            this.addMotorBtn.UseVisualStyleBackColor = true;
            this.addMotorBtn.Click += new System.EventHandler(this.addMotorBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.motorName);
            this.groupBox1.Controls.Add(this.addMotorBtn);
            this.groupBox1.Controls.Add(this.motorMaxValue);
            this.groupBox1.Controls.Add(this.motorMinValue);
            this.groupBox1.Location = new System.Drawing.Point(3, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Min Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(479, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Robot Configuration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Configuration Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(6, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // motorsPanel
            // 
            this.motorsPanel.AutoScroll = true;
            this.motorsPanel.ColumnCount = 4;
            this.motorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.motorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.motorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.motorsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.motorsPanel.Location = new System.Drawing.Point(15, 149);
            this.motorsPanel.Name = "motorsPanel";
            this.motorsPanel.RowCount = 1;
            this.motorsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.motorsPanel.Size = new System.Drawing.Size(455, 185);
            this.motorsPanel.TabIndex = 15;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rcfg";
            // 
            // CreateConfiguratonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 387);
            this.ControlBox = false;
            this.Controls.Add(this.motorsPanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateConfiguratonForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create new Robot Configuraton";
            this.Load += new System.EventHandler(this.CreateConfiguratonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.motorMinValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorMaxValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox motorName;
        private System.Windows.Forms.NumericUpDown motorMinValue;
        private System.Windows.Forms.NumericUpDown motorMaxValue;
        private System.Windows.Forms.Button addMotorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TableLayoutPanel motorsPanel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}