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
            string storageFileNameReport1,
            string storageFileNameReport2)
            : base(jobId, storageContainerName)
        {
            UkPrn = ukprn;
            Upin = upin;
            StorageFileName = storageFileName;
            JobType = jobType;
            Username = username;
            StorageFileNameReport1 = storageFileNameReport1;
            StorageFileNameReport2 = storageFileNameReport2;
        }

        public long UkPrn { get; private set; }

        public long Upin { get; private set; }

        public CrossLoadJobType JobType { get; private set; }

        public string Username { get; private set; }

        public string StorageFileName { get; private set; }

        public string StorageFileNameReport1 { get; private set; }

        public string StorageFileNameReport2 { get; private set; }
    }
}
