using Microsoft.AspNetCore.Components;

namespace TelerikWindowPlay.Pages;

public class WindowParameters : WindowParametersInterface {
  public WindowParameters(WindowManager windowManager, Type type, string id, Action<(Type type, string id)> onClose) {
    Type = type;
    Id = id;
    OnClose = EventCallback.Factory.Create<(Type, string)>(windowManager, onClose);
  }

  public Type Type { get; }
  public string Id { get; set; }
  public bool Visible { get; set; } = true;

  public async Task ToFront() {
    Visible = false;
    await Task.Delay(10);
    Visible = true;
  }

  public EventCallback<(Type, string)> OnClose { get; set; }

  private int _top = 500;

  public string TopStr {
    set => _top = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_top}px";
  }

  private int _left = 500;

  public string LeftStr {
    set => _left = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_left}px";
  }

  private int _width = 500;

  public string WidthStr {
    set => _width = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_width}px";
  }

  private int _height = 500;

  public string HeightStr {
    set => _height = Convert.ToInt32(value.Replace("px", ""));
    get => $"{_height}px";
  }

  public Dictionary<string, object> GetDictionary() =>
    GetType().GetProperties().ToDictionary(property => property.Name, property => property.GetValue(this)!);
}