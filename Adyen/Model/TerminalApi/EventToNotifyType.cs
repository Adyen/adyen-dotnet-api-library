namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute]
    public enum EventToNotifyType
    {

        /// <remarks/>
        BeginMaintenance,

        /// <remarks/>
        EndMaintenance,

        /// <remarks/>
        Shutdown,

        /// <remarks/>
        Initialised,

        /// <remarks/>
        OutOfOrder,

        /// <remarks/>
        Completed,

        /// <remarks/>
        Abort,

        /// <remarks/>
        SaleWakeUp,

        /// <remarks/>
        SaleAdmin,

        /// <remarks/>
        CustomerLanguage,

        /// <remarks/>
        KeyPressed,

        /// <remarks/>
        SecurityAlarm,

        /// <remarks/>
        StopAssistance,

        /// <remarks/>
        CardInserted,

        /// <remarks/>
        CardRemoved,

        /// <remarks/>
        Reject,

        /// <remarks>Indicates that the terminal has established a network connection.</remarks>Add commentMore actions
        NetworkConnected,

        /// <remarks>Indicates that the terminal has no longer a network connection.</remarks>
        NetworkDisconnected,        
    }
}