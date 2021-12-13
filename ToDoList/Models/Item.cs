using System; // directive - tells it what code it needs in order to function.
using System.Collections.Generic; // if using list objects

namespace ToDoList.Models
{
  public class Item
  {
    public string Description {get; set;}
    private static List<Item> _instances = new List<Item> {};
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}