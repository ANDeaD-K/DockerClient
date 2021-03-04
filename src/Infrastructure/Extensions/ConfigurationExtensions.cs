using Microsoft.Extensions.Configuration;

namespace Andead.DockerClient.Infrastructure.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetDockerHost(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("DockerHost");
        }

        public static string GetCertificateFileName(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("CertificateFileName");
        }

        public static string GetCertificatePassword(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("CertificatePassword");
        }
    }
}
