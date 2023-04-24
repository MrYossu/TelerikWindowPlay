namespace TelerikWindowPlay.Data;

public class CustomerDisplay : Customer {
  public bool Visible { get; set; }

  public CustomerDisplay(int id, string firstName, string surname, string email, string address, string city, string postcode) : base(id, firstName, surname, email, address, city, postcode) {
  }
}
