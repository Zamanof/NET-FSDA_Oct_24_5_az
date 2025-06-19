// Single Responcibility

#region Bad Example
using System.Text.RegularExpressions;

class SendMail
{
    public bool Send(string mailAddress, string message)
    {
        //if ()
        return true;
    }
    private bool IsMailAddressValid(string mailAddress){
        Regex mailPattern = new Regex(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
        return mailPattern.IsMatch(mailAddress);
}
}
#endregion
