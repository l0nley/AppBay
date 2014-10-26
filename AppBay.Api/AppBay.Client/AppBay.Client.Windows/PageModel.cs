using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AppBay.Client.Annotations;
using AppBay.Client.AppBayApiServices;

namespace AppBay.Client
{
  public sealed class PageModel : INotifyPropertyChanged
  {
    private string _serviceEndpoint;
    private string _password;
    private string _userName;

    public PageModel()
    {
      JobsInQueue = new ObservableCollection<JobDescription>();
      Results = new ObservableCollection<JobResult>();
      Packages = new ObservableCollection<Package>();
      UserName = "Not logged in";
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public string UserName
    {
      get
      {
        return _userName;
      }

      set
      {
        if (value == _userName)
        {
          return;
        }

        _userName = value;
        OnPropertyChanged();
      }
    }

    public string Password
    {
      get
      {
        return _password;
      }

      set
      {
        if (value == _password)
        {
          return;
        }

        _password = value;
        OnPropertyChanged();
      }
    }

    public string ServiceEndpoint
    {
      get
      {
        return _serviceEndpoint;
      }

      set
      {
        if (value == _serviceEndpoint)
        {
          return;
        }

        _serviceEndpoint = value;
        OnPropertyChanged();
      }
    }

    public ObservableCollection<JobDescription> JobsInQueue { get; set; }
    public ObservableCollection<Package> Packages { get; set; }
    public ObservableCollection<JobResult> Results { get; set; }
      
    [NotifyPropertyChangedInvocator]
    private void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      var handler = PropertyChanged;
      if (handler != null)
      {
        handler(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
