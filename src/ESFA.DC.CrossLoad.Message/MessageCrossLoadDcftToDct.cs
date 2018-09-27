namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDcftToDct : MessageCrossLoadBase
    {
        public MessageCrossLoadDcftToDct(
            long jobId,
            string dcftJobId,
            string storageContainerName,
            string storageFileName,
            string errorMessage)
            : base(jobId, storageContainerName, storageFileName)
        {
            ErrorMessage = errorMessage;
            DcftJobId = dcftJobId;
        }

        public string ErrorMessage { get; private set; }

        public string DcftJobId { get; private set; }
    }
}
