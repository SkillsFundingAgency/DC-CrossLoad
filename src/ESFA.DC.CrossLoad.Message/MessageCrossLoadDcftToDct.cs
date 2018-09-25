namespace ESFA.DC.CrossLoad.Message
{
    public sealed class MessageCrossLoadDcftToDct : MessageCrossLoadBase
    {
        public MessageCrossLoadDcftToDct(
            long jobId,
            string storageContainerName,
            string storageFileName,
            string errorMessage)
            : base(jobId, storageContainerName, storageFileName)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; private set; }
    }
}
