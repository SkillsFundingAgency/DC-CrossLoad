using System;

namespace ESFA.DC.CrossLoad.Dto
{
    [Serializable]
    public sealed class MessageCrossLoadDcftToDctDto
    {
        /// <summary>
        /// Unique job id of job.
        /// </summary>
        public long JobId { get; set; }

        /// <summary>
        /// [Optional] An error message if the job failed.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The storage container where the report zip file is stored.
        /// </summary>
        public string StorageContainerName { get; set; }

        /// <summary>
        /// The file name of the report zip file 1.
        /// </summary>
        public string StorageFileNameReport1 { get; set; }

        /// <summary>
        /// The file name of the report zip file 2.
        /// </summary>
        public string StorageFileNameReport2 { get; set; }

        /// <summary>
        /// dcft system job id for reference
        /// </summary>
        public string DcftJobId { get; set; }
    }
}
