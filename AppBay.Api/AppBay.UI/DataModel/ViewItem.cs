using System;

namespace AppBay.UI.DataModel
{
  public class ViewItem
  {
    public string Title { get; set; }
    public string Subtitle { get; set; }
    public object DataToken { get; set; }
    public Type NavigateTo { get; set; }
  }
}
