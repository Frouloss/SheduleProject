namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolTip1.SetToolTip(calendarBtn, "���� ���������");
            toolTip2.SetToolTip(addEventBtn, "���������� ������� �� ������������ ����� � ������������ ����");
            toolTip3.SetToolTip(weekViewBtn, "�������� ������ � ������������ ���������");
            toolTip4.SetToolTip(userProfileBtn, "���������� � ���������� ������������");
            toolTip5.SetToolTip(logoutBtn, "������ ������ �� �������� �� �������� �����");
        }
    }
}
