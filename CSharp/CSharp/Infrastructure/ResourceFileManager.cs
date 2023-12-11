using System.Text;

namespace ExerciseApplication.Infrastructure
{
    internal class ResourceFileManager : IFileManager
    {
        public string? Get(string path)
        {
            var value = File.ReadAllText(path);
            return string.IsNullOrWhiteSpace(value) ? null : value;
        }

        public async Task Write(string path, string content)
        {
            await File.WriteAllTextAsync(path, content, Encoding.UTF8);
        }

        public bool FileExists(string file)
        {
            return File.Exists(file);
        }
    }
}
