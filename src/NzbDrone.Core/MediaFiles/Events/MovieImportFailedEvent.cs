﻿using System;
using NzbDrone.Common.Messaging;
using NzbDrone.Core.Download;
using NzbDrone.Core.Parser.Model;

namespace NzbDrone.Core.MediaFiles.Events
{
    public class MovieImportFailedEvent : IEvent
    {
        public Exception Exception { get; set; }
        public LocalMovie MovieInfo { get; }
        public bool NewDownload { get; }
        public string DownloadClient { get; }
        public string DownloadId { get; }

        public MovieImportFailedEvent(Exception exception, LocalMovie movieInfo, bool newDownload, DownloadClientItem downloadClientItem)
        {
            Exception = exception;
            MovieInfo = movieInfo;
            NewDownload = newDownload;

            if (downloadClientItem != null)
            {
                DownloadClient = downloadClientItem.DownloadClient;
                DownloadId = downloadClientItem.DownloadId;
            }
        }
    }
}
