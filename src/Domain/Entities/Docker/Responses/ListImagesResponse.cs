using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Andead.DockerClient.Domain.Entities.Docker.Responses
{
    [DataContract]
    public class ListImagesResponse
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "ParentId")]
        public string ParentId { get; set; }

        [DataMember(Name = "RepoTags")]
        public IList<string> RepoTags { get; set; }

        [DataMember(Name = "RepoDigests")]
        public IList<string> RepoDigests { get; set; }

        [DataMember(Name = "Created")]
        public int Created { get; set; }

        [DataMember(Name = "Size")]
        public int Size { get; set; }

        [DataMember(Name = "VirtualSize")]
        public int VirtualSize { get; set; }

        [DataMember(Name = "SharedSize")]
        public int SharedSize { get; set; }

        [DataMember(Name = "Labels")]
        public Labels Labels { get; set; }

        [DataMember(Name = "Containers")]
        public int Containers { get; set; }
    }
}
