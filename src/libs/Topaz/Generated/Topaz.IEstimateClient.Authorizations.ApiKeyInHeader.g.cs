
#nullable enable

namespace Topaz
{
    public partial interface IEstimateClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}