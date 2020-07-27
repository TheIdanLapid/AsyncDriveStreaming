using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Microsoft.Toolkit.Forms.UI.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DStrm
{
    static class DriveUtils
    {
        private static readonly string[] _scopes = { DriveService.Scope.DriveReadonly };
        private static readonly string _applicationName = "Drive API .NET Quickstart";
        private static UserCredential _credential;
        private static DriveService _driveService;
        private static readonly Random _rnd = new Random();
        private static List<Google.Apis.Drive.v3.Data.File> _songs = new List<Google.Apis.Drive.v3.Data.File>();

        internal static void Auth()
        {


            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                _credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    _scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            _driveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = _credential,
                ApplicationName = _applicationName,
            });
        }

        internal static void PlaySong(WebViewCompatible wb, Label label)
        {
            Google.Apis.Drive.v3.Data.File song = GetRandomSong();
            wb.Source = new Uri(song.WebViewLink);
            label.Text = "Playing: " + song.Name;
        }

        internal static Google.Apis.Drive.v3.Data.File GetRandomSong()
        {
            do
            {
                FilesResource.ListRequest folderRequest = _driveService.Files.List();
                // Get a list of folders inside "Music" folder
                folderRequest.Q = "mimeType = 'application/vnd.google-apps.folder'";
                IList<Google.Apis.Drive.v3.Data.File> musicFolders = folderRequest.Execute().Files;
                // Choose a random folder from the list
                string randomFolder = musicFolders[_rnd.Next(musicFolders.Count)].Id;
                FilesResource.ListRequest songsRequest = _driveService.Files.List();
                // Get the songs inside the random Folder
                songsRequest.Q = "parents = '" + randomFolder + "'";
                IList<Google.Apis.Drive.v3.Data.File> musicFiles = songsRequest.Execute().Files;

                // Check if another folder exists inside, and go recursively in it
                foreach (Google.Apis.Drive.v3.Data.File file in musicFiles)
                {
                    if (file.MimeType.Contains("folder"))
                    {
                        songsRequest.Q = "parents = '" + file.Id + "'";
                        musicFiles = songsRequest.Execute().Files;
                        break;
                    }
                }

                foreach (Google.Apis.Drive.v3.Data.File file in musicFiles)
                {
                    if (file.Name.EndsWith(".m4a"))
                    {
                        FilesResource.GetRequest getRequest = _driveService.Files.Get(file.Id);
                        getRequest.Fields = "webViewLink, name";
                        Google.Apis.Drive.v3.Data.File song = getRequest.Execute();
                        _songs.Add(song);
                    }
                }
            }
            while (_songs.Count == 0);

            return _songs[_rnd.Next(_songs.Count)];
        }
    }
}
