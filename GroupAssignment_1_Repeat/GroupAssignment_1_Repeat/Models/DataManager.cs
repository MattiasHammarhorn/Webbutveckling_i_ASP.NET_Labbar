using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_1_Repeat.Models
{
    public class DataManager
    {
        List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Lynyrd Skynyrd", Description = "Southern Rock", Albums = new List<Album>
            {
                new Album { Id = 1, Name = "(Pronounced 'Lĕh-'nérd 'Skin-'nérd)", YearOfRelease = 1973 },
                new Album { Id = 2, Name = "Second Helping", YearOfRelease = 1974 },
                new Album { Id = 3, Name = "Nuthin' Fancy", YearOfRelease = 1975 },
                new Album { Id = 4, Name = "Gimme Back My Bullets", YearOfRelease = 1976 },
                new Album { Id = 5, Name = "Street Survivors", YearOfRelease = 1977 },
                new Album { Id = 6, Name = "Lynyrd Skynyrd 1991", YearOfRelease = 1991 },
                new Album { Id = 7, Name = "The Last Rebel", YearOfRelease = 1993 },
                new Album { Id = 8, Name = "Endangered Species", YearOfRelease = 1994 },
                new Album { Id = 9, Name = "Twenty", YearOfRelease = 1997 },
                new Album { Id = 10, Name = "Edge of Forever", YearOfRelease = 1999 },
                new Album { Id = 11, Name = "Christmas Time Again", YearOfRelease = 2000 },
                new Album { Id = 12, Name = "Vicious Cycle", YearOfRelease = 2003 },
                new Album { Id = 13, Name = "God & Guns", YearOfRelease = 2009 },
                new Album { Id = 14, Name = "Last of a Dyin' Breed", YearOfRelease = 2012 }
            } },
            new Band { Id = 2, Name = "Metallica", Description = "Thrash Metal", Albums = new List<Album>
            {
                new Album { Id = 1, Name = "Kill 'Em All", YearOfRelease = 1983 },
                new Album { Id = 2, Name = "Ride the Lightning", YearOfRelease = 1984 },
                new Album { Id = 3, Name = "Master of Puppets", YearOfRelease = 1986 },
                new Album { Id = 4, Name = "...And Justice for All", YearOfRelease = 1988 },
                new Album { Id = 5, Name = "Metallica", YearOfRelease = 1991 },
                new Album { Id = 6, Name = "Load", YearOfRelease = 1996 },
                new Album { Id = 7, Name = "Reload", YearOfRelease = 1997 },
                new Album { Id = 8, Name = "Garage Inc", YearOfRelease = 1998 },
                new Album { Id = 9, Name = "St. Anger", YearOfRelease = 2003 },
                new Album { Id = 10, Name = "Death Magnetic", YearOfRelease = 2008 },
                new Album { Id = 11, Name = "Lulu", YearOfRelease = 2011},
                new Album { Id = 12, Name = "Hardwired... to Self-Destruct", YearOfRelease = 2016},
            } },
            new Band { Id = 3, Name = "Ryo Fukui", Description = "Jazz", Albums = new List<Album>
            {
                new Album { Id = 1, Name = "Scenery", YearOfRelease = 1976 },
                new Album { Id = 2, Name = "Mellow Dream", YearOfRelease = 1977 },
                new Album { Id = 3, Name = "My Favourite Tune", YearOfRelease = 1995 },
                new Album { Id = 4, Name = "In New York", YearOfRelease = 1999 },
            } }
        };

        public BandsIndexVM[] ListBands()
        {
            return bands.Select(o => new BandsIndexVM
            {
                Id = o.Id,
                Name = o.Name
            }).ToArray();
        }

        public BandsDetailsVM GetBand(int id)
        {
            var bandToConvert = bands.SingleOrDefault(o => o.Id == id);
            return new BandsDetailsVM
            {
                Id = bandToConvert.Id,
                Name = bandToConvert.Name,
                Description = bandToConvert.Description
            };
        }
    }
}
