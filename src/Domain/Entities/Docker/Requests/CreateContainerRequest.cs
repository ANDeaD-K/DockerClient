using Andead.DockerClient.Domain.Entities.Docker.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;

namespace Andead.DockerClient.Domain.Entities.Docker.Requests
{
    [DataContract]
    public class Labels
    {
    }

    [DataContract]
    public class VolumesData
    {
    }

    [DataContract]
    public class Volumes
    {
    }

    [DataContract]
    public class BlkioWeightDevice
    {
    }

    [DataContract]
    public class BlkioDeviceReadBp
    {
    }

    [DataContract]
    public class BlkioDeviceReadIOp
    {
    }

    [DataContract]
    public class BlkioDeviceWriteBp
    {
    }

    [DataContract]
    public class BlkioDeviceWriteIOp
    {
    }

    [DataContract]
    public class Options
    {
    }

    [DataContract]
    public class DeviceRequest
    {
        [DataMember(Name = "Driver")]
        public string Driver { get; set; }

        [DataMember(Name = "Count")]
        public int Count { get; set; }

        [DataMember(Name = "DeviceIDs")]
        public IList<string> DeviceIDs { get; set; }

        [DataMember(Name = "Capabilities")]
        public IList<IList<string>> Capabilities { get; set; }

        [DataMember(Name = "Options")]
        public Options Options { get; set; }
    }

    [DataContract]
    public class PortBindings
    {
    }

    [DataContract]
    public class RestartPolicy
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "MaximumRetryCount")]
        public int MaximumRetryCount { get; set; }
    }

    [DataContract]
    public class Ulimit
    {
    }

    [DataContract]
    public class Config
    {
    }

    [DataContract]
    public class LogConfig
    {

        [DataMember(Name = "Type")]
        public string Type { get; set; }

        [DataMember(Name = "Config")]
        public Config Config { get; set; }
    }

    [DataContract]
    public class StorageOpt
    {
    }

    [DataContract]
    public class HostConfig
    {

        [DataMember(Name = "Binds")]
        public IList<string> Binds { get; set; }

        [DataMember(Name = "Links")]
        public IList<string> Links { get; set; }

        [DataMember(Name = "Memory")]
        public int Memory { get; set; }

        [DataMember(Name = "MemorySwap")]
        public int MemorySwap { get; set; }

        [DataMember(Name = "MemoryReservation")]
        public int MemoryReservation { get; set; }

        [DataMember(Name = "KernelMemory")]
        public int KernelMemory { get; set; }

        [DataMember(Name = "NanoCpus")]
        public int NanoCpus { get; set; }

        [DataMember(Name = "CpuPercent")]
        public int CpuPercent { get; set; }

        [DataMember(Name = "CpuShares")]
        public int CpuShares { get; set; }

        [DataMember(Name = "CpuPeriod")]
        public int CpuPeriod { get; set; }

        [DataMember(Name = "CpuRealtimePeriod")]
        public int CpuRealtimePeriod { get; set; }

        [DataMember(Name = "CpuRealtimeRuntime")]
        public int CpuRealtimeRuntime { get; set; }

        [DataMember(Name = "CpuQuota")]
        public int CpuQuota { get; set; }

        [DataMember(Name = "CpusetCpus")]
        public string CpusetCpus { get; set; }

        [DataMember(Name = "CpusetMems")]
        public string CpusetMems { get; set; }

        [DataMember(Name = "MaximumIOps")]
        public int MaximumIOps { get; set; }

        [DataMember(Name = "MaximumIOBps")]
        public int MaximumIOBps { get; set; }

        [DataMember(Name = "BlkioWeight")]
        public int BlkioWeight { get; set; }

        [DataMember(Name = "BlkioWeightDevice")]
        public IList<BlkioWeightDevice> BlkioWeightDevice { get; set; }

        [DataMember(Name = "BlkioDeviceReadBps")]
        public IList<BlkioDeviceReadBp> BlkioDeviceReadBps { get; set; }

        [DataMember(Name = "BlkioDeviceReadIOps")]
        public IList<BlkioDeviceReadIOp> BlkioDeviceReadIOps { get; set; }

        [DataMember(Name = "BlkioDeviceWriteBps")]
        public IList<BlkioDeviceWriteBp> BlkioDeviceWriteBps { get; set; }

        [DataMember(Name = "BlkioDeviceWriteIOps")]
        public IList<BlkioDeviceWriteIOp> BlkioDeviceWriteIOps { get; set; }

        [DataMember(Name = "DeviceRequests")]
        public IList<DeviceRequest> DeviceRequests { get; set; }

        [DataMember(Name = "MemorySwappiness")]
        public int MemorySwappiness { get; set; }

        [DataMember(Name = "OomKillDisable")]
        public bool OomKillDisable { get; set; }

        [DataMember(Name = "OomScoreAdj")]
        public int OomScoreAdj { get; set; }

        [DataMember(Name = "PidMode")]
        public string PidMode { get; set; }

        [DataMember(Name = "PidsLimit")]
        public int PidsLimit { get; set; }

        [DataMember(Name = "PortBindings")]
        public PortBindings PortBindings { get; set; }

        [DataMember(Name = "PublishAllPorts")]
        public bool PublishAllPorts { get; set; }

        [DataMember(Name = "Privileged")]
        public bool Privileged { get; set; }

        [DataMember(Name = "ReadonlyRootfs")]
        public bool ReadonlyRootfs { get; set; }

        [DataMember(Name = "Dns")]
        public IList<string> Dns { get; set; }

        [DataMember(Name = "DnsOptions")]
        public IList<string> DnsOptions { get; set; }

        [DataMember(Name = "DnsSearch")]
        public IList<string> DnsSearch { get; set; }

        [DataMember(Name = "VolumesFrom")]
        public IList<string> VolumesFrom { get; set; }

        [DataMember(Name = "CapAdd")]
        public IList<string> CapAdd { get; set; }

        [DataMember(Name = "CapDrop")]
        public IList<string> CapDrop { get; set; }

        [DataMember(Name = "GroupAdd")]
        public IList<string> GroupAdd { get; set; }

        [DataMember(Name = "RestartPolicy")]
        public RestartPolicy RestartPolicy { get; set; }

        [DataMember(Name = "AutoRemove")]
        public bool AutoRemove { get; set; }

        [DataMember(Name = "NetworkMode")]
        public string NetworkMode { get; set; }

        [DataMember(Name = "Devices")]
        public IList<object> Devices { get; set; }

        [DataMember(Name = "Ulimits")]
        public IList<Ulimit> Ulimits { get; set; }

        [DataMember(Name = "LogConfig")]
        public LogConfig LogConfig { get; set; }

        [DataMember(Name = "SecurityOpt")]
        public IList<object> SecurityOpt { get; set; }

        [DataMember(Name = "StorageOpt")]
        public StorageOpt StorageOpt { get; set; }

        [DataMember(Name = "CgroupParent")]
        public string CgroupParent { get; set; }

        [DataMember(Name = "VolumeDriver")]
        public string VolumeDriver { get; set; }

        [DataMember(Name = "ShmSize")]
        public int ShmSize { get; set; }
    }

    [DataContract]
    public class IPAMConfig
    {
        [DataMember(Name = "IPv4Address")]
        public string IPv4Address { get; set; }

        [DataMember(Name = "IPv6Address")]
        public string IPv6Address { get; set; }

        [DataMember(Name = "LinkLocalIPs")]
        public IList<string> LinkLocalIPs { get; set; }
    }

    [DataContract]
    public class IsolatedNw
    {
        [DataMember(Name = "IPAMConfig")]
        public IPAMConfig IPAMConfig { get; set; }

        [DataMember(Name = "Links")]
        public IList<string> Links { get; set; }

        [DataMember(Name = "Aliases")]
        public IList<string> Aliases { get; set; }
    }

    [DataContract]
    public class EndpointsConfig
    {
        [DataMember(Name = "isolated_nw")]
        public IsolatedNw isolated_nw { get; set; }
    }

    [DataContract]
    public class NetworkingConfig
    {
        [DataMember(Name = "EndpointsConfig")]
        public EndpointsConfig EndpointsConfig { get; set; }
    }

    public class CreateContainerRequest : DockerRequestBase
    {
        [Parameter(ParameterType.Query)]
        [JsonIgnore]
        public string Name { get; set; }

        public override string Path => "containers/create?{name}";

        public override HttpMethod HttpMethod => HttpMethod.Post;

        public override bool EmptyRequestBody => false;

        [DataMember(Name = "Hostname")]
        public string Hostname { get; set; }

        [DataMember(Name = "Domainname")]
        public string Domainname { get; set; }

        [DataMember(Name = "User")]
        public string User { get; set; }

        [DataMember(Name = "AttachStdin")]
        public bool AttachStdin { get; set; }

        [DataMember(Name = "AttachStdout")]
        public bool AttachStdout { get; set; }

        [DataMember(Name = "AttachStderr")]
        public bool AttachStderr { get; set; }

        [DataMember(Name = "Tty")]
        public bool Tty { get; set; }

        [DataMember(Name = "OpenStdin")]
        public bool OpenStdin { get; set; }

        [DataMember(Name = "StdinOnce")]
        public bool StdinOnce { get; set; }

        [DataMember(Name = "Env")]
        public IList<string> Env { get; set; }

        [DataMember(Name = "Cmd")]
        public IList<string> Cmd { get; set; }

        [DataMember(Name = "Entrypoint")]
        public string Entrypoint { get; set; }

        [DataMember(Name = "Image")]
        public string Image { get; set; }

        [DataMember(Name = "Labels")]
        public Labels Labels { get; set; }

        [DataMember(Name = "Volumes")]
        public Volumes Volumes { get; set; }

        [DataMember(Name = "WorkingDir")]
        public string WorkingDir { get; set; }

        [DataMember(Name = "NetworkDisabled")]
        public bool NetworkDisabled { get; set; }

        [DataMember(Name = "MacAddress")]
        public string MacAddress { get; set; }

        [DataMember(Name = "ExposedPorts")]
        public IDictionary<string, object> ExposedPorts { get; set; }

        [DataMember(Name = "StopSignal")]
        public string StopSignal { get; set; }

        [DataMember(Name = "StopTimeout")]
        public int StopTimeout { get; set; }

        [DataMember(Name = "HostConfig")]
        public HostConfig HostConfig { get; set; }

        [DataMember(Name = "NetworkingConfig")]
        public NetworkingConfig NetworkingConfig { get; set; }
    }
}
