using BaseLibrary.DTOs;
using BaseLibrary.Responses;

namespace ClientLibrary.Services.Contracts
{
    public interface IUserAccountService
    {
        Task<GeneralResponse> CreateAsync(Register user);
        Task<LoginResponse> SignInAsync(Login user);
        Task<LoginResponse> RefreshTokenAsync(RefreshToken token);

       // Task<List<ManageUser>> GetUsers();         
       // Task<GeneralResponse> GetRoles();
       // Task<GeneralResponse> UpdateUsers(ManageUser);
       //Task<GeneralResponse> DeleteUser(int id);
        Task<WeatherForecast[]> GetWeatherForecasts();
    }
}
