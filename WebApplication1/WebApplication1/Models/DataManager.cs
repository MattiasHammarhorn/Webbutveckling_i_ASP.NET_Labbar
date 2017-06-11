using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class DataManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Pink Floyd", Description = "Awesome stuff.." },
            new Band { Id = 2, Name = "Brian Eno", Description = "Ambient stuff.." },
            new Band { Id = 3, Name = "Iron Maiden", Description = "Hard stuff.." },
        };

        public static Band GetBand(string name)
        {
            return bands.SingleOrDefault(b => b.Name == name);
        }

        internal static void AddBand(Band band)
        {
            band.Id = bands.Max(o => o.Id) + 1;
            bands.Add(band);
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }

        public static BandsIndexVM[] GetIndexList()
        {
            return bands
                .Select(o => new BandsIndexVM
                {
                    Id = o.Id,
                    Name = o.Name,
                    IsMetal = o.Name.StartsWith("iron", StringComparison.OrdinalIgnoreCase)
                })
                .ToArray();
        }
    }
}
