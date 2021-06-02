using System;
using System.IO.MemoryMappedFiles;

namespace ActionApp
{
    /// <summary>
    /// Class for send data to second application
    /// It send queue data in application "monitor" for display queue. Here used memory reserving by MemoryMappedFiles class.
    /// </summary>
    class MemoryMappedFilesSender
    {
        public static void ToSend(string message)
        {
            char[] messageArr = message.ToCharArray();
            int size = messageArr.Length;
            MemoryMappedFile sharedMemory = MemoryMappedFile.CreateOrOpen("MemoryFile", size * 2 + 4);

            using (MemoryMappedViewAccessor writer = sharedMemory.CreateViewAccessor(0, size * 2 + 4))
            {
                writer.Write(0, size);
                try
                {
                    writer.WriteArray<char>(4, messageArr, 0, messageArr.Length);
                }
                catch (ArgumentOutOfRangeException) { }
            }
        }
    }
}
