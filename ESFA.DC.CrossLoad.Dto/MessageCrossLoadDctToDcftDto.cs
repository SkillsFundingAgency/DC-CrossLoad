using System;

namespace ESFA.DC.CrossLoad.Dto
{
    [Serializable]
    public sealed class MessageCrossLoadDctToDcftDto
    {
        public long JobId { get; set; }

        public string StorageContainerName { get; set; }

        public string StorageFileName { get; set; }

        public string UkPrn { get; set; }

        public byte JobType { get; set; }

        public string Username { get; set; }
    }
}
