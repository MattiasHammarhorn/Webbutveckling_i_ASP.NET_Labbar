using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopBands.Models
{
    public class DataManager
    {
        // Declaration of variables, including the list of the Album-class inside each band
        static List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Deep Purple",
            Description = "Deep Purple is an English rock band formed in Hertford, England, 1968. The band is considered to be one of the pioneers of heavy metal and hard rock and is most famously known for its second line-up labeled Mark 2, consisting of Ian Gillan (vocals), Jon Lord (keyboards, backing vocals), Roger Glover (bass), Ian Paice (drums) and Ritchie Blackmore (guitar). The bands most famous songs are arguably 'Smoke on the Water' from the 'Machine Head' album. With Gillan's high screams, Lord's fierce organ-playing, Paice's energetic drumming, Glover's complex basslines and Ritchie's mix of neoclassic music and blues, the band quickly made their way to the high top to dominate the early 70s before their breakup in 74 and eventual reunion in 84, with Ritchie being the prime mover. The band has seen many changes in its lineup and has played many styles and now consists of original members Ian Gillan, Roger Glover, Ian Paice and new members Steve Morse (guitar) and Don Airey (keyboards).",
            Albums = new List<Album>
            {
                new Album { Name = "Shades of Deep Purple", Year= 1968, Label = "Parlophone", Url="Deep Purple1"},
                new Album { Name = "The Book of Taliesyn", Year = 1968, Label = "Harvest", Url="Deep Purple2"},
                new Album { Name = "Deep Purple", Year = 1969, Label = "Harvest", Url="Deep Purple3"},
                new Album { Name = "Deep Purple in Rock", Year = 1970, Label = "Harvest", Url="Deep Purple4" },
                new Album { Name = "Fireball", Year = 1971, Label = "Harvest", Url="Deep Purple5" },
                new Album { Name = "Machine Head", Year = 1972, Label = "Purple", Url="Deep Purple6" },
                new Album { Name = "Who Do We Think We Are?", Year = 1973, Label = "Purple", Url="Deep Purple7"},
                new Album { Name = "Burn", Year = 1974, Label = "Purple", Url="Deep Purple8" },
                new Album { Name = "Stormbringer", Year = 1974, Label = "Purple", Url="Deep Purple9" },
                new Album { Name = "Come Taste the Band", Year = 1975, Label = "Purple", Url="Deep Purple10"  },
                new Album { Name = "Perfect Strangers", Year = 1984, Label = "Polydor", Url="Deep Purple11" },
                new Album { Name = "The House of Blue Light", Year = 1987, Label = "Polydor", Url="Deep Purple12" },
                new Album { Name = "Slaves and Masters", Year = 1990, Label = "BMG", Url="Deep Purple13" },
                new Album { Name = "The Battle Rages On...", Year = 1993, Label = "BMG", Url="Deep Purple14" },
                new Album { Name = "Purpendicular", Year = 1996, Label = "BMG", Url="Deep Purple15" },
                new Album { Name = "Abandon", Year = 1998, Label = "EMI", Url="Deep Purple16" },
                new Album { Name = "Bananas", Year = 2003, Label = "EMI", Url="Deep Purple17" },
                new Album { Name = "Rapture of the Deep", Year = 2005, Label = "Edel", Url="Deep Purple18" },
                new Album { Name = "Now What!?", Year = 2013, Label = "earMusic", Url="Deep Purple19" },
                new Album { Name = "Infinite", Year = 2017, Label = "Edel", Url="Deep Purple20" }
            }},
            new Band { Id = 2, Name = "Thin Lizzy",
            Description = "Thin Lizzy is an Irish rock band formed in Dublin, Ireland, 1969. The band is most known for its unique sound of merging guitar harmonies together with singer, Phil Lynott's simple but effective melodies. Phil Lynott is the first example of a black Irish man achieveing commercial succes in a multiracial band whose influences span through soul, blues n, psychadelic rock and traditional Irish folk music. Thin Lizzy's most famous songs are 'The Boys Are Back In Time' and their cover of the traditional Irish song 'Whiskey in the Jar'. Unfortunelaly, the band would not see any new content after 1983, when the band broke up and Phil Lynott later died in a suit due to organ failure from prolonged drug-and alcohol abuse, in 1986. Former bandmates has since dedicated many tribute projects in honour of Lynott and have even toured as 'Thin Lizzy', but have only played old songs then.",
            Albums = new List<Album>
            {
                new Album { Name = "Thin Lizzy", Year = 1971, Label = "Decca", Url="Thin Lizzy1" },
                new Album { Name = "Shades of a Blue Orphanage", Year = 1972, Label = "Decca", Url="Thin Lizzy2" },
                new Album { Name = "Vagabonds of a Western World", Year = 1973, Label = "Decca", Url="Thin Lizzy3" },
                new Album { Name = "Nightlife", Year = 1974, Label = "Mercury Records", Url="Thin Lizzy4" },
                new Album { Name = "Fighting", Year = 1975, Label = "Mercury Records", Url="Thin Lizzy5" },
                new Album { Name = "Jailbreak", Year = 1976, Label = "Mercury Records", Url="Thin Lizzy6" },
                new Album { Name = "Johnny the Fox", Year = 1976, Label = "Mercury Records", Url="Thin Lizzy7" },
                new Album { Name = "Bad Reputation", Year = 1977, Label = "Mercury Records", Url="Thin Lizzy8" },
                new Album { Name = "Black Rose: A Rock Legend", Year = 1979, Label = "Vertigo Records", Url="Thin Lizzy9" },
                new Album { Name = "Chinatown", Year = 1980, Label = "Vertigo Records", Url="Thin Lizzy10" },
                new Album { Name = "Renegade", Year = 1981, Label = "Warner Bros.", Url="Thin Lizzy11" },
                new Album { Name = "Thunder and Lightning", Year = 1983, Label = "Vertigo Records", Url="Thin Lizzy12" }
            }},
            new Band { Id = 3, Name = "Sid",
            Description = "Sid (シド, Shido) is a Japanese visual kei rock band formed in 2003 by vocalist Mao and bassist Aki, somewhere near the Kantou Region of Japan. The band would release a MiniDisc titled 'Yoshigai Manabu 17-sai (Mushoku)' in the same year but wouldn't consider themselves whole until January 2004, when guitarist Shinji and drummer Yuuya would join. The band would go on and release their debut single throug their own label. On 22 December, the band would have their debut album Renai released, and would have it reprinted for five years while also reaching #44 on the Oricon overall weekly charts. The band is undoublty known by their western fans for having their songs feautured on opening and ending segments of popular Japanese animated series, such as 'Monokuro no Kiss' for 'Kuroshitsuji' and 'Uso' and 'Rain' for 'Fullmetal Alchemist Brotherhood'. The band has continued to release EPs, singles and other albums.",
            Albums = new List<Album>
            {
                new Album { Name = "Renai", Year = 2004, Label = "SPACE SHOWER MUSIC", Url="Sid1" },
                new Album { Name = "Hoshi no Miyako", Year = 2005, Label = "SPACE SHOWER MUSIC", Url="Sid2" },
                new Album { Name = "Play", Year = 2006, Label = "DANGER CRUE RECORDS", Url="Sid3" },
                new Album { Name = "Sentimental Macchiato", Year = 2008, Label = "DANGER CRUE RECORDS", Url="Sid4" },
                new Album { Name = "Side B complete collection~e.B~", Year = 2008, Label = "DANGER CRUE RECORDS", Url="Sid5" },
                new Album { Name = "Hikari", Year = 2009, Label = "KRE", Url="Sid6" },
                new Album { Name = "Dead Stock", Year = 2011, Label = "KRE", Url="Sid7" },
                new Album { Name = "M&W", Year = 2012 , Label = "KRE", Url="Sid8" },
                new Album { Name = "SID 10t Anniversary BEST", Year = 2013, Label = "KRE", Url="Sid9" },
                new Album { Name = "Side B complete collection~e.B 2~", Year = 2013, Label = "KRE", Url="Sid10" },
                new Album { Name = "Side B complete collection~e.B 3~", Year = 2013, Label = "KRE", Url="Sid11" },
                new Album { Name = "Outsider", Year = 2014, Label = "KRE", Url="Sid12" },
            }}
        };

        // Gets a band whose Id matches our requested id through a lambda-expression
        public static Band GetBand(int id)
        {
            return bands.SingleOrDefault(b => b.Id == id);
        }

        // Returns an array of Bands from our bands-array
        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
