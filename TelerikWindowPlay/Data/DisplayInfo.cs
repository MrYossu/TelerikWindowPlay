namespace TelerikWindowPlay.Data;

public class DisplayInfo<T> {
  public DisplayInfo(T entity) =>
    Entity = entity;

  public T Entity { get; set; }
  public bool Visible { get; set; }
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

  // TODO AYS - Need similar properties for Width and Height
}