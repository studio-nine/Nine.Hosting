namespace Nine.Hosting
{
    using System.IO;

    public interface ISharedMemory
    {
        Stream Read(string name);
        Stream Write(string name, int sizeInBytes);

        bool Remove(string name);
    }
}
