namespace Nine.Hosting
{
    using System.IO;

    public interface ISharedMemory
    {
        Stream GetStream(string name, int sizeInBytes);

        bool Remove(string name);
    }
}
