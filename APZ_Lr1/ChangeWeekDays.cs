namespace APZ_Lr1
{
    public partial class ChangeWeekDays : Form
    {

        public ChangeWeekDays()
        {
            InitializeComponent();
            WDControl.BirthDateChanged += WDControl_BirthDateChanged;
        }

        private void WDControl_BirthDateChanged(object sender, EventArgs e)
        {
            if (!WDControl.ValidateBirthDate())
                return;
            DayOfWeek dayOfWeek = WDControl.BirthDate.DayOfWeek;
            string message = WDControl.GetTextMessage(dayOfWeek);
            WDControl.ShowMessage(message);
        }
    }
}