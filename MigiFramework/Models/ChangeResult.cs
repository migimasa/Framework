using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Migi.Framework.Models
{
    public class ChangeResult
    {
        public bool IsSuccess { get; set; }
        public List<string> ErrorMessages { get; set; }

        public ChangeResult()
        {
            this.IsSuccess = true;
            this.ErrorMessages = new List<string>();
        }
        public ChangeResult(bool isSuccess, string errorMessage)
        {
            this.IsSuccess = isSuccess;
            this.ErrorMessages = new List<string>();
            this.ErrorMessages.Add(errorMessage);
        }
        public ChangeResult(bool isSuccess, List<string> errorMessages)
        {
            this.IsSuccess = isSuccess;
            this.ErrorMessages = errorMessages;
        }

        public void AddErrorMessage(string errorMessage)
        {
            this.IsSuccess = false;
            this.ErrorMessages.Add(errorMessage);
        }
    }
}
