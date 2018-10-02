using System;

namespace ESFA.DC.CrossLoad.Dto
{
    [Serializable]
    public sealed class MessageCrossLoadDctToDcftDto
    {
        /// <summary>
        /// Unique job id of job.
        /// </summary>
        public long JobId { get; set; }

        /// <summary>
        /// The storage container where the input file is stored and report saved to.
        /// </summary>
        public string StorageContainerName { get; set; }

        /// <summary>
        /// The file name of the input file.
        /// </summary>
        public string StorageFileName { get; set; }

        /// <summary>
        /// The requested file name of the report zip file 1.
        /// </summary>
        public string StorageFileNameReport1 { get; set; }

        /// <summary>
        /// The requested file name of the report zip file 1.
        /// </summary>
        public string StorageFileNameReport2 { get; set; }

        /// <summary>
        /// The UkPrn of the user.
        /// </summary>
        public long UkPrn { get; set; }

        /// <summary>
        /// The job type of this job (see CrossLoadJobType enum).
        /// </summary>
        public byte JobType { get; set; }

        /// <summary>
        /// The username of the user who created the job.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The upin of the user.
        /// </summary>
        public long Upin { get; set; }
    }
}
