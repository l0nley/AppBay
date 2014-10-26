namespace AppBay.Client
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage
  {
    public MainPage()
    {
      Model = new PageModel();
      InitializeComponent();
    }

    public PageModel Model { get; private set; }
  }
}
