using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Andead.DockerClient.Domain.Entities.Docker.Responses
{
    [DataContract]
    public class Plugins
    {
        [DataMember(Name = "Volume")]
        public IList<string> Volume { get; set; }

        [DataMember(Name = "Network")]
        public IList<string> Network { get; set; }

        [DataMember(Name = "Authorization")]
        public IList<string> Authorization { get; set; }

        [DataMember(Name = "Log")]
        public IList<string> Log { get; set; }
    }

    [DataContract]
    public class IndexConfigs
    {
    }

    [DataContract]
    public class RegistryConfig
    {
        [DataMember(Name = "AllowNondistributableArtifactsCIDRs")]
        public IList<string> AllowNondistributableArtifactsCIDRs { get; set; }

        [DataMember(Name = "AllowNondistributableArtifactsHostnames")]
        public IList<string> AllowNondistributableArtifactsHostnames { get; set; }

        [DataMember(Name = "InsecureRegistryCIDRs")]
        public IList<string> InsecureRegistryCIDRs { get; set; }

        [DataMember(Name = "IndexConfigs")]
        public IndexConfigs IndexConfigs { get; set; }

        [DataMember(Name = "Mirrors")]
        public IList<string> Mirrors { get; set; }
    }

    [DataContract]
    public class DiscreteResourceSpec
    {
        [DataMember(Name = "Kind")]
        public string Kind { get; set; }

        [DataMember(Name = "Value")]
        public int Value { get; set; }
    }

    [DataContract]
    public class NamedResourceSpec
    {
        [DataMember(Name = "Kind")]
        public string Kind { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class GenericResource
    {
        [DataMember(Name = "DiscreteResourceSpec")]
        public DiscreteResourceSpec DiscreteResourceSpec { get; set; }

        [DataMember(Name = "NamedResourceSpec")]
        public NamedResourceSpec NamedResourceSpec { get; set; }
    }

    [DataContract]
    public class Runc
    {
        [DataMember(Name = "path")]
        public string Path { get; set; }
    }

    [DataContract]
    public class RuncMaster
    {
        [DataMember(Name = "path")]
        public string Path { get; set; }
    }

    [DataContract]
    public class Custom
    {
        [DataMember(Name = "path")]
        public string Path { get; set; }

        [DataMember(Name = "runtimeArgs")]
        public IList<string> RuntimeArgs { get; set; }
    }

    [DataContract]
    public class Runtimes
    {
        [DataMember(Name = "runc")]
        public Runc Runc { get; set; }

        [DataMember(Name = "runc-master")]
        public RuncMaster RuncMaster { get; set; }

        [DataMember(Name = "custom")]
        public Custom Custom { get; set; }
    }

    [DataContract]
    public class RemoteManager
    {
        [DataMember(Name = "NodeID")]
        public string NodeID { get; set; }

        [DataMember(Name = "Addr")]
        public string Addr { get; set; }
    }

    [DataContract]
    public class Version
    {
        [DataMember(Name = "Index")]
        public int Index { get; set; }
    }

    [DataContract]
    public class Labels
    {
    }

    [DataContract]
    public class Orchestration
    {
        [DataMember(Name = "TaskHistoryRetentionLimit")]
        public int TaskHistoryRetentionLimit { get; set; }
    }

    [DataContract]
    public class Raft
    {
        [DataMember(Name = "SnapshotInterval")]
        public int SnapshotInterval { get; set; }

        [DataMember(Name = "KeepOldSnapshots")]
        public int KeepOldSnapshots { get; set; }

        [DataMember(Name = "LogEntriesForSlowFollowers")]
        public int LogEntriesForSlowFollowers { get; set; }

        [DataMember(Name = "ElectionTick")]
        public int ElectionTick { get; set; }

        [DataMember(Name = "HeartbeatTick")]
        public int HeartbeatTick { get; set; }
    }

    [DataContract]
    public class Dispatcher
    {
        [DataMember(Name = "HeartbeatPeriod")]
        public long HeartbeatPeriod { get; set; }
    }

    [DataContract]
    public class Options
    {
        [DataMember(Name = "property1")]
        public string Property1 { get; set; }

        [DataMember(Name = "property2")]
        public string Property2 { get; set; }
    }

    [DataContract]
    public class ExternalCA
    {
        [DataMember(Name = "Protocol")]
        public string Protocol { get; set; }

        [DataMember(Name = "URL")]
        public string URL { get; set; }

        [DataMember(Name = "Options")]
        public Options Options { get; set; }

        [DataMember(Name = "CACert")]
        public string CACert { get; set; }
    }

    [DataContract]
    public class CAConfig
    {

        [DataMember(Name = "NodeCertExpiry")]
        public long NodeCertExpiry { get; set; }

        [DataMember(Name = "ExternalCAs")]
        public IList<ExternalCA> ExternalCAs { get; set; }

        [DataMember(Name = "SigningCACert")]
        public string SigningCACert { get; set; }

        [DataMember(Name = "SigningCAKey")]
        public string SigningCAKey { get; set; }

        [DataMember(Name = "ForceRotate")]
        public int ForceRotate { get; set; }
    }

    [DataContract]
    public class EncryptionConfig
    {
        [DataMember(Name = "AutoLockManagers")]
        public bool AutoLockManagers { get; set; }
    }

    [DataContract]
    public class LogDriver
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Options")]
        public Options Options { get; set; }
    }

    [DataContract]
    public class TaskDefaults
    {
        [DataMember(Name = "LogDriver")]
        public LogDriver LogDriver { get; set; }
    }

    [DataContract]
    public class Spec
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Labels")]
        public Labels Labels { get; set; }

        [DataMember(Name = "Orchestration")]
        public Orchestration Orchestration { get; set; }

        [DataMember(Name = "Raft")]
        public Raft Raft { get; set; }

        [DataMember(Name = "Dispatcher")]
        public Dispatcher Dispatcher { get; set; }

        [DataMember(Name = "CAConfig")]
        public CAConfig CAConfig { get; set; }

        [DataMember(Name = "EncryptionConfig")]
        public EncryptionConfig EncryptionConfig { get; set; }

        [DataMember(Name = "TaskDefaults")]
        public TaskDefaults TaskDefaults { get; set; }
    }

    [DataContract]
    public class TLSInfo
    {

        [DataMember(Name = "TrustRoot")]
        public string TrustRoot { get; set; }

        [DataMember(Name = "CertIssuerSubject")]
        public string CertIssuerSubject { get; set; }

        [DataMember(Name = "CertIssuerPublicKey")]
        public string CertIssuerPublicKey { get; set; }
    }

    [DataContract]
    public class Cluster
    {

        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Version")]
        public Version Version { get; set; }

        [DataMember(Name = "CreatedAt")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "UpdatedAt")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "Spec")]
        public Spec Spec { get; set; }

        [DataMember(Name = "TLSInfo")]
        public TLSInfo TLSInfo { get; set; }

        [DataMember(Name = "RootRotationInProgress")]
        public bool RootRotationInProgress { get; set; }

        [DataMember(Name = "DataPathPort")]
        public int DataPathPort { get; set; }

        [DataMember(Name = "DefaultAddrPool")]
        public IList<IList<string>> DefaultAddrPool { get; set; }

        [DataMember(Name = "SubnetSize")]
        public int SubnetSize { get; set; }
    }

    [DataContract]
    public class Swarm
    {

        [DataMember(Name = "NodeID")]
        public string NodeID { get; set; }

        [DataMember(Name = "NodeAddr")]
        public string NodeAddr { get; set; }

        [DataMember(Name = "LocalNodeState")]
        public string LocalNodeState { get; set; }

        [DataMember(Name = "ControlAvailable")]
        public bool ControlAvailable { get; set; }

        [DataMember(Name = "Error")]
        public string Error { get; set; }

        [DataMember(Name = "RemoteManagers")]
        public IList<RemoteManager> RemoteManagers { get; set; }

        [DataMember(Name = "Nodes")]
        public int Nodes { get; set; }

        [DataMember(Name = "Managers")]
        public int Managers { get; set; }

        [DataMember(Name = "Cluster")]
        public Cluster Cluster { get; set; }
    }

    [DataContract]
    public class ContainerdCommit
    {
        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Expected")]
        public string Expected { get; set; }
    }

    [DataContract]
    public class RuncCommit
    {
        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Expected")]
        public string Expected { get; set; }
    }

    [DataContract]
    public class InitCommit
    {
        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Expected")]
        public string Expected { get; set; }
    }

    [DataContract]
    public class DefaultAddressPool
    {
        [DataMember(Name = "Base")]
        public string Base { get; set; }

        [DataMember(Name = "Size")]
        public string Size { get; set; }
    }

    [DataContract]
    public class SystemInformationResponse
    {
        [DataMember(Name = "ID")]
        public string ID { get; set; }

        [DataMember(Name = "Containers")]
        public int Containers { get; set; }

        [DataMember(Name = "ContainersRunning")]
        public int ContainersRunning { get; set; }

        [DataMember(Name = "ContainersPaused")]
        public int ContainersPaused { get; set; }

        [DataMember(Name = "ContainersStopped")]
        public int ContainersStopped { get; set; }

        [DataMember(Name = "Images")]
        public int Images { get; set; }

        [DataMember(Name = "Driver")]
        public string Driver { get; set; }

        [DataMember(Name = "DriverStatus")]
        public IList<IList<string>> DriverStatus { get; set; }

        [DataMember(Name = "DockerRootDir")]
        public string DockerRootDir { get; set; }

        [DataMember(Name = "Plugins")]
        public Plugins Plugins { get; set; }

        [DataMember(Name = "MemoryLimit")]
        public bool MemoryLimit { get; set; }

        [DataMember(Name = "SwapLimit")]
        public bool SwapLimit { get; set; }

        [DataMember(Name = "KernelMemory")]
        public bool KernelMemory { get; set; }

        [DataMember(Name = "CpuCfsPeriod")]
        public bool CpuCfsPeriod { get; set; }

        [DataMember(Name = "CpuCfsQuota")]
        public bool CpuCfsQuota { get; set; }

        [DataMember(Name = "CPUShares")]
        public bool CPUShares { get; set; }

        [DataMember(Name = "CPUSet")]
        public bool CPUSet { get; set; }

        [DataMember(Name = "PidsLimit")]
        public bool PidsLimit { get; set; }

        [DataMember(Name = "OomKillDisable")]
        public bool OomKillDisable { get; set; }

        [DataMember(Name = "IPv4Forwarding")]
        public bool IPv4Forwarding { get; set; }

        [DataMember(Name = "BridgeNfIptables")]
        public bool BridgeNfIptables { get; set; }

        [DataMember(Name = "BridgeNfIp6tables")]
        public bool BridgeNfIp6tables { get; set; }

        [DataMember(Name = "Debug")]
        public bool Debug { get; set; }

        [DataMember(Name = "NFd")]
        public int NFd { get; set; }

        [DataMember(Name = "NGoroutines")]
        public int NGoroutines { get; set; }

        [DataMember(Name = "SystemTime")]
        public string SystemTime { get; set; }

        [DataMember(Name = "LoggingDriver")]
        public string LoggingDriver { get; set; }

        [DataMember(Name = "CgroupDriver")]
        public string CgroupDriver { get; set; }

        [DataMember(Name = "CgroupVersion")]
        public string CgroupVersion { get; set; }

        [DataMember(Name = "NEventsListener")]
        public int NEventsListener { get; set; }

        [DataMember(Name = "KernelVersion")]
        public string KernelVersion { get; set; }

        [DataMember(Name = "OperatingSystem")]
        public string OperatingSystem { get; set; }

        [DataMember(Name = "OSVersion")]
        public string OSVersion { get; set; }

        [DataMember(Name = "OSType")]
        public string OSType { get; set; }

        [DataMember(Name = "Architecture")]
        public string Architecture { get; set; }

        [DataMember(Name = "NCPU")]
        public int NCPU { get; set; }

        [DataMember(Name = "MemTotal")]
        public int MemTotal { get; set; }

        [DataMember(Name = "IndexServerAddress")]
        public string IndexServerAddress { get; set; }

        [DataMember(Name = "RegistryConfig")]
        public RegistryConfig RegistryConfig { get; set; }

        [DataMember(Name = "GenericResources")]
        public IList<GenericResource> GenericResources { get; set; }

        [DataMember(Name = "HttpProxy")]
        public string HttpProxy { get; set; }

        [DataMember(Name = "HttpsProxy")]
        public string HttpsProxy { get; set; }

        [DataMember(Name = "NoProxy")]
        public string NoProxy { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Labels")]
        public IList<string> Labels { get; set; }

        [DataMember(Name = "ExperimentalBuild")]
        public bool ExperimentalBuild { get; set; }

        [DataMember(Name = "ServerVersion")]
        public string ServerVersion { get; set; }

        [DataMember(Name = "ClusterStore")]
        public string ClusterStore { get; set; }

        [DataMember(Name = "ClusterAdvertise")]
        public string ClusterAdvertise { get; set; }

        [DataMember(Name = "Runtimes")]
        public Runtimes Runtimes { get; set; }

        [DataMember(Name = "DefaultRuntime")]
        public string DefaultRuntime { get; set; }

        [DataMember(Name = "Swarm")]
        public Swarm Swarm { get; set; }

        [DataMember(Name = "LiveRestoreEnabled")]
        public bool LiveRestoreEnabled { get; set; }

        [DataMember(Name = "Isolation")]
        public string Isolation { get; set; }

        [DataMember(Name = "InitBinary")]
        public string InitBinary { get; set; }

        [DataMember(Name = "ContainerdCommit")]
        public ContainerdCommit ContainerdCommit { get; set; }

        [DataMember(Name = "RuncCommit")]
        public RuncCommit RuncCommit { get; set; }

        [DataMember(Name = "InitCommit")]
        public InitCommit InitCommit { get; set; }

        [DataMember(Name = "SecurityOptions")]
        public IList<string> SecurityOptions { get; set; }

        [DataMember(Name = "ProductLicense")]
        public string ProductLicense { get; set; }

        [DataMember(Name = "DefaultAddressPools")]
        public IList<DefaultAddressPool> DefaultAddressPools { get; set; }

        [DataMember(Name = "Warnings")]
        public IList<string> Warnings { get; set; }
    }
}
