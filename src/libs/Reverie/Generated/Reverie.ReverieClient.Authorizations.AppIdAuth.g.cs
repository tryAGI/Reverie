
#nullable enable

namespace Reverie
{
    public sealed partial class ReverieClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingAppIdAuth(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "REV-APP-ID")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Reverie.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "AppIdAuth",
                Location = "Header",
                Name = "REV-APP-ID",
                Value = apiKey,
            });
        }
    }
}