using ESFA.DC.CrossLoad.Dto;
using ESFA.DC.CrossLoad.Interface;
using ESFA.DC.CrossLoad.Message;

namespace ESFA.DC.CrossLoad
{
    public sealed class CrossLoadMessageMapper : ICrossLoadMessageMapper
    {
        public MessageCrossLoadDcftToDct FromDto(MessageCrossLoadDcftToDctDto dto)
        {
            return new MessageCrossLoadDcftToDct(dto.JobId, dto.StorageContainerName, dto.StorageFileName, dto.ErrorMessage);
        }

        public MessageCrossLoadDctToDcft FromDto(MessageCrossLoadDctToDcftDto dto)
        {
            return new MessageCrossLoadDctToDcft(
                dto.JobId,
                dto.UkPrn,
                dto.StorageContainerName,
                dto.StorageFileName,
                (CrossLoadJobType)dto.JobType,
                dto.Username,
                dto.StorageContainerNameReport,
                dto.StorageFileNameReport);
        }

        public MessageCrossLoadDcftToDctDto FromMessage(MessageCrossLoadDcftToDct dto)
        {
            return new MessageCrossLoadDcftToDctDto
            {
                JobId = dto.JobId,
                StorageFileName = dto.StorageFileName,
                StorageContainerName = dto.StorageContainerName,
                ErrorMessage = dto.ErrorMessage
            };
        }

        public MessageCrossLoadDctToDcftDto FromMessage(MessageCrossLoadDctToDcft dto)
        {
            return new MessageCrossLoadDctToDcftDto
            {
                JobId = dto.JobId,
                StorageFileName = dto.StorageFileName,
                StorageContainerName = dto.StorageContainerName,
                JobType = (byte)dto.JobType,
                UkPrn = dto.UkPrn,
                Username = dto.Username,
                StorageContainerNameReport = dto.StorageContainerNameReport,
                StorageFileNameReport = dto.StorageFileNameReport
            };
        }
    }
}
