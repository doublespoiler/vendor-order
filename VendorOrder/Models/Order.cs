using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Item { get; set; }
    public string Description { get; set; }
    public int Amount { get; set; }
    public double Cost { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order (string item, string description, int amount, double cost, DateTime date)
    {
      Item = item;
      Description = description;
      Amount = amount;
      Cost = cost;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  } 
}