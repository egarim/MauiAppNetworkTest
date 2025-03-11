using CommunityToolkit.Mvvm.Input;
using MauiAppNetworkTest.Models;

namespace MauiAppNetworkTest.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}