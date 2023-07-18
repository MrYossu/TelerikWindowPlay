using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public interface WindowParametersInterface {
  string Id { get; set; }
  bool Visible { get; set; }
  string TopStr { get; set; }
  string LeftStr { get; set; }
  string WidthStr { get; set; }
  string HeightStr { get; set; }
  EventCallback<(Type, string, string, string)> OnWindowResized { get; set; }
  EventCallback<(Type, string)> OnClose { get; set; }
}