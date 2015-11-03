﻿namespace Cronofy.Requests
{
    using System;

    /// <summary>
    /// Class for the serialization of an get events request.
    /// </summary>
    public sealed class GetEventsRequest
    {
        /// <summary>
        /// Gets or sets the time zone ID for the request.
        /// </summary>
        /// <value>
        /// The time zone ID for the request.
        /// </value>
        public string TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the from date for the request.
        /// </summary>
        /// <value>
        /// The from date for the request.
        /// </value>
        public Date? From { get; set; }

        /// <summary>
        /// Gets or sets the to date for the request.
        /// </summary>
        /// <value>
        /// The to date for the request.
        /// </value>
        public Date? To { get; set; }

        /// <summary>
        /// Gets or sets the last modified time for the request.
        /// </summary>
        /// <value>
        /// The last modified time for the request.
        /// </value>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the include deleted flag for the request.
        /// </summary>
        /// <value>
        /// The include deleted flag for the request.
        /// </value>
        public bool? IncludeDeleted { get; set; }

        /// <summary>
        /// Gets or sets the include moved flag for the request.
        /// </summary>
        /// <value>
        /// The include moved flag for the request.
        /// </value>
        public bool? IncludeMoved { get; set; }

        /// <summary>
        /// Gets or sets the include managed flag for the request.
        /// </summary>
        /// <value>
        /// The include managed flag for the request.
        /// </value>
        public bool? IncludeManaged { get; set; }

        /// <summary>
        /// Gets or sets the only managed flag for the request.
        /// </summary>
        /// <value>
        /// The only managed flag for the request.
        /// </value>
        public bool? OnlyManaged { get; set; }
    }
}