namespace InSimDotNet.Packets
{
    /// <summary>
    /// Represents the mode identifiers.
    /// </summary>
    public enum ModeIndentifier
    {
        CIM_NORMAL,         // 0 - not in a special mode
        CIM_OPTIONS,        // 1
        CIM_HOST_OPTIONS,   // 2
        CIM_GARAGE,         // 3
        CIM_CAR_SELECT,     // 4
        CIM_TRACK_SELECT,   // 5
        CIM_SHIFTU,         // 6 - free view mode
        CIM_NUM
    }
}
