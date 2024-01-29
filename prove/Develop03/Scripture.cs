using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Scripture 
{
    Reference reference = new Reference("1 Nephi","1","3");

    public void GetScripture() {
        Console.WriteLine($"{reference.GetBook()} {reference.GetChapter()}:{reference.GetVerse()}");
    }
    
}