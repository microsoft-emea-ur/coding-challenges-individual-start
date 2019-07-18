# Microsoft EMEA Coding Challenge

This repository contains code challenges for the Microsoft EMEA coding challenge hosted on *18.07.2019*.

## Resolving challenges

The hard deadline for this challenge is **18.07.2019 23:55 CET**.

We will announce the winners by **08.08.2019 23:55 CET** via email.

### Prerequisites

* [.NET Core 2.1+](https://dotnet.microsoft.com/download)
* [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio 2017+](https://visualstudio.microsoft.com/downloads/)
* an appetite for coding

An minimal knowledge of C# is required in order to resolve those challenges. For a complete list of tutorial please refer to the [Microsoft docs](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/).

### Project structure

The solution contains 4 folders:
* **lib** which contains abstractions for solutions
* **problems** which contains a project per problem
* **tests** which contains test projects for problems with different assertions
* **CodingChallenges.Worker** which is a console application meant to help you in debugging

A problem project contains a `Solution.cs` which exposes a `string Solve(string input)` method in which you will have to write your solution. You can optionally populate the `List<string> SolverAlias` with your name. In the `content` folder you will find the problem statement, input and output definitions and examples.

A test project contains a `<TestName>Tests.cs` file which contains a list of 20 tests. A test can optionally include test files from which the test reads and asserts. Tests can be run with the [Test Explorer](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019).

### How to get started
Clone the repository, open `CodingChallenges.sln` and start resolving challenges.

After you finish the challenges, commit and push everything to `master` before the deadline expires.

### Challenge example
```csharp
/****
**  problem-statement.md
**  Many services generate huge amounts of data when in operation.
**  There is often a need to parse and consolidate that data to understand and improve those services.
**  One common metric to calculate is the average of the generated data.
**
**  input-definition.md
**  An input file for this program will contain a string of 500 or fewer comma separated integers, ranging from 1 to 1000, inclusive.
**
**  output-definition.md
**  Your output should be the integer that is the (rounded) mean of the given integers.
**
**  input-example.txt
**  1,2,3,4
**
**  output-example.txt
**  3
****/

using System;
using System.Collections.Generic;
using CodingChallenges.Abstractions;

namespace CodingChallenges.Problems.Average
{
    public class Solution : ISolution
    {
        public string Title => "Data consolidation";

        public List<string> SolverAlias => new List<string> { "" };

        public string Solve(string input)
        {
            throw new NotImplementedException();
        }
    }
}
```

## Privacy
Your privacy is important to us. This repository has adopted the [Microsoft Privacy Statement](https://privacy.microsoft.com/en-us/privacystatement). 

We do not collect or store any personal data prior to cloning, forking or mirroring this repository. If you do not wish to participate in the contest, delete the fork/clone.

By forking or cloning this repository you hereby agree to delete your fork/repository if you do no want your code to be made public.

We do not collect, store or use your personal email address for any purpose other than updates on this challenge or notifying in the case of winning.

After the challenge is over, any judge added as a collaborator will self remove from your repository, if you gave them access.

## Feedback
* File a bug in [GitHub Issues](issues) if you found something wrong with a test or with a challenge.

## License
Licensed under the [MIT License](LICENSE).