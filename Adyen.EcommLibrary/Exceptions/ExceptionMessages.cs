namespace Adyen.EcommLibrary.Exceptions
{
    internal class ExceptionMessages
    {
        internal const string SaleToPoiMessageRootMissing = "SaleToPOIMessage missing root";
        internal const string ExceptionDuringNotification = "Notifications are not yet supported";
        internal const string InvalidMessageType = "Invalid Message Type for the message: {0}";
        internal const string TerminalErrorResponse = "Terminal Error Response: {0}";

        internal const string ExceptionDuringDeserialization =
            "Exception during deserialization of object: {0}, Exception Message: {1}";
    }
}