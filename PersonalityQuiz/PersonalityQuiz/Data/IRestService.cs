using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalityQuiz.Data
{
    public interface IRestService
    {
        Task<List<Legend>> RefreshDataAsync ();

        Task SaveLegendAsync(Legend item, bool isNewItem);

        Task DeleteLegendAsync(string id);

        Task<Legend> GetLegendAsync();
    }
}
