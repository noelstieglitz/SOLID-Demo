namespace Before
{
    public interface IFileManager
    {
        byte[] ReadFile(string fileName);
        void WriteFile(string fileName);
    }
}