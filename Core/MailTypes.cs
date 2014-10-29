using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class MailTypes
{
    public MailTypes() { }

    public static string GetRandomMailType()
    {
        Random R = new Random();
        List<string> MailTypes = MailTypesList();
        return MailTypes.ElementAt(R.Next(1, MailTypes.Count));
    }

    public static List<string> MailTypesList()
    {
        return new List<string>()
        {
            "מייל",
            "אי-מייל",
            @"דוא""ל",
            "דואר אלקטרוני",
            "Email",
            "e-mail",
            "דואל",
            "דואר-אלקטרוני"
        };
    }
}