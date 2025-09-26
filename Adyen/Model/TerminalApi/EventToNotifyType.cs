namespace Adyen.Model.TerminalApi
{
    /// <remarks/>
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

        /// <remarks>Indicates that the terminal has established a network connection.</remarks>
        NetworkConnected,

        /// <remarks>Indicates that the terminal has no longer a network connection.</remarks>
        NetworkDisconnected,

        /// <remarks>Delivers the result (or timeout failure) of the Barcode scan.</remarks>
        ScanBarcodeResult,
    }
}
