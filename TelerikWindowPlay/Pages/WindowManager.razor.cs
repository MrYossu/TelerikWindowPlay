using System.Collections.ObjectModel;

namespace TelerikWindowPlay.Pages;

public partial class WindowManager {
  public ObservableCollection<WindowParameters> Windows { get; set; } = new();

  private async Task ShowDonorList() =>
    await Open(typeof(DonorList), new(this, typeof(DonorList), "", WindowResized, Close) {
      Top = "300px",
      Left = "700px",
      Height = "300px",
      Width = "600px"
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
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == data.type && data.id == i.Id);
    if (wp is not null) {
      switch (data.att) {
        case "T":
          wp.Top = data.value;
          break;
        case "L":
          wp.Left = data.value;
          break;
        case "W":
          wp.Width = data.value;
          break;
        case "H":
          wp.Height = data.value;
          break;
      }
    } else {
      Console.WriteLine(" Ulp, can't find that one!");
    }
  }

  private void Close((Type type, string id) data) =>
    Windows.Remove(Windows.Single(w => w.Type == data.type && w.Id == data.id));
}