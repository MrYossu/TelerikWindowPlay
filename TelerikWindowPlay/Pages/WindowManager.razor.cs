using System.Collections.ObjectModel;

namespace TelerikWindowPlay.Pages;

public partial class WindowManager {
  public ObservableCollection<WindowParameters> Windows { get; set; } = new();

  private async Task ShowDonorList() =>
    await Open(typeof(DonorList), new(this, typeof(DonorList), "", WindowResized, Close) {
      TopStr = "300px",
      LeftStr = "700px",
      HeightStr = "300px",
      WidthStr = "600px"
    });

  private async Task ShowCharityList() =>
    await Open(typeof(CharityList), new(this, typeof(CharityList), "", WindowResized, Close));

  private async Task Open(Type type, WindowParameters parameters) {
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == type && parameters.Id == i.Id);
    if (wp is null) {
      Windows.Add(parameters);
    } else {
      await wp.ToFront();
    }
  }

  private void WindowResized((Type type, string id, string att, string value) data) {
    Console.WriteLine($"Window of type {data.type.Name} with Id {data.id} has had the {data.att} attribute changed to {data.value}");
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == data.type && data.id == i.Id);
    if (wp is not null) {
      switch (data.att) {
        case "T":
          wp.TopStr = data.value;
          break;
        case "L":
          wp.LeftStr = data.value;
          break;
        case "W":
          wp.WidthStr = data.value;
          break;
        case "H":
          wp.HeightStr = data.value;
          break;
      }
    } else {
      Console.WriteLine(" Ulp, can't find that one!");
    }
  }

  private void Close((Type type, string id) data) =>
    Windows.Remove(Windows.Single(w => w.Type == data.type && w.Id == data.id));
}