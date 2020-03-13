using System;

namespace PizzaBox.Domain.Models
{
  public class Store
  {
   public long StoreId { get; set;}
   public string StoreName { get; set;}
   public string StoreAddress { get; set;}
   public string PhoneNum{ get; set;}
 
   public Store()
   {
   
   }

   public override string ToString()
    {
      //got the error because the values of the name were null and it's not a representation of string so you have write what it should say
      return $"{StoreId} {StoreName} {StoreAddress} {PhoneNum}";
    }
  }

}