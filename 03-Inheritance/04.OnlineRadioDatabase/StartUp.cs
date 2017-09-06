using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main()
    {
        var playlist = new List<Song>();
        var numberOfSongs = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfSongs; i++)
        {
            var songInfo = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                var artist = songInfo[0];
                var name = songInfo[1];
                int minutes;
                int seconds;

                try
                {
                    var songLength = songInfo[2].Split(':').Select(int.Parse).ToArray();
                    minutes = songLength[0];
                    seconds = songLength[1];
                }
                catch (Exception)
                {
                    throw new ArgumentException("Invalid song length.");
                }

                var song = new Song(artist, name, minutes, seconds);
                playlist.Add(song);
                Console.WriteLine("Song added.");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        Console.WriteLine($"Songs added: {playlist.Count}");
        Console.WriteLine(GetPlaylistLength(playlist));

    }

    public static string GetPlaylistLength(List<Song> playlist)
    {
        var playlistLength = new TimeSpan();

        foreach (var song in playlist)
        {
            var minutes = song.Minutes;
            var seconds = song.Seconds;
            playlistLength += TimeSpan.FromMinutes(minutes);
            playlistLength += TimeSpan.FromSeconds(seconds);
        }

        return $"Playlist length: {playlistLength.Hours}h " +
               $"{playlistLength.Minutes}m " +
               $"{playlistLength.Seconds}s";
    }
}
