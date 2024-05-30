namespace WeekDaysComponent
{
    [ToolboxBitmap(@"D:\VS Community\C#.NET_2\APZ_Lr1_Trush\WeekDaysComponent\WeekDaysControl.ico")]

    public partial class WeekDaysControl : UserControl
    {
        public event EventHandler BirthDateChanged;

        private CheckBox lastCheckBox;

        public WeekDaysControl()
        {
            InitializeComponent();
        }

        public DateTime BirthDate
        {
            get { return DTPicker.Value; }
            set
            {
                DTPicker.Value = value;
                BirthDateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void UpdateDayOfWeekCheckBoxes()
        {
            if (lastCheckBox != null)
            {
                lastCheckBox.Checked = false;
            }
            DayOfWeek dayOfWeek = BirthDate.DayOfWeek;
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    cbMonday.Checked = true;
                    lastCheckBox = cbMonday;
                    break;
                case DayOfWeek.Tuesday:
                    cbTuesday.Checked = true;
                    lastCheckBox = cbTuesday;
                    break;
                case DayOfWeek.Wednesday:
                    cbWednesday.Checked = true;
                    lastCheckBox = cbWednesday;
                    break;
                case DayOfWeek.Thursday:
                    cbThursday.Checked = true;
                    lastCheckBox = cbThursday;
                    break;
                case DayOfWeek.Friday:
                    cbFriday.Checked = true;
                    lastCheckBox = cbFriday;
                    break;
                case DayOfWeek.Saturday:
                    cbSaturday.Checked = true;
                    lastCheckBox = cbSaturday;
                    break;
                case DayOfWeek.Sunday:
                    cbSunday.Checked = true;
                    lastCheckBox = cbSunday;
                    break;
                default:
                    break;
            }
        }

        public void ShowMessage(string message)
        {
            TBMessage.Text = message;
        }

        public bool ValidateBirthDate()
        {
            if (BirthDate.Date > DateTime.Today)
            {
                ShowMessage("Помилка: Дата більша за поточну.");
                return false;
            }
            return true;
        }

        private void DTPicker_ValueChanged(object sender, EventArgs e)
        {
            BirthDateChanged?.Invoke(this, EventArgs.Empty);
            UpdateDayOfWeekCheckBoxes();
        }

        public string GetTextMessage(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                    return "Нумерологи вважають, що люди, які народилися у понеділок - це справжні лідери. Ви знаходитеся під охороною Місяця.";
                case DayOfWeek.Tuesday:
                    return "Цим днем править Марс, тому народжені у вівторок - справжні воїни, готові боротися до останнього.";
                case DayOfWeek.Wednesday:
                    return "Ті, хто народився у середу - дуже веселі та енергійні люди. Завдяки Меркурію ви тонко відчуваєте настрій інших.";
                case DayOfWeek.Thursday:
                    return "За четвер відповідає планета Юпітер, яка надолужує людей мислити здраво і завжди покладатися на логіку, а не на зов серця.";
                case DayOfWeek.Friday:
                    return "Людей, народжених у цей день охороняє Венера, яка наділяє їх особливим вмінням кохати.";
                case DayOfWeek.Saturday:
                    return "Народжені у суботу - люди Сатурна. Ви маєте потужне шосте чуття і завжди обираєте шлях, який вам потрібен.";
                case DayOfWeek.Sunday:
                    return "Цим днем управляє Сонце. Вас можна назвати справжніми щасливчиками, бо зірвати джек-пот для вас не проблема!";
                default:
                    return "Помилка";
            }
        }
    }
}