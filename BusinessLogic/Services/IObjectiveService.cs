using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
	public interface IObjectiveService
	{
		List<Objective> GetObjectives();
	}
}
