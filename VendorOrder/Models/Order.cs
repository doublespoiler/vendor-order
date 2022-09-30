using System.Collections.Generic;
using System;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Item { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};

    public Order (string item, string description, DateTime date)
    {
      Item = item;
      Description = description;
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  } 
}