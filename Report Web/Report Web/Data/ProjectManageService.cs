using Microsoft.AspNetCore.Components;
using Report_Web.Model;

namespace Report_Web.Data
{
    public interface IProjectManageService
    {
        Task<List<ProjectManage>> GetProjectManageAsync();
        Task CreateProjectManageAsync(ProjectManage model);
        Task DeleteProjectManageAsync(int no);
        Task UpdateProjectManageAsync(int no, ProjectManage model);
        Task<ProjectManage> GetProjectManageByNoAsync(int no);
    }
    public class ProjectManageService : IProjectManageService
    {
        private List<ProjectManage> ProjectManages { get; set; }

        private readonly NavigationManager navigationManager;

        public ProjectManageService(NavigationManager _navigationManager)
        {
            navigationManager = _navigationManager;
        }

        public async Task CreateProjectManageAsync(ProjectManage model)
        {
            ProjectManages.Add(model);
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task DeleteProjectManageAsync(int no)
        {
            foreach (var projectmansger in ProjectManages)
            {
                if (projectmansger.no == no)
                {
                    ProjectManages.Remove(projectmansger);
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task<List<ProjectManage>> GetProjectManageAsync()
        {
            await Task.Delay(1000);
            return ProjectManages;
        }

        public async Task<ProjectManage> GetProjectManageByNoAsync(int no)
        {
            ProjectManage findprojectmanage = new();
            foreach (var projectmansger in ProjectManages)
            {
                if (projectmansger.no == no)
                {
                    findprojectmanage = projectmansger;
                    return findprojectmanage;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
            return findprojectmanage;
        }

        public async Task UpdateProjectManageAsync(int no, ProjectManage model)
        {
            foreach (var projectmansger in ProjectManages)
            {
                if (projectmansger.no == no)
                {
                    projectmansger.no = model.no;
                    projectmansger.title = model.title;
                    projectmansger.member = model.member;
                    projectmansger.startperiod = model.startperiod;
                    projectmansger.endperiod = model.endperiod;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }
    }
}
