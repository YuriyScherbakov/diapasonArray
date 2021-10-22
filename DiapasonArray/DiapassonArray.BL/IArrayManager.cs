namespace DiapassonArray.BL
{
    public interface IArrayManager
    {
        string StringCurrentView { get; set; }
        void SaveNewNumber(int number);
    }
}