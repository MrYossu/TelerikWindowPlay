using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace TelerikWindowPlay.Pages;

public partial class WindowManager {
  [Inject]
  public ILocalStorageService LocalStorage { get; set; } = null!;

  public ObservableCollection<WindowParameters> Windows { get; set; } = new();

  private async Task Open(WindowParameters parameters) {
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == parameters.Type && parameters.Id == i.Id);
    if (wp is null) {
      parameters.Visible = false;
      Windows.Add(parameters);
      if (await LocalStorage.ContainKeyAsync($"{parameters.Type.Name}-top")) {
        parameters.Top = await LocalStorage.GetItemAsStringAsync($"{parameters.Type.Name}-top");
      }
      if (await LocalStorage.ContainKeyAsync($"{parameters.Type.Name}-left")) {
        parameters.Left = await LocalStorage.GetItemAsStringAsync($"{parameters.Type.Name}-left");
      }
      if (await LocalStorage.ContainKeyAsync($"{parameters.Type.Name}-width")) {
        parameters.Width = await LocalStorage.GetItemAsStringAsync($"{parameters.Type.Name}-width");
      }
      if (await LocalStorage.ContainKeyAsync($"{parameters.Type.Name}-height")) {
        parameters.Height = await LocalStorage.GetItemAsStringAsync($"{parameters.Type.Name}-height");
      }
      parameters.Visible = true;
    } else {
      await wp.ToFront();
    }
    StateHasChanged();
  }

  private void WindowResized((Type type, string id, WindowAttribute att, string value) data) {
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == data.type && data.id == i.Id);
    try {
      if (wp is not null) {
        switch (data.att) {
          case WindowAttribute.Top:
            double topIntVal = double.Parse(data.value.Replace("px", ""));
            if (topIntVal < 57) {
              data.value = "57px";
            }
            wp.Top = data.value;
            break;
          case WindowAttribute.Left:
            double leftIntVal = double.Parse(data.value.Replace("px", ""));
            if (leftIntVal < 0) {
              data.value = "0px";
            }
            wp.Left = data.value;
            break;
          case WindowAttribute.Width:
            wp.Width = data.value;
            break;
          case WindowAttribute.Height:
            wp.Height = data.value;
            break;
        }
      } else {
        Console.WriteLine(" Ulp, can't find that one!");
      }
    } catch (Exception ex) {
      Console.WriteLine($"WindowResized error: {ex.Message}");
    }
  }

  private void Close((Type type, string id) data) =>
    Windows.Remove(Windows.Single(w => w.Type == data.type && w.Id == data.id));

  private void OpenAnotherWindow((Type type, string id) data) =>
    Open(new(this, data.type, data.id, WindowResized, Close, OpenAnotherWindow));

  private async Task OpenAnotherWindow(WindowParameters wp) {
    wp.OnWindowResized = EventCallback.Factory.Create<(Type, string, WindowAttribute, string)>(this, WindowResized);
    wp.OnClose = EventCallback.Factory.Create<(Type, string)>(this, Close);
    wp.OnOpenAnotherWindow = EventCallback.Factory.Create<(Type, string)>(this, OpenAnotherWindow);
    await Open(wp);
  }
}