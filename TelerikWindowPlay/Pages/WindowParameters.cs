using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowParameters : WindowParametersInterface {
  public WindowParameters(Type type, string id = "") {
    Type = type;
    Id = id;
  }

  public WindowParameters(WindowManager windowManager, Type type, string id, Action<(Type, string, WindowAttribute, string)> onWindowResized, Action<(Type type, string id)> onClose, Action<(Type, string)> onOpenAnotherWindow) {
    Type = type;
    Id = id;
    OnWindowResized = EventCallback.Factory.Create(windowManager, onWindowResized);
    OnClose = EventCallback.Factory.Create(windowManager, onClose);
    OnOpenAnotherWindow = EventCallback.Factory.Create(windowManager, onOpenAnotherWindow);
  }

  public Type Type { get; }
  public string Id { get; set; } = "";
  public bool Visible { get; set; } = true;

  public async Task ToFront() {
    Visible = false;
    await Task.Delay(1);
    Visible = true;
  }

  public EventCallback<(Type, string, WindowAttribute, string)> OnWindowResized { get; set; }
  public EventCallback<(Type, string)> OnClose { get; set; }
  public EventCallback<(Type, string)> OnOpenAnotherWindow { get; set; }

  public string Top { get; set; } = "";
  public string Left { get; set; } = "";
  public string Width { get; set; } = "";
  public string Height { get; set; } = "";

  public Dictionary<string, object> GetDictionary() =>
    GetType().GetProperties().ToDictionary(property => property.Name, property => property.GetValue(this)!);
}