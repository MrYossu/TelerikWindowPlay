using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowParameters : WindowParametersInterface {
  public WindowParameters(WindowManager windowManager, Type type, string id, Action<(Type, string, string, string)> onWindowResized, Action<(Type type, string id)> onClose) {
    Type = type;
    Id = id;
    OnWindowResized = EventCallback.Factory.Create<(Type, string, string, string)>(windowManager, onWindowResized);
    OnClose = EventCallback.Factory.Create<(Type, string)>(windowManager, onClose);
  }

  public Type Type { get; }
  public string Id { get; set; }
  public bool Visible { get; set; } = true;

  public async Task ToFront() {
    Visible = false;
    await Task.Delay(1);
    Visible = true;
  }

  public EventCallback<(Type, string, string, string)> OnWindowResized { get; set; }
  public EventCallback<(Type, string)> OnClose { get; set; }

  public string Top { get; set; }
  public string Left { get; set; }
  public string Width { get; set; }
  public string Height { get; set; }

  public Dictionary<string, object> GetDictionary() =>
    GetType().GetProperties().ToDictionary(property => property.Name, property => property.GetValue(this)!);
}