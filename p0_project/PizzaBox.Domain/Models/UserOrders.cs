namespace PizzaBox.Domain.Models
{
  public class UserOrders
  {
   
    public long OrderId { get; set; }
    public Order order { get; set; }
    public long UserId { get; set; }
    public User user { get; set; }
  }
}