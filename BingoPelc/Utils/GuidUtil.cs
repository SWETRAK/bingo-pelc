using BingoPelc.Exceptions;

namespace BingoPelc.Utils;

public static class GuidUtil
{
    /// <summary>
    /// Function to parse Guid from string representation. If it can't parse throws IncorrectGuidException
    /// </summary>
    /// <param name="stringGuid"></param>
    public static Guid ParseGuidFromString(string stringGuid)
    {
        if (!Guid.TryParse(stringGuid, out var guid)) throw new IncorrectGuidException();
        return guid;
    }
}