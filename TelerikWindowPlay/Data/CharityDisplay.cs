namespace TelerikWindowPlay.Data;

public class CharityDisplay :  Charity {
  public bool Visible { get; set; }

  public CharityDisplay(int id, string name, string number, string address, string city, string postcode) : base(id, name, number, address, city, postcode) {
  }
}
