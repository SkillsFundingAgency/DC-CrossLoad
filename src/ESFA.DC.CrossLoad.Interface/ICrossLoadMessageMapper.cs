using ESFA.DC.CrossLoad.Dto;
using ESFA.DC.CrossLoad.Message;

namespace ESFA.DC.CrossLoad.Interface
{
    public interface ICrossLoadMessageMapper
    {
        MessageCrossLoadDcftToDct FromDto(MessageCrossLoadDcftToDctDto dto);

        MessageCrossLoadDctToDcft FromDto(MessageCrossLoadDctToDcftDto dto);

        MessageCrossLoadDcftToDctDto FromMessage(MessageCrossLoadDcftToDct dto);

        MessageCrossLoadDctToDcftDto FromMessage(MessageCrossLoadDctToDcft dto);
    }
}
