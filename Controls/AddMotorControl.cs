using MoveTheRobot.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveTheRobot.Controls
{
    public class AddMotorControl
    {
        private Motor motor;
        private TableLayoutPanel parentControl;
        private Control nameTextbox;
        private ICollection<AddMotorControl> allMotorsControls;

        public AddMotorControl(TableLayoutPanel control, Motor motor, ICollection<AddMotorControl> allMotorsControls)
        {
            this.motor = motor;
            this.parentControl = control;
            this.allMotorsControls = allMotorsControls;

            InitializeLayout();
        }

        public Motor Motor
        {
            get
            {
                return this.motor;
            }
            set
            {
                this.motor = value;
            }
        }

        private void InitializeLayout()
        {
            int rowIndex = parentControl.RowCount;
            RowStyle style = new RowStyle(SizeType.AutoSize);
            parentControl.RowStyles.Add(style);

            Debug.WriteLine("Row: " + rowIndex.ToString());
            parentControl.RowCount += 1;

            nameTextbox = new TextBox();
            nameTextbox.Text = motor.Name;
            nameTextbox.TextChanged += new EventHandler(NameTextbox_TextChanged);
            parentControl.Controls.Add(nameTextbox, 0, rowIndex);

            NumericUpDown minValueBox = new NumericUpDown();
            minValueBox.Value = motor.MinValue;
            minValueBox.Maximum = 100000;
            minValueBox.ValueChanged += new EventHandler(MinValueBox_ValueChanged);
            parentControl.Controls.Add(minValueBox, 1, rowIndex);

            NumericUpDown maxValueBox = new NumericUpDown();
            maxValueBox.Value = motor.MinValue;
            maxValueBox.Maximum = 100000;
            maxValueBox.ValueChanged += new EventHandler(MaxValueBox_ValueChanged);
            parentControl.Controls.Add(maxValueBox, 2, rowIndex);

            Button removeBtn = new Button();
            removeBtn.Text = "Remove";
            removeBtn.Click += new EventHandler(RemoveBtn_Click);
            parentControl.Controls.Add(removeBtn, 3, rowIndex);

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = parentControl.GetRow(nameTextbox);
            Debug.WriteLine(rowIndex.ToString());

            if (rowIndex >= parentControl.RowCount)
            {
                return;
            }

            // delete all controls of row that we want to delete
            for (int i = 0; i < parentControl.ColumnCount; i++)
            {
                var control = parentControl.GetControlFromPosition(i, rowIndex);
                parentControl.Controls.Remove(control);
            }

            // move up row controls that comes after row we want to remove
            for (int i = rowIndex + 1; i < parentControl.RowCount; i++)
            {
                for (int j = 0; j < parentControl.ColumnCount; j++)
                {
                    var control = parentControl.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        parentControl.SetRow(control, i - 1);
                    }
                }
            }

            // remove last row
            parentControl.RowStyles.RemoveAt(parentControl.RowCount - 1);
            parentControl.RowCount--;

            allMotorsControls.Remove(this);
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            motor.Name = textbox.Text;
            Debug.WriteLine(motor.Name);
        }

        private void MinValueBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown textbox = (NumericUpDown)sender;
            motor.MinValue = (int)textbox.Value;
            Debug.WriteLine(motor.MinValue);
        }

        private void MaxValueBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown textbox = (NumericUpDown)sender;
            motor.MaxValue = (int)textbox.Value;
            Debug.WriteLine(motor.MaxValue);
        }
    }
}
