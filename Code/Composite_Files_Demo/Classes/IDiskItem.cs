namespace Composite_Files_Demo.Classes
{
    public interface IDiskItem
    {
        string Name { get; }
        int SizeInKB { get; }
        void Display(int indent);
    }
}
