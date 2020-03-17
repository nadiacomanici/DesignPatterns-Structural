namespace Adapter_Students_End.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public StudentViewModel(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
