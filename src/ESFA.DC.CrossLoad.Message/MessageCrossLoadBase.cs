namespace ESFA.DC.CrossLoad.Message
{
    public abstract class MessageCrossLoadBase
    {
        protected MessageCrossLoadBase(
            long jobId,
            string storageContainerName,
            string storageFileName)
        {
            JobId = jobId;
            StorageContainerName = storageContainerName;
            StorageFileName = storageFileName;
        }

        public long JobId { get; private set; }

        public string StorageContainerName { get; private set; }

        public string StorageFileName { get; private set; }
    }
}
