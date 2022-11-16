using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Security.Cryptography;

namespace MauiTest.ViewModel
{
    public partial class MainPageViewModel : ObservableObject 
    {
        [RelayCommand]
        async Task Choose()
        {
            var choose = RandomNumberGenerator.GetInt32(0, 2);
            if(choose == 0) 
            {
                await Shell.Current.GoToAsync(nameof(WinPage));
            }
            else
            {
                await Shell.Current.GoToAsync(nameof(LoosePage));
            }
        }
    }
}
