using DataModels.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Survey_Blazor_DBFirst.Services
{
	public class FrontEndService : IFrontEndService
	{
		private readonly HttpClient _httpClient;

		public FrontEndService(HttpClient httpClient)
		{
			this._httpClient = httpClient;
		}

		public async Task<List<Objective>> GetObjectives()
		{
			return await _httpClient.GetJsonAsync<List<Objective>>("api/Objective/GetObjectives");
		}
	}
}
