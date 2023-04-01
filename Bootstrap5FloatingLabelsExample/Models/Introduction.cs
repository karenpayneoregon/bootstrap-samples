using Microsoft.AspNetCore.Mvc;

namespace Bootstrap5FloatingLabelsExample.Models;

[BindProperties]
public class Introduction
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsActive { get; set; }
}