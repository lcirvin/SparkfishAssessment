using SparkfishAssessment.Contracts.Services;
using SparkfishAssessment.Utility.Listifier;
using System;

namespace SparkfishAssessment.Services.Listifier
{
    public class ListifierService : IListifierService
    {
        /// <summary>
        /// For an enumerable range with the provided start and end values, retrieve the value at the index.
        /// </summary>
        /// <param name="start">Start of the range</param>
        /// <param name="end">End of the range</param>
        /// <param name="index">The index at which to retrieve the value from</param>
        /// <returns>The value at the index</returns>
        public int GetValueByIndex(int start, int end, int index)
        {
            var list = new Listify(start, end);

            var val = list[index];

            return val;
        }
    }
}
