using System;

namespace After
{
    public class NtfsReadFileManager : IReadFileManager
    {
        public byte[] ReadFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteFile(string fileName)
        {
            throw new NotImplementedException();
        }

        //TODO - add ability to write File Attributes and file location
    }
}