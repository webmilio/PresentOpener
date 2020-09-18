using System;

namespace PresentOpener.Entries
{
    [Flags]
    public enum ItemEntryType
    {
        None = 0,
        Present = 1 << 0,
        GoodieBag = 1 << 1,
        All = Present | GoodieBag
    }
}