namespace ArchLite.Data.Models.Validation
{
    public class ErrorValidation
    {
        public string Field { get; private set; }
        public string Message { get; private set; }
        public bool IsSummary { get; private set; } = false;

        public static ErrorValidation Create(string field, string message)
        {
            return new ErrorValidation()
            {
                Field = field,
                Message = message
            };
        }

        public static ErrorValidation CreateSummary(string message)
        {
            return new ErrorValidation()
            {
                Message = message,
                IsSummary = true
            };
        }
    }
}
