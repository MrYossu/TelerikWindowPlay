namespace TelerikWindowPlay.Data;

public class Customer {
  public Customer(int id, string firstName, string surname, string email, string address, string city, string postcode) {
    Id = id;
    FirstName = firstName;
    Surname = surname;
    Email = email;
    Address = address;
    City = city;
    Postcode = postcode;
  }

  public int Id { get; set; }
  public string FirstName { get; set; }
  public string Surname { get; set; }
  public string Name => $"{FirstName} {Surname}";
  public string Email { get; set; }
  public string Address { get; set; }
  public string City { get; set; }
  public string Postcode { get; set; }
}