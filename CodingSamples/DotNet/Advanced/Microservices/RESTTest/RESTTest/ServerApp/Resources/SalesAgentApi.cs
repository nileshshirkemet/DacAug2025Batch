using System.IdentityModel.Tokens.Jwt;
using ServerApp.Security;

namespace ServerApp.Resources;

public class SalesAgentApi
{
    public static async Task<IResult> SignIn(string id, int passcode)
    {
        string agentMailId = id + "@sales.met.edu"; 
        if(passcode == 9820)
        {
            await OtpHelper.MailPasscodeAsync(agentMailId, "admin@sales.met.edu");
            return Results.Ok();
        }
        if(OtpHelper.VerifyPasscode(agentMailId, passcode))
        {
            var token = JwtHelper.CreateToken(id);
            return Results.Text(token);
        }
        return Results.Unauthorized();
    }
}
