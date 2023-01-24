using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace WpfMvvmToolkitApp1;

public partial class NewMainViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    private string firstName = "太郎";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(FullName))]
    private string lastName = "葡萄";

    public string FullName => $"{LastName} {FirstName}";
}

public partial class OldMainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private string firstName = "太郎";
    public string FirstName
    {
        get => firstName;
        set
        {
            firstName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullName)));
        }
    }

    private string lastName = "葡萄";
    public string LastName
    {
        get => lastName;
        set
        {
            lastName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullName)));
        }
    }

    public string FullName => $"{LastName} {FirstName}";
}
