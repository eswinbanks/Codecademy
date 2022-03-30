using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string password;
    private string Password;
    {
      get{return password;}
      set 
      {
        if (value.Length >= 8)
          {
            password = value;
          }
      }
   }
  
public bool Hidden
{ get; private set; }

public string headerSymbol = "-------";
public string HeaderSymbol
{ get
  {
    return headerSymbol;
  }
}

public PasswordManager(string password, bool hidden)
{
  Password = password;
  Hidden = hidden;
}

public void Display()
{
  Console.WriteLine("\nPassword");
  Console.WriteLine(HeaderSymbol);
  if(!Hidden)
  {
    Console.WriteLine(Password);
  } else {
    Console.WriteLine("**********");
    }
  }
  
  public void Reset()
  {
    Password = "";
    Hidden = false;
  }
  
  public bool ChangePassword(string oldpassword, string newpassword)
  {
    if(oldpassword == Password)
    {
      Password = newpassword;
      return true
    } else 
    {
      return false;
    }
  }
}
}
