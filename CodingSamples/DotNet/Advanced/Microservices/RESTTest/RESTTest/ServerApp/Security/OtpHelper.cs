using System.Collections.Concurrent;
using System.Net.Mail;
using System.Security.Cryptography;

namespace ServerApp.Security;

public class OtpHelper
{
    private readonly static ConcurrentDictionary<string, int> store = [];

    public static async Task MailPasscodeAsync(string receiver, string sender)
    {
        int digits = RandomNumberGenerator.GetInt32(100000, 1000000);
        using var mailer = new SmtpClient("localhost", 8025);
        await mailer.SendMailAsync(
            from: sender,
            recipients: receiver,
            subject: "OTP",
            body: digits.ToString()
        );
        store.TryAdd(receiver, digits);
    }

    public static bool VerifyPasscode(string receiver, int digits)
    {
        return store.Remove(receiver, out int value) && value == digits;
    }
}