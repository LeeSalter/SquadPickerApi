using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class DbResponse<T>
    {
        public DbResponse(bool success, string error, T payload)
        {
            Success = success;
            Error = error;
            Payload = payload;
        }
        public bool Success { get; set; }
        public string Error { get; set; }
        public T Payload { get; set; }
    }
}
