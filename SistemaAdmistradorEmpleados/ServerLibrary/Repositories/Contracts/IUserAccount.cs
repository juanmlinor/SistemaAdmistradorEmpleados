using BaseLibrary.DTOs;
using BaseLibrary.Responses;

namespace ServerLibrary.Repositories.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> SignInAsync(Login user);
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token);
        //Task<List<ManageUser>> GetUsers();         
        //Task<GeneralResponse> GetRoles();
        //Task<GeneralResponse> UpdateUsers(ManageUser user);
        //Task<GeneralResponse> DeleteUser(int id);


    }
}
