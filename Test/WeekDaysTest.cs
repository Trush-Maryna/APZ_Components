using WeekDaysComponent;

namespace Tests
{
    public class WeekDaysTest
    {
        [Fact]
        public void EventEffected_DateChanged()
        {
            var ctrl = new WeekDaysControl();
            bool eventeff = false;
            ctrl.BirthDateChanged += (sender, args) => eventeff = true;
            ctrl.BirthDate = DateTime.Now;
            Assert.True(eventeff);
        }

        [Theory]
        [InlineData(DayOfWeek.Monday)]
        [InlineData(DayOfWeek.Tuesday)]
        [InlineData(DayOfWeek.Wednesday)]
        [InlineData(DayOfWeek.Thursday)]
        [InlineData(DayOfWeek.Friday)]
        [InlineData(DayOfWeek.Saturday)]
        [InlineData(DayOfWeek.Sunday)]

        public void CorrectMessage(DayOfWeek dayOfWeek)
        {
            var ctrl = new WeekDaysControl();
            string mess = ctrl.GetTextMessage(dayOfWeek);
            Assert.NotNull(mess);
            Assert.NotEmpty(mess);
        }

        [Fact]
        public void WhenDateIsTodayOrEarlier()
        {
            var ctrl = new WeekDaysControl();
            ctrl.BirthDate = DateTime.Today;
            bool res = ctrl.ValidateBirthDate();
            Assert.True(res);
        }

        [Fact]
        public void WhenDateIsAfterToday()
        {
            var ctrl = new WeekDaysControl();
            ctrl.BirthDate = DateTime.Today.AddDays(1);
            bool res = ctrl.ValidateBirthDate();
            Assert.False(res);
        }
    }
}