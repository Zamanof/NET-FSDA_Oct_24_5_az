// Single Responsibility
using System.Text.RegularExpressions;

#region Bad Example

//class SendMail
//{
//    public bool Send(string mailAddress, string message)
//    {
//        if (IsMailAddressValid(mailAddress)) return true;
//        return false;
//    }
//    private bool IsMailAddressValid(string mailAddress)
//    {
//        Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
//        return mailPattern.IsMatch(mailAddress);
//    }
//}
#endregion

#region Good Example

SendMail sendMail = new(new MailAddressValidation());
sendMail.Send("salam@salam.salam", "salam");
interface IMailValidation
{
    bool IsMailAddressValid(string mailAddress);
}
class MailAddressValidation: IMailValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
        return mailPattern.IsMatch(mailAddress);
    }
}

class MailAddressValidationForAI : IMailValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        // use ChatGpt api
        return true;
    }
}
class SendMail
{
    private IMailValidation _validation;

    public SendMail(IMailValidation validation)
    {
        _validation = validation;
    }

    public bool Send(string mailAddress, string message)
    {
        if (_validation.IsMailAddressValid(mailAddress)) return true;
        return false;
    }    
}
#endregion
