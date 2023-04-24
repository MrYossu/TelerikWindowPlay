using Telerik.Blazor.Components;
using Telerik.DataSource;

namespace TelerikWindowPlay.Helpers;

public class TextGridColumn : GridColumn {
  public TextGridColumn() {
    DefaultFilterOperator = FilterOperator.Contains;
    ShowFilterCellButtons = false;
  }
}