namespace TelerikWindowPlay.Data;

public class Charity {
  public Charity(int id, string name, string number, string address, string city, string postcode) {
    Id = id;
    Name = name;
    Number = number;
    Address = address;
    City = city;
    Postcode = postcode;
  }

  public int Id { get; set; }
  public string Name { get; set; }
  public string Number { get; set; }
  public string Address { get; set; }
  public string City { get; set; }
  public string Postcode { get; set; }
}