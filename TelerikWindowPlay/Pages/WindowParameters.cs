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

  // TODO AYS - These should all be plain props, no need to convert to/from an int
  private int _top = 500;

  public string Top {
    set => _top = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_top}px";
  }

  private int _left = 500;

  public string Left {
    set => _left = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_left}px";
  }

  private int _width = 500;

  public string Width {
    set => _width = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_width}px";
  }

  private int _height = 500;

  public string Height {
    set => _height = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_height}px";
  }

  public Dictionary<string, object> GetDictionary() =>
    GetType().GetProperties().ToDictionary(property => property.Name, property => property.GetValue(this)!);
}