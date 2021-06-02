using System;
using System.IO.MemoryMappedFiles;

namespace MonitorApp.Communication
{
    /// <summary>
    /// Class for receive data from first application
    /// It receive queue data from application "action" for display queue. Here used memory reserving by MemoryMappedFiles class.
    /// </summary>
    class MemoryMappedFilesReceiver
    {
        public static string ToReceive()
        {
            char[] message;
            int size;
            MemoryMappedFile sharedMemory = MemoryMappedFile.OpenExisting("MemoryFile");

            using (MemoryMappedViewAccessor reader = sharedMemory.CreateViewAccessor(0, 4, MemoryMappedFileAccess.Read))
            {
                size = reader.ReadInt32(0);
            }

            using (MemoryMappedViewAccessor reader = sharedMemory.CreateViewAccessor(4, size * 2, MemoryMappedFileAccess.Read))
            {
                message = new char[size];
                reader.ReadArray<char>(0, message, 0, size);
            }

            return String.Concat<char>(message);
        }
    }
}
