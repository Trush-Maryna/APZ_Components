namespace WeekDaysComponent
{
    partial class WeekDaysControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbMonday = new CheckBox();
            cbTuesday = new CheckBox();
            cbWednesday = new CheckBox();
            cbThursday = new CheckBox();
            cbFriday = new CheckBox();
            cbSaturday = new CheckBox();
            cbSunday = new CheckBox();
            DTPicker = new DateTimePicker();
            flowLayoutPanel = new FlowLayoutPanel();
            TBMessage = new TextBox();
            text = new Label();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cbMonday
            // 
            cbMonday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbMonday.AutoSize = true;
            cbMonday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbMonday.ForeColor = Color.Navy;
            cbMonday.Location = new Point(3, 3);
            cbMonday.Name = "cbMonday";
            cbMonday.Size = new Size(152, 39);
            cbMonday.TabIndex = 0;
            cbMonday.Text = "Понеділок";
            cbMonday.UseVisualStyleBackColor = true;
            // 
            // cbTuesday
            // 
            cbTuesday.AutoSize = true;
            cbTuesday.Dock = DockStyle.Top;
            cbTuesday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbTuesday.ForeColor = Color.Navy;
            cbTuesday.Location = new Point(3, 48);
            cbTuesday.Name = "cbTuesday";
            cbTuesday.Size = new Size(143, 39);
            cbTuesday.TabIndex = 1;
            cbTuesday.Text = "Вівторок";
            cbTuesday.UseVisualStyleBackColor = true;
            // 
            // cbWednesday
            // 
            cbWednesday.AutoSize = true;
            cbWednesday.Dock = DockStyle.Top;
            cbWednesday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbWednesday.ForeColor = Color.Navy;
            cbWednesday.Location = new Point(3, 93);
            cbWednesday.Name = "cbWednesday";
            cbWednesday.Size = new Size(119, 39);
            cbWednesday.TabIndex = 2;
            cbWednesday.Text = "Середа";
            cbWednesday.UseVisualStyleBackColor = true;
            // 
            // cbThursday
            // 
            cbThursday.AutoSize = true;
            cbThursday.Dock = DockStyle.Top;
            cbThursday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbThursday.ForeColor = Color.Navy;
            cbThursday.Location = new Point(3, 138);
            cbThursday.Name = "cbThursday";
            cbThursday.Size = new Size(125, 39);
            cbThursday.TabIndex = 3;
            cbThursday.Text = "Четвер";
            cbThursday.UseVisualStyleBackColor = true;
            // 
            // cbFriday
            // 
            cbFriday.AutoSize = true;
            cbFriday.Dock = DockStyle.Top;
            cbFriday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbFriday.ForeColor = Color.Navy;
            cbFriday.Location = new Point(3, 183);
            cbFriday.Name = "cbFriday";
            cbFriday.Size = new Size(148, 39);
            cbFriday.TabIndex = 4;
            cbFriday.Text = "П'ятниця";
            cbFriday.UseVisualStyleBackColor = true;
            // 
            // cbSaturday
            // 
            cbSaturday.AutoSize = true;
            cbSaturday.Dock = DockStyle.Top;
            cbSaturday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbSaturday.ForeColor = Color.Navy;
            cbSaturday.Location = new Point(3, 228);
            cbSaturday.Name = "cbSaturday";
            cbSaturday.Size = new Size(127, 39);
            cbSaturday.TabIndex = 5;
            cbSaturday.Text = "Субота";
            cbSaturday.UseVisualStyleBackColor = true;
            // 
            // cbSunday
            // 
            cbSunday.AutoSize = true;
            cbSunday.Dock = DockStyle.Top;
            cbSunday.Font = new Font("Segoe UI", 15F, FontStyle.Italic);
            cbSunday.ForeColor = Color.Navy;
            cbSunday.Location = new Point(3, 273);
            cbSunday.Name = "cbSunday";
            cbSunday.Size = new Size(112, 39);
            cbSunday.TabIndex = 6;
            cbSunday.Text = "Неділя";
            cbSunday.UseVisualStyleBackColor = true;
            // 
            // DTPicker
            // 
            DTPicker.Location = new Point(163, 39);
            DTPicker.Name = "DTPicker";
            DTPicker.Size = new Size(435, 27);
            DTPicker.TabIndex = 8;
            DTPicker.ValueChanged += DTPicker_ValueChanged;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(cbMonday);
            flowLayoutPanel.Controls.Add(cbTuesday);
            flowLayoutPanel.Controls.Add(cbWednesday);
            flowLayoutPanel.Controls.Add(cbThursday);
            flowLayoutPanel.Controls.Add(cbFriday);
            flowLayoutPanel.Controls.Add(cbSaturday);
            flowLayoutPanel.Controls.Add(cbSunday);
            flowLayoutPanel.Location = new Point(311, 69);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(163, 327);
            flowLayoutPanel.TabIndex = 9;
            // 
            // TBMessage
            // 
            TBMessage.BackColor = SystemColors.InactiveCaption;
            TBMessage.Dock = DockStyle.Bottom;
            TBMessage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            TBMessage.Location = new Point(0, 396);
            TBMessage.Multiline = true;
            TBMessage.Name = "TBMessage";
            TBMessage.Size = new Size(800, 71);
            TBMessage.TabIndex = 10;
            TBMessage.TextAlign = HorizontalAlignment.Center;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Stencil", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.ForeColor = Color.Navy;
            text.Location = new Point(163, 3);
            text.Name = "text";
            text.Size = new Size(435, 30);
            text.TabIndex = 11;
            text.Text = "Оберіть дату вашого народження";
            text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeekDaysControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(text);
            Controls.Add(TBMessage);
            Controls.Add(flowLayoutPanel);
            Controls.Add(DTPicker);
            Name = "WeekDaysControl";
            Size = new Size(800, 467);
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbMonday;
        private CheckBox cbTuesday;
        private CheckBox cbWednesday;
        private CheckBox cbThursday;
        private CheckBox cbFriday;
        private CheckBox cbSaturday;
        private CheckBox cbSunday;
        private DateTimePicker DTPicker;
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox TBMessage;
        private Label text;
    }
}
