using System;

namespace TypicalTools.Models
{
    // Error view model that gets and sets request id and show request id values
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
