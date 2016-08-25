using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignForm.Models
{
    [Serializable]
    public class PasswordPolicy
    {
        public string PolicyName { get; set; }
        public int PasswordLength { get; set; }
        public byte Complexity { get; set; }
        public short DNAPrevious { get; set; }
        public string PswExpDate { get; set; }
        public byte OTPExpMin { get; set; }
        public byte NoInvalidAttempts { get; set; }
        public byte LockOutPeriod { get; set; }
        public byte LockType { get; set; }
        public bool SendE_mail{ get; set; }
        public bool ChangePswAftLogin { get; set; }
        public bool CannotChangePsw { get; set; }
        public bool OTPLogin { get; set; }
        public bool SendEmailOnLoginSuccess { get; set; }
        public bool SendEmailOnLoginFailur { get; set; }
    }
}