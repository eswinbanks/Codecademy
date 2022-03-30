using System;

namespace SavingInterface
{
  class Program
  {
  static void Main(string[] args)
    {
      TodoList tdl = new TodoList();
      tdl.Add("Invite friends");
      tdl.Add("Buy decorations");
      tdl.Add("Party");
      
      PasswordManager pm = new PasswordManager("uuyu", false);
      
      tdl.Display();
      pm.Display();
      
      tdl.Reset();
      pm.Reset();
      
      tdl.Display();
      pm.Display();
      
      bool passwordChanged = pm.ChangePassword("password123", "newpassword");
      if(passwordChanged)
      {
        Console.WriteLine("\nPassword changed successfully! and your new password is the following");
        pm.Display();
      } else{
      Console.WriteLine("Password not changed");
      }
     }
    }
   }
