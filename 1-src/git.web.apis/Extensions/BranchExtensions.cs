using System.Collections.Generic;
using Git.Web.Apis.Responses;
using LibGit2Sharp;

namespace Git.Web.Apis.Extensions
{
    public static class BranchExtensions
    {
        public static BranchResponse ToBranchResponse(this Branch @this)
        {
            return BranchResponse.From(@this);
        }

        public static List<BranchResponse> ToBranchResponses(this IEnumerable<Branch> @this)
        {
            return BranchResponse.From(@this);
        }

        public static BranchesResponse ToBranchesResponse(this IEnumerable<Branch> @this)
        {
            return BranchesResponse.From(@this);
        }
    }
}