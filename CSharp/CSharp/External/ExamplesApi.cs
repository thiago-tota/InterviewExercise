using System.Runtime.InteropServices;
using System.Text.Json;
using ExerciseApplication.Infrastructure;

namespace ExerciseApplication.External
{
    internal class ExamplesApi(IFileManager fileManager)
    {
        private IFileManager _fileManager = fileManager;

        private string? Get()
        {
            var jsonFile = Path.Combine("External", "Resources", "Examples.json");

            return _fileManager.Get(jsonFile);
        }

        public string GetUser(int id)
        {
            var jsonData = Get();

            var usersMap = JsonSerializer.Deserialize<Dictionary<string, List<Dictionary<string, object>>>>(jsonData!);

            var userList = usersMap.TryGetValue("users", out var users) ? users : new();

            var user = userList.FirstOrDefault(f => Convert.ToInt32(f["id"].ToString()) == id);
            return user != null ? JsonSerializer.Serialize(user) : throw new ArgumentException($"User with ID {id} not found.");
        }
    }
}
