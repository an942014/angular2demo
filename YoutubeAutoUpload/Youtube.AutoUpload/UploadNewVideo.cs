﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Youtube.AutoUpload
{
    public class UploadNewVideo
    {
        //public async Task Run()
        //{
        //    UserCredential credential;
        //    using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
        //    {
        //        credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
        //            GoogleClientSecrets.Load(stream).Secrets,
        //            // This OAuth 2.0 access scope allows an application to upload files to the
        //            // authenticated user's YouTube channel, but doesn't allow other types of access.
        //            new[] { YouTubeService.Scope.YoutubeUpload },
        //            "user",
        //            CancellationToken.None
        //        );
        //    }

        //    var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credential,
        //        ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
        //    });

        //    var video = new Video();
        //    video.Snippet = new VideoSnippet();
        //    video.Snippet.Title = "Default Video Title";
        //    video.Snippet.Description = "Default Video Description";
        //    video.Snippet.Tags = new string[] { "tag1", "tag2" };
        //    video.Snippet.CategoryId = "22"; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
        //    video.Status = new VideoStatus();
        //    video.Status.PrivacyStatus = "unlisted"; // or "private" or "public"
        //    var filePath = @"E:\you-get-download\demo.flv"; // Replace with path to actual movie file.

        //    using (var fileStream = new FileStream(filePath, FileMode.Open))
        //    {
        //        var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
        //        videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
        //        videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

        //        await videosInsertRequest.UploadAsync();
        //    }
        //}

        //void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        //{
        //    switch (progress.Status)
        //    {
        //        case UploadStatus.Uploading:
        //            Console.WriteLine("{0} bytes sent.", progress.BytesSent);
        //            break;

        //        case UploadStatus.Failed:
        //            Console.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
        //            break;
        //    }
        //}

        //void videosInsertRequest_ResponseReceived(Video video)
        //{
        //    Console.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
        //}

    }
}
