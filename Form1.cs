namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(calendarBtn, "Окно календаря");
            toolTip2.SetToolTip(addEventBtn, "Добавление события на определенное время в определенный день");
            toolTip3.SetToolTip(weekViewBtn, "Просмотр недели с добавленными событиями");
            toolTip4.SetToolTip(userProfileBtn, "Информация о конкретном пользователе");
            toolTip5.SetToolTip(logoutBtn, "Кнопка выхода из аккаунта на страницу входа");
        }
    }
}
