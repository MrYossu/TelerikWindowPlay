﻿using System.Collections.ObjectModel;

namespace TelerikWindowPlay.Pages;

public partial class WindowManager {
  public ObservableCollection<WindowParameters> Windows { get; set; } = new();

  private async Task ShowDonorList() =>
    await Open(typeof(DonorList), new(this, typeof(DonorList), "", Close) {
      TopStr = "300px",
      LeftStr = "700px",
      HeightStr = "700px",
      WidthStr = "600px"
    });

  private async Task ShowCharityList() =>
    await Open(typeof(CharityList), new(this, typeof(CharityList), "", Close));

  private async Task Open(Type type, WindowParameters parameters) {
    WindowParameters? wp = Windows.SingleOrDefault(i => i.Type == type && parameters.Id == i.Id);
    if (wp is null) {
      Windows.Add(parameters);
    } else {
      await wp.ToFront();
    }
  }

  private void Close((Type type, string id) data) =>
    Windows.Remove(Windows.Single(w => w.Type == data.type && w.Id == data.id));
}