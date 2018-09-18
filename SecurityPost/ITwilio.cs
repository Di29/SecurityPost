﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SecurityPost
{
    public interface ITwilio
    {
        void SmsSend(string accountSid, string accountToken, string ToPhoneNumber, int verifyCode);
    }
}
