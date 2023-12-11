using ExerciseApplication.External;
using ExerciseApplication.Infrastructure;
using FluentAssertions;

namespace ExerciseApplication.Tests
{
    public class ExamplesApiTest
    {
        private readonly ExamplesApi _examplesApi;

        public ExamplesApiTest()
        {
            IFileManager mockFileManager = new ResourceFileManager();
            _examplesApi = new ExamplesApi(mockFileManager);
        }

        [Fact]
        public void GetUserShouldReturnUserContentAsJson()
        {
            var result = _examplesApi.GetUser(1);

            result.Should().NotBeNullOrWhiteSpace();
        }
    }
}