namespace TelerikWindowPlay.Data;

public class CustomerDisplay : Customer {
  public bool Visible { get; set; }
  private int _top = 500;

  public string TopStr {
    set => _top = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_top}px";
  }

  private int _left = 500;

  public string LeftStr {
    set => _left = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_left}px";
  }

  public CustomerDisplay(int id, string firstName, string surname, string email, string address, string city, string postcode) : base(id, firstName, surname, email, address, city, postcode) {
  }
}