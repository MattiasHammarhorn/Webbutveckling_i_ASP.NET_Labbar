using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment_3.Models
{
    public class DataManager
    {
        public static List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "Kaoru", Email = "kaoru@kurisawa.jp" },
            new Person { Id = 2, Name = "Hassan", Email = "hassan@abdulkadr.al" },
            new Person { Id = 3, Name = "Anders", Email = "anders@persson.se" },
            new Person { Id = 4, Name = "Dudayev", Email = "dudayev@acme.com" }
        };

        // Returnerar den rätta personen vars id stämmer med parametern till vyn
        //public static Person GetPerson(int id)
        //{
        //    return persons.SingleOrDefault(p => p.Id == id);
        //}

        public static void AddPerson(PeopleCreateVM viewModel)
        {
            var person = new Person();
            if (persons.Min(p => p.Id) < 1)
            {
                viewModel.Id = 1;
            }
            else
            {
                viewModel.Id = persons.Max(x => x.Id) + 1;
            }

            person.Id = viewModel.Id;
            person.Name = viewModel.Name;
            person.Email = viewModel.Email;

            persons.Add(person);
        }

        // Tar en person i listan vars id stämmer med id:et vi förfrågar
        // och konverterar det till en vy-modell där vi ger den samma värden
        // sedan returnerar vi den
        internal static PeopleEditVM GetPersonForEdit(int id)
        {
            var person = persons.SingleOrDefault(p => p.Id == id);
            return new PeopleEditVM
            {
                Email = person.Email,
                Name = person.Name
            };
        }

        public static PeopleIndexVM[] ListPeople()
        {
            return persons
                .Select(o => new PeopleIndexVM
                {
                    Id = o.Id,
                    Name = o.Name,
                    Email = o.Email,
                    ShowAsHighlighted = o.Email.EndsWith("acme.com", StringComparison.OrdinalIgnoreCase)
                })
                .ToArray();
        }

        public static Person[] GetAllPeople()
        {
            return persons.ToArray();
        }

        // Tar emot vy-modellen och id:et, skapar en variabel utav en person vars id matchar parametern
        // sedan ger vi vy-modellens properties samma värden som personens.
        // På så sätt så ger vi bara värdena till vy-modellen utan att involvera databas-modellen i controllern eller viewen
        public static void EditPerson(PeopleEditVM viewModel, int id)
        {
            var person = persons.SingleOrDefault(c => c.Id == id);
            person.Name = viewModel.Name;
            person.Email = viewModel.Email;
        }
    }
}
