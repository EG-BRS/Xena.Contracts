using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class ResponseDto
    {
        public long Id { get; set; }
        public List<string> Messages { get; set; }
        public string NewState { get; set; }
        public bool Success { get; set; }
    }
}
