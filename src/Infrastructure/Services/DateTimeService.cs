using Andead.DockerClient.Application.Common.Interfaces;
using System;

namespace Andead.DockerClient.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
