using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Shared;

public partial class NavMenu {
  [Parameter]
  public EventCallback<Type> OpenWindow { get; set; }
  private bool _pinNavMenu = true;
  private string PinCssClass => _pinNavMenu ? "pin" : "";
  private void TogglePin() => _pinNavMenu = !_pinNavMenu;
  private string DropDownId { get; set; } = "";

  private void SetDropDownId(string id) =>
    DropDownId = DropDownId == id ? "" : id;
}