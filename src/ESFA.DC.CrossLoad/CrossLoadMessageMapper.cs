using ESFA.DC.CrossLoad.Dto;
using ESFA.DC.CrossLoad.Interface;
using ESFA.DC.CrossLoad.Message;

namespace ESFA.DC.CrossLoad
{
    public sealed class CrossLoadMessageMapper : ICrossLoadMessageMapper
    {
        public MessageCrossLoadDcftToDct FromDto(MessageCrossLoadDcftToDctDto dto)
        {
            return new MessageCrossLoadDcftToDct(dto.JobId, dto.DcftJobId, dto.StorageContainerName, dto.StorageFileNameReport1, dto.StorageFileNameReport2, dto.ErrorMessage);
        }

        public MessageCrossLoadDctToDcft FromDto(MessageCrossLoadDctToDcftDto dto)
        {
            return new MessageCrossLoadDctToDcft(
                dto.JobId,
                dto.UkPrn,
                dto.Upin,
                dto.StorageContainerName,
                dto.StorageFileName,
                (CrossLoadJobType)dto.JobType,
                dto.Username,
                dto.StorageFileNameReport1,
                dto.StorageFileNameReport2);
        }

        public MessageCrossLoadDcftToDctDto FromMessage(MessageCrossLoadDcftToDct dto)
        {
            return new MessageCrossLoadDcftToDctDto
            {
                JobId = dto.JobId,
                StorageContainerName = dto.StorageContainerName,
                ErrorMessage = dto.ErrorMessage,
                DcftJobId = dto.DcftJobId,
                StorageFileNameReport1 = dto.StorageFileNameReport1,
                StorageFileNameReport2 = dto.StorageFileNameReport2
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
                StorageFileNameReport1 = dto.StorageFileNameReport1,
                StorageFileNameReport2 = dto.StorageFileNameReport2,
                Upin = dto.Upin
            };
        }
    }
}
