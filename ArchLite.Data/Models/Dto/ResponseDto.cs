using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArchLite.Data.Models.Dto
{
    public class ResponseDto
    {
        public IEnumerable<object> Data { get; private set; }
        public int Status { get; private set; }
        [JsonIgnore]
        public bool HasError { get; private set; }

        public static ResponseDto Create(IEnumerable<object> data, int status, bool hasError)
        {
            return new ResponseDto()
            {
                Data = data,
                Status = status,
                HasError = hasError
            };
        }
    }
}
