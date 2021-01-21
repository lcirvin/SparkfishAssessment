using System;
using System.Collections.Generic;
using System.Text;

namespace SparkfishAssessment.Contracts.Services
{
    public interface IListifierService
    {
        /// <summary>
        /// For an enumerable range with the provided start and end values, retrieve the value at the index.
        /// </summary>
        /// <param name="start">Start of the range</param>
        /// <param name="end">End of the range</param>
        /// <param name="index">The index at which to retrieve the value from</param>
        /// <returns>The value at the index</returns>
        int GetValueByIndex(int start, int end, int index);
    }
}
