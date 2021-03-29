using Newtonsoft.Json;

namespace Andead.DockerClient.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string ToIndentedJSONString(this string value)
        {
            var parsedJson = JsonConvert.DeserializeObject(value);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }
    }
}
