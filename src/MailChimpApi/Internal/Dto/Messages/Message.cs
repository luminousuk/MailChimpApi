using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimpApi.Internal.Dto.Messages
{
    internal class Message
    {
        /// <summary>
        ///     The full HTML content to be sent.
        /// </summary>
        [JsonPropertyName("html")]
        public string Html { get; set; }

        /// <summary>
        ///     Optional full text content to be sent.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        ///     The message subject.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        ///     The sender email address.
        /// </summary>
        [JsonPropertyName("from_email")]
        public string FromEmail { get; set; }

        /// <summary>
        ///     Optional from name to be used.
        /// </summary>
        [JsonPropertyName("from_name")]
        public string FromName { get; set; }

        /// <summary>
        ///     An array of recipient information.
        /// </summary>
        [JsonPropertyName("to")]
        public IEnumerable<Recipient> To { get; set; }

        /// <summary>
        ///     Optional extra headers to add to the message (most headers are allowed).
        /// </summary>
        [JsonPropertyName("headers")]
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        ///     Whether or not this message is important, and should be delivered ahead of non-important messages.
        /// </summary>
        [JsonPropertyName("important")]
        public bool Important { get; set; }

        /// <summary>
        ///     Whether or not to turn on open tracking for the message.
        /// </summary>
        [JsonPropertyName("track_opens")]
        public bool TrackOpens { get; set; }

        /// <summary>
        ///     Whether or not to turn on click tracking for the message.
        /// </summary>
        [JsonPropertyName("track_clicks")]
        public bool TrackClicks { get; set; }

        /// <summary>
        ///     Whether or not to automatically generate a text part for messages that are not given text.
        /// </summary>
        [JsonPropertyName("auto_text")]
        public bool AutoText { get; set; }

        /// <summary>
        ///     Whether or not to automatically generate an HTML part for messages that are not given HTML.
        /// </summary>
        [JsonPropertyName("auto_html")]
        public bool AutoHtml { get; set; }

        /// <summary>
        ///     Whether or not to automatically inline all CSS styles provided in the message HTML - only for HTML documents less
        ///     than 256KB in size.
        /// </summary>
        [JsonPropertyName("inline_css")]
        public bool InlineCss { get; set; }

        /// <summary>
        ///     Whether or not to strip the query string from URLs when aggregating tracked URL data.
        /// </summary>
        [JsonPropertyName("url_strip_qs")]
        public bool UrlStripQueryString { get; set; }

        /// <summary>
        ///     Whether or not to expose all recipients in to "To" header for each email.
        /// </summary>
        [JsonPropertyName("preserve_recipients")]
        public bool PreserveRecipients { get; set; }

        /// <summary>
        ///     Set to false to remove content logging for sensitive emails.
        /// </summary>
        [JsonPropertyName("view_content_link")]
        public bool ViewContentLink { get; set; }

        /// <summary>
        ///     An optional address to receive an exact copy of each recipient's email.
        /// </summary>
        [JsonPropertyName("bcc_address")]
        public string BccAddress { get; set; }

        /// <summary>
        ///     A custom domain to use for tracking opens and clicks instead of mandrillapp.com.
        /// </summary>
        [JsonPropertyName("tracking_domain")]
        public string TrackingDomain { get; set; }

        /// <summary>
        ///     A custom domain to use for SPF/DKIM signing instead of mandrill (for "via" or "on behalf of" in email clients).
        /// </summary>
        [JsonPropertyName("signing_domain")]
        public string SigningDomain { get; set; }

        /// <summary>
        ///     A custom domain to use for the messages's return-path.
        /// </summary>
        [JsonPropertyName("return_path_domain")]
        public string ReturnPathDomain { get; set; }

        /// <summary>
        ///     Whether to evaluate merge tags in the message. Will automatically be set to true if either mergevars or
        ///     globalmerge_vars are provided.
        /// </summary>
        [JsonPropertyName("merge")]
        public bool Merge { get; set; }

        /// <summary>
        ///     The merge tag language to use when evaluating merge tags, either mailchimp or handlebars Possible values:
        ///     "mailchimp"
        ///     or "handlebars".
        /// </summary>
        [JsonPropertyName("merge_language")]
        public string MergeLanguage { get; set; }

        /// <summary>
        ///     Global merge variables to use for all recipients. You can override these per recipient.
        /// </summary>
        [JsonPropertyName("global_merge_vars")]
        public IEnumerable<MergeVariable> GlobalMergeVars { get; set; }

        /// <summary>
        ///     Per-recipient merge variables, which override global merge variables with the same name.
        /// </summary>
        [JsonPropertyName("merge_vars")]
        public IEnumerable<RecipientMergeVariables> MergeVars { get; set; }

        /// <summary>
        ///     An array of string to tag the message with. Stats are accumulated using tags, though we only store the first 100 we
        ///     see, so this should not be unique or change frequently.
        ///     Tags should be 50 characters or less. Any tags starting with an underscore are reserved for internal use and will
        ///     cause errors.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        ///     The unique id of a subaccount for this message - must already exist or will fail with an error.
        /// </summary>
        [JsonPropertyName("subaccount")]
        public string SubAccount { get; set; }

        /// <summary>
        ///     An array of strings indicating for which any matching URLs will automatically have Google Analytics parameters
        ///     appended to their query string automatically.
        /// </summary>
        [JsonPropertyName("google_analytics_domains")]
        public IEnumerable<string> GoogleAnalyticsDomains { get; set; }

        /// <summary>
        ///     Optional string indicating the value to set for the utm_campaign tracking parameter. If this isn't provided the
        ///     email's from address will be used instead.
        /// </summary>
        [JsonPropertyName("google_analytics_campaign")]
        public string GoogleAnalyticsCampaign { get; set; }

        /// <summary>
        ///     An associative array of user metadata. Mandrill will store this metadata and make it available for retrieval. In
        ///     addition, you can select up to 10 metadata fields to index and make searchable using the Mandrill search api.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        ///     Per-recipient metadata that will override the global values specified in the metadata parameter.
        /// </summary>
        [JsonPropertyName("recipient_metadata")]
        public IEnumerable<RecipientMetadata> RecipientMetadata { get; set; }

        /// <summary>
        ///     An array of supported attachments to add to the message.
        /// </summary>
        [JsonPropertyName("attachments")]
        public IEnumerable<Attachment> Attachments { get; set; }

        /// <summary>
        ///     An array of embedded images to add to the message.
        /// </summary>
        [JsonPropertyName("images")]
        public IEnumerable<Image> Images { get; set; }
    }
}