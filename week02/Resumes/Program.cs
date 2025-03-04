using System;
using Resumes;

class Program
{
    static void Main(string[] args)
    {
        var _resume = new Resume("Matthew D. Barker");
        
        _resume.Jobs.Add(new Job("SupplyPro, Inc.","Architect and Senior Software Engineer", 2019,2024));
        _resume.Jobs.Add(new Job("Nexcelom Bioscience", "Senior Software Engineer", 2016, 2019));
        _resume.Jobs.Add(new Job("Surveillus Networks LLC", "Senior Software Engineer", 2016, 2016));
        _resume.Jobs.Add(new Job("SupplyPro, Inc.", "Director of Software Development / Special Project, Lead Engineer", 2013, 2016));
        _resume.Jobs.Add(new Job("nLiven (DefenseWeb)", "Software Engineer", 2012, 2013));
        
        _resume.Jobs.Add(new Job("Euro RSCG", "Software Developer", 2010,2012));
        _resume.Jobs.Add(new Job("Cisco Systems, Inc.", "Software Engineer IV", 2004, 2009));
        _resume.Jobs.Add(new Job("Authentium, Inc.", "Senior Software Engineer", 2002, 2003));
        _resume.Jobs.Add(new Job("College Loan Corporation", "Senior Software Engineer", 2000, 2001));

        _resume.Jobs.Add(new Job("Educational Finance Group", "Senior Software Engineer", 1999, 1999));
        _resume.Jobs.Add(new Job("Digital Software International", "Software Engineer", 1996, 1999));
        _resume.Jobs.Add(new Job("Hewlett Packard", "Large Format Test Engineer", 1995, 1996));

        _resume.Display();
        
    }
}