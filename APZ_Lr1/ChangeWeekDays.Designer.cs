namespace APZ_Lr1
{
    partial class ChangeWeekDays
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
            WDControl = new WeekDaysComponent.WeekDaysControl();
            SuspendLayout();
            // 
            // WDControl
            // 
            WDControl.BackColor = SystemColors.ActiveCaption;
            WDControl.BirthDate = new DateTime(2024, 2, 18, 18, 54, 45, 150);
            WDControl.Dock = DockStyle.Fill;
            WDControl.Location = new Point(0, 0);
            WDControl.Name = "WDControl";
            WDControl.Size = new Size(800, 486);
            WDControl.TabIndex = 0;
            WDControl.BirthDateChanged += WDControl_BirthDateChanged;
            // 
            // ChangeWeekDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(WDControl);
            Name = "ChangeWeekDays";
            Text = "ChangeWeekDays";
            ResumeLayout(false);
        }

        #endregion

        private WeekDaysComponent.WeekDaysControl WDControl;
    }
}
