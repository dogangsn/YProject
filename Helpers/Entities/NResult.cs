using Helpers.Enums;

namespace Helpers.Entities
{
    public class NResult
    {
        public ResponseType ResponseType { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
    public class NResult<T> : NResult
    {
        public T Data { get; set; }
    }
}
