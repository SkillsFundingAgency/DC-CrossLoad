using System;

namespace ESFA.DC.CrossLoad.Dto
{
    [Serializable]
    public sealed class MessageCrossLoadDcftToDctDto
    {
        public long JobId { get; set; }

        public string StorageContainerName { get; set; }

        public string StorageFileName { get; set; }
    }
}
