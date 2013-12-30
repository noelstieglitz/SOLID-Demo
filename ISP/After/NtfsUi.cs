using System;

namespace After
{
    public class NtfsUi : IReadFileManager, IWriteFileManager
    {
        public byte[] ReadFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}