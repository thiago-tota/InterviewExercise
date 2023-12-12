namespace ExerciseApplication.Infrastructure
{
    internal interface IFileManager
    {
        string? Get(string path);
        Task Write(string path, string value);
        bool FileExists(string file);
    }
}
