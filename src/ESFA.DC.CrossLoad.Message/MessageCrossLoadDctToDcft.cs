namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDctToDcft : MessageCrossLoadBase
    {
        public MessageCrossLoadDctToDcft(
            long jobId,
            long ukprn,
            long upin,
            string storageContainerName,
            string storageFileName,
            CrossLoadJobType jobType,
            string username,
            string storageContainerNameReport,
            string storageFileNameReport)
            : base(jobId, storageContainerName, storageFileName)
        {
            UkPrn = ukprn;
            Upin = upin;
            JobType = jobType;
            Username = username;
            StorageContainerNameReport = storageContainerNameReport;
            StorageFileNameReport = storageFileNameReport;
        }

        public long UkPrn { get; private set; }

        public long Upin { get; private set; }

        public CrossLoadJobType JobType { get; private set; }

        public string Username { get; private set; }

        public string StorageContainerNameReport { get; private set; }

        public string StorageFileNameReport { get; private set; }
    }
}
