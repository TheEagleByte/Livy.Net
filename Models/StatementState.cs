namespace Livy.Net.Models
{
    public enum StatementState
    {
        Waiting,
        Running,
        Available,
        Error,
        Cancelling,
        Cancelled
    }
}