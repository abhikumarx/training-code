using System;

namespace PizzaBox.Domain.Models
{
  public class Store
  {
   public Guid StoreId { get; set;}
   public string StoreName { get; set;}
   public string StoreAddress { get; set;}
   public string PhoneNum{ get; set;}

   public Store()
   {
     StoreId = Guid.NewGuid();
   }
  }
}