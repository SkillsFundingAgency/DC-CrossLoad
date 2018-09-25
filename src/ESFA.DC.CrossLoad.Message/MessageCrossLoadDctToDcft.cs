namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDctToDcft : MessageCrossLoadBase
    {
        public MessageCrossLoadDctToDcft(
            long jobId,
            string ukPrn,
            string storageContainerName,
            string storageFileName,
            CrossLoadJobType jobType,
            string username,
            string storageContainerNameReport,
            string storageFileNameReport)
            : base(jobId, storageContainerName, storageFileName)
        {
            UkPrn = ukPrn;
            JobType = jobType;
            Username = username;
            StorageContainerNameReport = storageContainerNameReport;
            StorageFileNameReport = storageFileNameReport;
        }

        public string UkPrn { get; private set; }

        public CrossLoadJobType JobType { get; private set; }

        public string Username { get; private set; }

        public string StorageContainerNameReport { get; private set; }

        public string StorageFileNameReport { get; private set; }
    }
}
