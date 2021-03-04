using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Andead.DockerClient.Domain.Entities.Docker.Responses
{
    [DataContract]
    public class Port
    {
        [DataMember(Name = "PrivatePort")]
        public int PrivatePort { get; set; }

        [DataMember(Name = "PublicPort")]
        public int PublicPort { get; set; }

        [DataMember(Name = "Type")]
        public string Type { get; set; }
    }

    [DataContract]
    public class HostConfig
    {
        [DataMember(Name = "NetworkMode")]
        public string NetworkMode { get; set; }
    }

    [DataContract]
    public class Bridge
    {
        [DataMember(Name = "NetworkID")]
        public string NetworkID { get; set; }

        [DataMember(Name = "EndpointID")]
        public string EndpointID { get; set; }

        [DataMember(Name = "Gateway")]
        public string Gateway { get; set; }

        [DataMember(Name = "IPAddress")]
        public string IPAddress { get; set; }

        [DataMember(Name = "IPPrefixLen")]
        public int IPPrefixLen { get; set; }

        [DataMember(Name = "IPv6Gateway")]
        public string IPv6Gateway { get; set; }

        [DataMember(Name = "GlobalIPv6Address")]
        public string GlobalIPv6Address { get; set; }

        [DataMember(Name = "GlobalIPv6PrefixLen")]
        public int GlobalIPv6PrefixLen { get; set; }

        [DataMember(Name = "MacAddress")]
        public string MacAddress { get; set; }
    }

    [DataContract]
    public class Networks
    {

        [DataMember(Name = "bridge")]
        public Bridge bridge { get; set; }
    }

    [DataContract]
    public class NetworkSettings
    {
        [DataMember(Name = "Networks")]
        public Networks Networks { get; set; }
    }

    [DataContract]
    public class Mount
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Source")]
        public string Source { get; set; }

        [DataMember(Name = "Destination")]
        public string Destination { get; set; }

        [DataMember(Name = "Driver")]
        public string Driver { get; set; }

        [DataMember(Name = "Mode")]
        public string Mode { get; set; }

        [DataMember(Name = "RW")]
        public bool RW { get; set; }

        [DataMember(Name = "Propagation")]
        public string Propagation { get; set; }
    }

    [DataContract]
    public class ListContainersResponse
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "Names")]
        public IList<string> Names { get; set; }

        [DataMember(Name = "Image")]
        public string Image { get; set; }

        [DataMember(Name = "ImageID")]
        public string ImageID { get; set; }

        [DataMember(Name = "Command")]
        public string Command { get; set; }

        [DataMember(Name = "Created")]
        public int Created { get; set; }

        [DataMember(Name = "State")]
        public string State { get; set; }

        [DataMember(Name = "Status")]
        public string Status { get; set; }

        [DataMember(Name = "Ports")]
        public IList<Port> Ports { get; set; }

        [DataMember(Name = "Labels")]
        public Labels Labels { get; set; }

        [DataMember(Name = "SizeRw")]
        public int SizeRw { get; set; }

        [DataMember(Name = "SizeRootFs")]
        public int SizeRootFs { get; set; }

        [DataMember(Name = "HostConfig")]
        public HostConfig HostConfig { get; set; }

        [DataMember(Name = "NetworkSettings")]
        public NetworkSettings NetworkSettings { get; set; }

        [DataMember(Name = "Mounts")]
        public IList<Mount> Mounts { get; set; }
    
    }
}
