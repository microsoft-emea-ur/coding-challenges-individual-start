using System;
using System.Collections.Generic;

namespace CodingChallenges.Abstractions
{
    public interface ISolution
    {
        /// <summary>
        /// The title (in sentence case) of the problem.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The Github alias(es) of people who solved this problem.
        /// </summary>
        List<string> SolverAlias { get; }

        /// <summary>
        /// Produces the correct output for a given input to a problem.
        /// </summary>
        /// <param name="input">The input for the problem.</param>
        /// <returns>The correct output for the given input.</returns>
        string Solve(string input);
    }
}
