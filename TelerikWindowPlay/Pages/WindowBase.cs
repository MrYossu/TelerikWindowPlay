﻿using Microsoft.AspNetCore.Components;

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
  public string Top { get; set; } = "";

  [Parameter]
  public string LeftStr { get; set; } = "";
  public string Left { get; set; } = "";

  [Parameter]
  public string WidthStr { get; set; } = "";
  public string Width { get; set; } = "";

  [Parameter]
  public string HeightStr { get; set; } = "";
  public string Height { get; set; } = "";

  [Parameter]
  // Raised whenever a window is moved or resized. Sends the window type, Id, parameter that changed (left, top, width or height) and the new value
  public EventCallback<(Type, string, string, string)> OnWindowResized { get; set; }

  public async Task WindowResized(string att, string value) {
    Console.WriteLine($"{att} has changed to {value}");
    await OnWindowResized.InvokeAsync((GetType(), Id, att, value));
  }

  [Parameter]
  public EventCallback<(Type, string)> OnClose { get; set; }

  public async Task Close() =>
    await OnClose.InvokeAsync((GetType(), Id));

  protected override void OnParametersSet() {
    Top = TopStr;
    Left = LeftStr;
    Height = HeightStr;
    Width = WidthStr;
  }
}