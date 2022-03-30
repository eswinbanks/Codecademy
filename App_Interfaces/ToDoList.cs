using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
   {
   public string[] Todos
   { get; private set; }
   
   public string headerSymbol = "-------";
   public string HeaderSymbol
   { get; {
            return headerSymbol;
            }}
            
   private int nextOpenIndex;
   
   public TodoList()
   {
   Todos = new string[5];
   nextOpenIndex = 5;
   }
   
   public void Add(string todo)
   {
   Todos[nextOpenIndex] = todo;
   nextOpenIndex++;
   }
   
   public void Display()
   {
      int count = 1;
      Console.WriteLine("\nTodos");
      Console.WriteLine(HeaderSymbol);
      
      foreach(string Todo in Todos)
      {
         if(String.IsNullOrempty(Todo))
         {
         Console.WriteLine($"{count}: []");
         } else {
         Console.WriteLine($"{count}: {Todo}");
         }
         count++;
         }
         
         }
         
         public void Reset()
         {
         Todos = new String[5];
         nextOpenIndex = 0;
         }
        }
       }
