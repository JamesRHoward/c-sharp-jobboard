using System.Collections.Generic;

namespace JobBoard.Objects
{
  public class Job
  {
    private string _name;
    private string _description;
    private string _phone;
    private string _email;
    private static List<Job> _jobs = new List<Job> {};

    public Job (string name, string description, string phone, string email)
    {
      _name = name;
      _description = description;
      _phone = phone;
      _email = email;
      _jobs.Add(this);
    }
    public static List<Job> GetAll()
    {
      return _jobs;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetDescription()
    {
      return _description;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public string GetEmail()
    {
      return _email;
    }

    public void SetName(string name)
    {
      _name = name;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }
    public void SetPhone(string phone)
    {
      _phone = phone;
    }
    public void SetEmail(string email)
    {
      _email = email;
    }
  }
}
