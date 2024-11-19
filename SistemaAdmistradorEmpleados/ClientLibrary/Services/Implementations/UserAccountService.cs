using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http.Json;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService(GetHttpClient getHttpClient): IUserAccountService
    {
        public const string AuthUrl = "api/authentication";
        public async Task<GeneralResponse> CreateAsync(Register user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/register", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Error occured");
            return await result.Content.ReadFromJsonAsync<GeneralResponse>()!;
        }

        public async Task<LoginResponse> SignInAsync(Login user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/login", user);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Error occured");
            return await result.Content.ReadFromJsonAsync<LoginResponse>()!;
        }

        public async Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuthUrl}/register", token);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, " Error occured");
            return await result.Content.ReadFromJsonAsync<LoginResponse>();

        }


        public async Task<WeatherForecast[]> GetWeatherForecasts()
        {
            var httpClient = await getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.GetFromJsonAsync<WeatherForecast[]>("api/weatherforecast");
            return result!;
        }
        //public async Task<List<ManageUser>> GetUsers()
        //{
        //    var httpClient = getHttpClient.GetPrivateHttpClient();
        //    var result = await httpClient.GetFromJsonAsync<List<ManageUser>>($"{AuthUrl}/users");
        //    return result!;

        //}

        //    public async Task<GeneralResponse> UpdateUsers(ManageUser user)
        //    {
        //     var httpClient = getHttpClient.GetPublicHttpClient();
        //       var result = await httpClient.PutAsJsonAsync($"{AuthUrl}/update-user",user);
        //       if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Error occured");
        //      return await result.Content.ReadFromJsonAsync<GeneralResponse>()!;

        //   }

        //     public async Task<List<SystemRole>> GetRoles()
        //    {
        //        var httpClient = getHttpClient.GetPrivateHttpClient();
        //            var result = await httpClient.GetFromJsonAsync<List<SystemRole>>($"{AuthUrl}/roles");
        //     }

        //    public async Task<GeneralResponse> DeleteUsers(int id)
        //   {
        //     var httpClient = await getHttpClient.GetPrivateHttpClient();
        //        var result = await httpClient.DeleteAsync($"{AuthUrl}/delete-user/{id}");
        //       if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "Error occured");
        //      return await result.Content.ReadFromJsonAsync<GeneralResponse>()!;

        //  }


    }

}
