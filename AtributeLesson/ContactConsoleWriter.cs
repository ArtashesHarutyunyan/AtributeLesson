using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace ContactWriter;

public class ContactConsoleWriter
{
    private readonly Contact _contact;
    private ConsoleColor _color;

    public ContactConsoleWriter(Contact contact)
    {
        _contact= contact;
    }

    [Obsolete("This will be removed in version 2 ",false)]
    public void Write()
    {
        WriteFirstName();
        WriteAge();

    }

    private void WriteAge()
    {
        OutputDebufIngo();
        OutputEXTRAfIngo();
        Console.WriteLine(_contact.FirstName);
    }

    [Conditional("DEBUG")]
    private void OutputDebufIngo()
    {
        Console.WriteLine("***DEBUG MODE***");
    }

    [Conditional("EXTRA")]
    private void OutputEXTRAfIngo()
    {
        Console.WriteLine("***EXTRA INFO***");
    }
    
    private void PreserveForegroundColor()
    {
        _color = Console.ForegroundColor;
    }
    private void RestoreForegroundColor() 
    {
        Console.ForegroundColor = _color;
    }

    //private void WriteFirstName()
    //{
    //    Console.WriteLine(_contact.AgeInYears);

    //}
    private void WriteFirstName()
    {
        PropertyInfo firstNameProperty = typeof(Contact).GetProperty(nameof(Contact.FirstName));
        DisplayAttribute firstNameDisplayAttribute = (DisplayAttribute)
        Attribute.GetCustomAttribute(firstNameProperty, typeof(DisplayAttribute));
        PreserveForegroundColor();
        StringBuilder sb = new StringBuilder();
        if (firstNameDisplayAttribute != null)
        {
            Console.ForegroundColor = firstNameDisplayAttribute.Color;
            sb.Append(firstNameDisplayAttribute.Label);
        }
        if(_contact.FirstName != null)
        {
            sb.Append(_contact.FirstName);
        }
        Console.WriteLine(sb);
        RestoreForegroundColor();
    }
    
}
