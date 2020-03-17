using System.Windows;
using Adapter_Students_End.Adapters;
using Structural_BLL;

namespace Adapter_Students_End
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentsReadService _studentsReadService;

        public MainWindow()
        {
            InitializeComponent();

            _studentsReadService = new StudentsReadService();

            // It will display only the Id, because the UI expects each student to have "FirstName" and "LastName" properties
            // but in reality, the models returned by the BLL have "Name" and "Surname"
            //listViewStudents.ItemsSource = _studentsReadService.GetAllStudents();

            // So, we need an adapter, to offer the expected "interface" for the class Student
            var adapter = new StudentAdapter();
            listViewStudents.ItemsSource = adapter.GetStudentViewModelList(_studentsReadService.GetAllStudents());
        }
    }
}
