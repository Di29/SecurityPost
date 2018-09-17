using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SecurityPost
{
    interface ITwilio
    {
        const string accountSid = "AC21972c77ed7f6cb6d8e53a6e91e73544";
        const string accountToken = "216baea766b06c889b04454533e820b6";

        TwilioClient.Init(accountSid, accountToken);

            var message = MessageResource.Create(
                body: "Congratulation! First Twilio message!",
                from: new PhoneNumber("+13163303949"),
                to: new PhoneNumber("++77081762343")
             );
    }
}
