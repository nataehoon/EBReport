using Microsoft.AspNetCore.Components;
using System.Linq;

namespace Report_Web.Data
{
    public interface IMemberService
    {
        Task<List<Member>> GetMembersAsync();
        Task CreateMemberAsync(Member model);
        Task DeleteMemberAsync(string id);
        Task UpdateMemberAsync(string id, Member model);
        Task<Member> GetMemberByIdAsync(string id);
    }
    public class MemberService : IMemberService
    {
        private readonly List<Member> Members;
        private readonly NavigationManager navigationManager;

        public MemberService(List<Member> _Members, NavigationManager _navigationManager)
        {
            Members = _Members;
            navigationManager = _navigationManager;
        }

        public async Task CreateMemberAsync(Member model)
        {
            
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task DeleteMemberAsync(string id)
        {
            foreach (var member in Members)
            {
                if (member.Id.Equals(id))
                {
                    Members.Remove(member);
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }

        public async Task<Member> GetMemberByIdAsync(string id)
        {
            Member findmember = new();
            foreach (var member in Members)
            {
                if (member.Id.Equals(id))
                {
                    findmember = member;
                    return findmember;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
            return findmember;
        }

        public async Task<List<Member>> GetMembersAsync()
        {
            await Task.Delay(1000);
            return Members;
        }

        public async Task UpdateMemberAsync(string id, Member model)
        {
            foreach (var member in Members)
            {
                if (member.Id.Equals(id))
                {
                    member.Id = model.Id;
                    member.Pw = model.Pw;
                    member.Email = model.Email;
                }
            }
            await Task.Delay(1000);
            navigationManager.NavigateTo("/");
        }
    }
}
