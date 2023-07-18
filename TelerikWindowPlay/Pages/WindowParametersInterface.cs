using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public interface WindowParametersInterface {
  string Id { get; set; }
  bool Visible { get; set; }
  string Top { get; set; }
  string Left { get; set; }
  string Width { get; set; }
  string Height { get; set; }
  EventCallback<(Type, string, WindowAttribute, string)> OnWindowResized { get; set; }
  EventCallback<(Type, string)> OnClose { get; set; }
}