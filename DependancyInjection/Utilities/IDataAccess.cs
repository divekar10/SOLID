namespace DependancyInjection.Utilities
{
    public interface IDataAccess
    {
        void loadData();
        void saveData(string name);
    }
}