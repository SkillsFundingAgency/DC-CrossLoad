namespace ESFA.DC.CrossLoad.Message
{
    public abstract class MessageCrossLoadBase
    {
        protected MessageCrossLoadBase(
            long jobId,
            string storageContainerName)
        {
            JobId = jobId;
            StorageContainerName = storageContainerName;
        }

        public long JobId { get; private set; }

        public string StorageContainerName { get; private set; }
    }
}
