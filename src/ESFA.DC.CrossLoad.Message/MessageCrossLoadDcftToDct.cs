namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDcftToDct : MessageCrossLoadBase
    {
        public MessageCrossLoadDcftToDct(
            long jobId,
            string dcftJobId,
            string storageContainerName,
            string storageFileNameReport1,
            string storageFileNameReport2,
            string errorMessage)
            : base(jobId, storageContainerName)
        {
            ErrorMessage = errorMessage;
            DcftJobId = dcftJobId;
            StorageFileNameReport1 = storageFileNameReport1;
            StorageFileNameReport2 = storageFileNameReport2;
        }

        public string ErrorMessage { get; private set; }

        public string DcftJobId { get; private set; }

        public string StorageFileNameReport1 { get; private set; }

        public string StorageFileNameReport2 { get; private set; }
    }
}
