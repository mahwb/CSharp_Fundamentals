using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            Artist foundMt = Artists.Where(artist => artist.Hometown == "Mount Vernon").Single();
            System.Console.WriteLine("{0} from Mount Vernon is {1} years old.", foundMt.ArtistName, foundMt.Age);
            //Who is the youngest artist in our collection of artists?
            Artist foundY = Artists.OrderBy(artist => artist.Age).First();
            System.Console.WriteLine("{0} is youngest.", foundY.ArtistName);
            //Display all artists with 'William' somewhere in their real name
            List<Artist> foundWill = Artists.Where(artist => artist.RealName.Contains("William")).ToList();
            foreach (Artist person in foundWill) {
                System.Console.WriteLine("Found {0}.", person.RealName);
            }
            //Display the 3 oldest artist from Atlanta
            List<Artist> three_old  = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(artist => artist.Age).Take(3).ToList();
            foreach (Artist person in three_old) {
                System.Console.WriteLine("One of the three oldest from Atlanta is {0}.", person.RealName);
            }
            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            List<string> foundNYC = Artists
                .Join(Groups, artist => artist.GroupId, group => group.Id, (artist, group) => { artist.Group = group; return artist; })
                .Where(artist => (artist.Hometown != "New York City" && artist.Group != null))
                .Select(artist => artist.Group.GroupName)
                .Distinct()
                .ToList();
            foreach (var group in foundNYC) {
                System.Console.WriteLine("Group not from NYC is {0}", group);
            }
            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            Group foundWTC = Groups
                .Where(group => group.GroupName == "Wu-Tang Clan")
                .GroupJoin(Artists, group => group.Id, artist => artist.GroupId, (group, artists) => { group.Members = artists.ToList(); return group; })
                .Single();
            foreach (Artist member in foundWTC.Members) {
                System.Console.WriteLine("Member of Wu-Tang Clan is {0}", member.ArtistName);
            }
        }   
    }
}
