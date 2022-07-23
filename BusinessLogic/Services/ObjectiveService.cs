using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Services
{
	public class ObjectiveService : IObjectiveService
	{
		private readonly SurveyContext _surveyContext = null;

		public ObjectiveService(SurveyContext surveyContext)
		{
			this._surveyContext = surveyContext;
		}

		public List<Objective> GetObjectives()
		{
			return _surveyContext.Objectives.ToList();
		}
	}
}
