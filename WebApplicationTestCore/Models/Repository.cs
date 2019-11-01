using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTestCore.Models
{
    public class Repository
    {
        private static List<GuessResponse> repository = new List<GuessResponse>();

        public static void AddResponse(GuessResponse response)
        {
            repository.Add(response);
        }

        public static IEnumerable<GuessResponse> GetResponses { get { return repository; } }
    }
}
