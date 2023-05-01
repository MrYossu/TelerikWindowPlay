using System.Collections.ObjectModel;
using Pixata.Extensions;
using Telerik.Blazor.Components;
using static TelerikWindowPlay.Data.DataService;

namespace TelerikWindowPlay.Pages;

public partial class Layout1 {
  #region Customers

  private bool _customerListWindowVisible;

  private readonly ObservableCollection<CustomerDisplay> _customers = Customers
    .Select(c => new CustomerDisplay(c.Id, c.FirstName, c.Surname, c.Email, c.Address, c.City, c.Postcode))
    .OrderBy(c => c.Surname)
    .ThenBy(c => c.FirstName)
    .ToObservableCollection();

  private readonly ObservableCollection<CustomerDisplay> _customerWindows = new();

  private async Task CustomerSelected(GridRowClickEventArgs args) {
    CustomerDisplay customer = args.Item as CustomerDisplay ?? new(-1, "", "", "", "", "", "");
    if (_customerWindows.All(c => c.Id != customer.Id)) {
      // TODO AYS - Load full details from the database
    } else {
      _customerWindows.Remove(customer);
      await Task.Delay(1);
    }
    _customerWindows.Add(customer);
    customer.Visible = true;
  }

  #endregion

  #region Charities

  private bool _charityListWindowVisible;

  private readonly ObservableCollection<CharityDisplay> _charities = Charities
    .Select(c => new CharityDisplay(c.Id, c.Name, c.Number, c.Address, c.City, c.Postcode))
    .OrderBy(c => c.Name)
    .ToObservableCollection();

  private readonly ObservableCollection<CharityDisplay> _charityWindows = new();

  private async Task CharitySelected(GridRowClickEventArgs args) {
    CharityDisplay charity = args.Item as CharityDisplay ?? new(-1, "", "", "", "", "");
    if (_charityWindows.All(c => c.Id != charity.Id)) {
      _charityWindows.Add(charity);
    }
    charity.Visible = false;
    // Get charity detail from the database
    await Task.Delay(100);
    charity.Visible = true;
  }

  #endregion
}