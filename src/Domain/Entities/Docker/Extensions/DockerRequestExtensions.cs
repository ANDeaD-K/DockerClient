using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using Andead.DockerClient.Domain.Entities.Docker.Requests;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Andead.DockerClient.Domain.Entities.Docker.Extensions
{
    public static class DockerRequestExtensions
    {
        public static string GetUrlWithParameters(this DockerRequestBase request, string path)
        {
            var result = path;
            var regex = new Regex(@"\{\w*\}");

            if (regex.IsMatch(result))
            {
                var matches = regex.Matches(result);
                var properties = request.GetType().GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);

                foreach (var property in properties)
                {
                    var attribute = property.GetCustomAttribute<ParameterAttribute>(true);
                    var mathchedAttribute = matches.FirstOrDefault(x => x.Value.Contains(property.Name, System.StringComparison.InvariantCultureIgnoreCase));

                    if (attribute != null && mathchedAttribute != null)
                    {
                        result = ReplaceParameters(mathchedAttribute.Value, attribute, property.GetValue(request)?.ToString(), result);
                    }
                }
            }

            return result.TrimEnd('?').TrimEnd('&');
        }

        private static string ReplaceParameters(string attributeName, ParameterAttribute attribute, string propertyValue, string path)
        {
            if (attribute.Type == ParameterType.Path)
            {
                return path.Replace(attributeName, propertyValue);
            }

            if (!string.IsNullOrEmpty(propertyValue))
            {
                var clearNameRegex = new Regex(@"\{|\}");
                var propertyName = clearNameRegex.Replace(attributeName, string.Empty);
                return path.Replace(attributeName, $"{propertyName}={propertyValue}&");
            }

            return path.Replace(attributeName, string.Empty);
        }
    }
}
