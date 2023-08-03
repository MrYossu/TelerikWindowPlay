using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowBase : ComponentBase, WindowParametersInterface {
  [Inject]
  public ILocalStorageService LocalStorage { get; set; } = null!;

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

  protected virtual void LoadData() {
  }

  protected override void OnParametersSet() =>
    LoadData();

  public async Task WindowResized(WindowAttribute att, string value) {
    await OnWindowResized.InvokeAsync((GetType(), Id, att, value));
    await LocalStorage.SetItemAsStringAsync($"{GetType().Name}-width", Width);
    await LocalStorage.SetItemAsStringAsync($"{GetType().Name}-height", Height);
    if (string.IsNullOrWhiteSpace(Id)) {
      await LocalStorage.SetItemAsStringAsync($"{GetType().Name}-top", Top);
      await LocalStorage.SetItemAsStringAsync($"{GetType().Name}-left", Left);
    }
  }

  [Parameter]
  public EventCallback<(Type, string)> OnClose { get; set; }

  public async Task Close() =>
    await OnClose.InvokeAsync((GetType(), Id));

  [Parameter]
  public EventCallback<(Type, string)> OnOpenAnotherWindow { get; set; }

  public async Task OpenAnotherWindow(Type type, string id) =>
    await OnOpenAnotherWindow.InvokeAsync((type, id));
}