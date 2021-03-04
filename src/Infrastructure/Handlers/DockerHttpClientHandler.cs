using Andead.DockerClient.Infrastructure.Extensions;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace Andead.DockerClient.Infrastructure.Handlers
{
    public class DockerHttpClientHandler : HttpClientHandler
    {
        public DockerHttpClientHandler(IConfiguration configuration)
        {
            var certificateFileName = configuration.GetCertificateFileName();

            if (!string.IsNullOrEmpty(certificateFileName))
            {
                var clientCertificate = new X509Certificate2(certificateFileName, configuration.GetCertificatePassword());
                ClientCertificates.Add(clientCertificate);

                ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => true;
            }
        }
    }
}
