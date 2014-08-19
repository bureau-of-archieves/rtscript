using System;

namespace RTScript.Core.AbstractionLayer
{
    /// <summary>
    /// The input of the merge step is a list of ITREntry.
    /// Template converts each match output row (IRTMatch) to an merge input row（ITREntry) (1:1 mapping).
    /// </summary>
    public interface IRTEntry
    {
        /// <summary>
        /// The match Template used to produce the Result.
        /// </summary>
        RTScript.Core.AbstractionLayer.IRTMatch DataSource { get; }
        
        string Result { get; }

        /// <summary>
        /// Index of this entry in the list.
        /// </summary>
        int EntryIndex { get; }
        
    }
}
