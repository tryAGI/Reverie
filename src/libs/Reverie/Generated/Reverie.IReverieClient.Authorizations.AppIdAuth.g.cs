
#nullable enable

namespace Reverie
{
    public partial interface IReverieClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingAppIdAuth(
            string apiKey);
    }
}