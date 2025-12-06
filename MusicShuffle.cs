using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        MusicShuffleMachine machine = new MusicShuffleMachine();

        Console.WriteLine("Shuffled songs:");
        List<string> shuffled = machine.ShuffleSongs();
        foreach (string song in shuffled)
        {
            Console.WriteLine(song);
        }

        Console.WriteLine("\nPlaylist for 20 minutes:");
        List<string> playlist = machine.GetCustomPlaylistByDesiredLength(20);
        int totalSeconds = 0;
        foreach (string song in playlist)
        {
            Console.WriteLine(song);
            totalSeconds += machine.GetSongLength(song); // get length in seconds
        }
        Console.WriteLine("Total playlist length: " + totalSeconds / 60 + " minutes " + totalSeconds % 60 + " seconds");

        Console.WriteLine("\nSongs grouped by first letter:");
        Dictionary<char, List<string>> grouped = machine.GroupSongsByFirstLetter();
        foreach (char letter in grouped.Keys)
        {
            Console.Write(letter + ": ");
            for (int i = 0; i < grouped[letter].Count; i++)
            {
                Console.Write(grouped[letter][i]);
                if (i < grouped[letter].Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}

class MusicShuffleMachine
{
    // List of songs and lengths in seconds
    List<string> songs = new List<string>()
    {
        "AC/DC - Back in Black",
        "Twisted Sister - We're Not Gonna Take It",
        "Judas Priest - Painkiller",
        "Motörhead - Ace of Spades",
        "Metallica - Enter Sandman",
        "Iron Maiden - The Trooper",
        "Deep Purple - Smoke on the Water",
        "Black Sabbath - Paranoid",
        "Guns N' Roses - Sweet Child O' Mine",
        "Bon Jovi - Livin' on a Prayer",
        "Accept - Fast as a shark"
    };

    // Corresponding lengths in seconds (same index as songs)
    List<int> lengths = new List<int>()
    {
        255, 244, 384, 165, 331, 243, 340, 170, 355, 248, 301
    };

    Random random = new Random();

    // Get the length of a song
    public int GetSongLength(string song)
    {
        int index = songs.IndexOf(song);
        if (index >= 0)
            return lengths[index];
        return 0;
    }

    // Shuffle songs
    public List<string> ShuffleSongs()
    {
        List<string> shuffled = new List<string>(songs);

        for (int i = 0; i < shuffled.Count; i++)
        {
            int r = random.Next(i, shuffled.Count);
            string temp = shuffled[i];
            shuffled[i] = shuffled[r];
            shuffled[r] = temp;
        }

        return shuffled;
    }

    // Create playlist for desired length in minutes
    public List<string> GetCustomPlaylistByDesiredLength(int minutes)
    {
        int maxSeconds = minutes * 60;
        int total = 0;
        List<string> playlist = new List<string>();

        List<string> shuffled = ShuffleSongs();

        foreach (string song in shuffled)
        {
            int length = GetSongLength(song);
            if (total + length <= maxSeconds)
            {
                playlist.Add(song);
                total += length;
            }
        }

        return playlist;
    }

    // Group songs by first letter of title
    public Dictionary<char, List<string>> GroupSongsByFirstLetter()
    {
        Dictionary<char, List<string>> grouped = new Dictionary<char, List<string>>();

        foreach (string song in songs)
        {
            string[] parts = song.Split('-');
            string title = parts[1].Trim();
            char firstLetter = char.ToUpper(title[0]);

            if (!grouped.ContainsKey(firstLetter))
                grouped[firstLetter] = new List<string>();

            grouped[firstLetter].Add(song);
        }

        return grouped;
    }
}
