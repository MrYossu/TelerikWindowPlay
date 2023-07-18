using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowBase : ComponentBase, WindowParametersInterface {
  [Parameter]
  public Type Type { get; set; }

  [Parameter]
  public string Id { get; set; } = "";

  [Parameter]
  public bool Visible { get; set; } = true;

  [Parameter]
  public string Top { get; set; } = "";

  [Parameter]
  public string Left { get; set; } = "";

  [Parameter]
  public string Width { get; set; } = "";

  [Parameter]
  public string Height { get; set; } = "";

  [Parameter]
  // Raised whenever a window is moved or resized. Sends the window type, Id, parameter that changed (left, top, width or height) and the new value
  public EventCallback<(Type, string, WindowAttribute, string)> OnWindowResized { get; set; }

  // TODO AYS - Would be better if this took an enum for the attribute
  public async Task WindowResized(WindowAttribute att, string value) =>
    await OnWindowResized.InvokeAsync((GetType(), Id, att, value));

  [Parameter]
  public EventCallback<(Type, string)> OnClose { get; set; }

  public async Task Close() =>
    await OnClose.InvokeAsync((GetType(), Id));
}