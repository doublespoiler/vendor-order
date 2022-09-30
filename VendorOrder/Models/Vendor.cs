using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }

    public List<Order> Orders { get; set; }

    private static  List<Vendor> _instances = new List<Vendor>{};

    public Vendor(string name)
    {
      Name = name;
      Orders = new List<Order>{};
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}