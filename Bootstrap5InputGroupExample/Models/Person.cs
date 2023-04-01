#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Bootstrap5InputGroupExample.Models;

public class Person
{
    public int PersonId { get; set; }
    [Display(Name = "First")]
    public string FirstName { get; set; }
    [Display(Name = "Last")]
    public string LastName { get; set; }
    [Display(Name = "Email")]
    public string EmailAddress { get; set; }

    public string UserName { get; set; }
    [Display(Name = "Agree to terms")]
    public bool AgreeToTerms { get; set; }

    public string Signature { get; set; }
}