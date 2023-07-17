using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowBase : ComponentBase {
  [Parameter]
  public Type Type { get; set; }

  [Parameter]
  public string Id { get; set; } = "";

  [Parameter]
  public bool Visible { get; set; } = true;

  [Parameter]
  public string TopStr { get; set; } = "";

  [Parameter]
  public string LeftStr { get; set; } = "";

  [Parameter]
  public string WidthStr { get; set; } = "";

  [Parameter]
  public string HeightStr { get; set; } = "";

  [Parameter]
  public EventCallback<(Type, string)> OnClose { get; set; }

  public async Task Close() =>
    await OnClose.InvokeAsync((GetType(), ""));

  protected override void OnParametersSet() {
    Console.WriteLine("WindowBase.OnParametersSet");
    Console.WriteLine($"  TopStr: {TopStr}");
    Console.WriteLine($"  LeftStr: {LeftStr}");
  }
}