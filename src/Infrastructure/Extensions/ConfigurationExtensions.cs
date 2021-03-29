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

        public static string GetElasticUrl(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("ElasticUrl") ?? "http://localhost:9200";
        }

        public static string GetElasticUsername(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("ElasticUsername");
        }

        public static string GetElasticPassword(this IConfiguration configuration)
        {
            return configuration.GetValue<string>("ElasticPassword");
        }
    }
}
