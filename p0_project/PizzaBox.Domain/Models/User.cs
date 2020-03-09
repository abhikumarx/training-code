using System;
using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
  public class User
  {
    public Guid UserId{ get; set;}
    public string UserName { get; set;}
    public string UserAddress{ get;set ;}
    public string PhoneNumber { get; set;}
    public string EmailAddress { get; set;}
    public List<Order> orders { get; set;}

    public User()
    {
     
    }

  
  }
}