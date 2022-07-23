using DataModels.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Survey_Blazor_DBFirst.Services
{
	public interface IFrontEndService
	{
		Task<List<Objective>> GetObjectives();
	}
}
