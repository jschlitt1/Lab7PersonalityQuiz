using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalityQuiz.Data
{
    public class LegendListManager
    {
        IRestService restService;
        public LegendListManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Legend>> GetTasksAsync()
        {
            return restService.RefreshDataAsync();
        }

    }
}
