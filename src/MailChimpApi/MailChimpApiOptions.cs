using System;

namespace MailChimpApi
{
    /// <summary>
    ///     Provides programmatic configuration for MailChimpApi.
    /// </summary>
    public class MailChimpApiOptions
    {
        private string _mailChimpUri = "https://mandrillapp.com/api/1.0/";

        public string MailChimpUri
        {
            get => _mailChimpUri;
            set => _mailChimpUri = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string ApiKey { get; set; }
    }
}