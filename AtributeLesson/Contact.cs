using System.Diagnostics;

namespace ContactWriter;

[DebuggerDisplay("First Name = {FirstName} and Age in Years = {AgeInYears}")]
[DebuggerTypeProxy(typeof(ContactDebugDisplay))]
public class Contact
{
    [Display("First Name: ")]
    public string FirstName { get; set; }
    
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public int AgeInYears { get; set; }
}
