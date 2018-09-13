namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDcftToDct : MessageCrossLoadBase
    {
        public MessageCrossLoadDcftToDct(
            long jobId,
            string storageContainerName,
            string storageFileName)
            : base(jobId, storageContainerName, storageFileName)
        {
        }
    }
}
