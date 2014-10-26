using System;
using AppBay.UI.Common;
using AppBay.UI.DataModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppBay.UI
{
  /// <summary>
  /// A page that displays a collection of item previews.  In the Split Application this page
  /// is used to display and select one of the available groups.
  /// </summary>
  public sealed partial class LandingPage
  {
    private readonly NavigationHelper navigationHelper;
    private readonly ObservableDictionary defaultViewModel = new ObservableDictionary();

    public LandingPage()
    {
      InitializeComponent();
      DefaultViewModel["Items"] = new[]
      {
        new ViewItem {Title = "Reports", Subtitle = "Completed reports" },
        new ViewItem {Title = "Jobs", Subtitle = "Jobs in queue or in progress now" },
        new ViewItem {Title = "Packages", Subtitle = "Availiable packages" },
        new ViewItem { Title = "Server", Subtitle="AppBay server settings", NavigateTo = typeof(Settings)}
      };
      navigationHelper = new NavigationHelper(this);
      navigationHelper.LoadState += navigationHelper_LoadState;
    }

    public ObservableDictionary DefaultViewModel
    {
      get { return this.defaultViewModel; }
    }

    public NavigationHelper NavigationHelper
    {
      get { return navigationHelper; }
    }

    /// <summary>
    /// Populates the page with content passed during navigation.  Any saved state is also
    /// provided when recreating a page from a prior session.
    /// </summary>
    /// <param name="sender">
    /// The source of the event; typically <see cref="NavigationHelper"/>
    /// </param>
    /// <param name="e">Event data that provides both the navigation parameter passed to
    /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
    /// a dictionary of state preserved by this page during an earlier
    /// session.  The state will be null the first time a page is visited.</param>
    private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
    {
      // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
    }

    #region NavigationHelper registration

    /// The methods provided in this section are simply used to allow
    /// NavigationHelper to respond to the page's navigation methods.
    /// 
    /// Page specific logic should be placed in event handlers for the  
    /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
    /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
    /// The navigation parameter is available in the LoadState method 
    /// in addition to page state preserved during an earlier session.

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
      navigationHelper.OnNavigatedTo(e);
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
      navigationHelper.OnNavigatedFrom(e);
    }

    #endregion

    private void ListViewBase_OnItemClick(object sender, ItemClickEventArgs e)
    {
      var clicked = e.ClickedItem as ViewItem;
      if (clicked == null)
      {
        return;
      }

      if (clicked.NavigateTo != null)
      {
        Frame.Navigate(clicked.NavigateTo, clicked.DataToken);
      }
    }
  }
}
