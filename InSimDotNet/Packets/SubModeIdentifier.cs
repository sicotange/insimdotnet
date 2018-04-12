namespace InSimDotNet.Packets
{
    /// <summary>
    /// Represents the sub mode identifiers.
    /// </summary>
    public enum SubModeIndentifier
    {
        FVM_PLAIN,          // no buttons displayed
        FVM_BUTTONS,        // buttons displayed (not editing)
        FVM_SP2,            // reserved
        FVM_SP3,            // reserved
        FVM_EDIT_CHALK,
        FVM_EDIT_CONES,
        FVM_EDIT_TYRES,
        FVM_EDIT_MARKERS,
        FVM_EDIT_OTHER,
        FVM_EDIT_CONCRETE,
        FVM_EDIT_CONTROL,
        FVM_EDIT_MARSH,
        FVM_NUM
    }
}
