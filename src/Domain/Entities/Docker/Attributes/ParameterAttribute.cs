using System;

namespace Andead.DockerClient.Domain.Entities.Docker.Attributes
{
    public enum ParameterType
    {
        Path = 0,
        Query
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ParameterAttribute : Attribute
    {
        public readonly ParameterType Type;

        public ParameterAttribute(ParameterType type)
        {
            Type = type;
        }
    }
}
