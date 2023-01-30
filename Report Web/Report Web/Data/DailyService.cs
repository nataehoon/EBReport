using Microsoft.AspNetCore.Components;
using Report_Web.Model;

namespace Report_Web.Data
{
    public interface IDailyService
    {
        Task<List<Daily>> GetDailyListAsync();
        Task CreateDailyAsync(Daily model);
        Task DeleteDailyAsync(int no);
        Task UpdateDailyAsync(int no, Daily model);
        Task<Daily> GetDailyByNoAsync(int no);

    }
    public class DailyService : IDailyService
    {
        private List<Daily> Dailys { get; set; }

        private readonly NavigationManager navigationManager;

        public DailyService(NavigationManager _navigationManager)
        {
            navigationManager = _navigationManager;
        }

        public async Task CreateDailyAsync(Daily model)
        {
            Dailys.Add(model);
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task DeleteDailyAsync(int no)
        {
            foreach (var daily in Dailys)
            {
                if (daily.No == no)
                {
                    Dailys.Remove(daily);
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task<Daily> GetDailyByNoAsync(int no)
        {
            Daily finddaily = new();
            foreach (var daily in Dailys)
            {
                if (daily.No == no)
                {
                    finddaily = daily;
                    return finddaily;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
            return finddaily;
        }

        public async Task<List<Daily>> GetDailyListAsync()
        {
            await Task.Delay(1000);
            return Dailys;
        }

        public async Task UpdateDailyAsync(int no, Daily model)
        {
            foreach (var daily in Dailys)
            {
                if (daily.No == no)
                {
                    daily.No = model.No;
                    daily.Category = model.Category;
                    daily.Title = model.Title;
                    daily.Managers = model.Managers;
                    daily.Important = model.Important;
                    daily.Progress = model.Progress;
                    daily.Operation = model.Operation;
                    daily.Issue = model.Issue;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }
    }
}
