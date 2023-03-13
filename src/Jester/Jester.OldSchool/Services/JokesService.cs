using Jester.OldSchool.Extensions;
using Jester.OldSchool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jester.OldSchool.Services
{
    file record ResponseJoke
    {
        public int id { get; set; }
        public string text { get; set; }
        public bool is12Plus { get; set; }
        public bool is18Plus { get; set; }
        public string created { get; set; }
        public string language { get; set; }
        public string type { get; set; }
        public ResponsePerson author { get; set; }
    }

    public record ResponsePerson(
        string name,
        string linkedInUrl,
        string email
    );

    public static class Converter
    {
        public static Person ConvertToPerson(this ResponsePerson responsePerson)
        {
            return new Person()
            {
                Name = responsePerson.name,
                LinkedInUrl = responsePerson.linkedInUrl,
                Email = responsePerson.email
            };
        }
    }
}

public class JokesService
{
    public Joke GetJoke()
    {

        //var punchline = "I don't know, but the \n flag is a huge plus!";
        //var punchline = $"I don't know, but the {Environment.NewLine} flag is a huge plus!";
        var @string = @"fdqfdsqfdsq";
        // raw string literal
        var punchline = $""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                                {"kevin"
                                   .Trim()
                                   .ToString()}
                                DeRudder
                            """""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""""";

        return null;
    }

    public IEnumerable<Joke> GetJokes()
    {
        string filename = @"Data\jokes.json";

        using StreamReader reader = new StreamReader(filename);
        var json = reader.ReadToEnd();
        IEnumerable<ResponseJoke> source = JsonSerializer.Deserialize<IEnumerable<ResponseJoke>>(json);
        var jokes = source.Select(joke => new Joke()
        {
            Id = joke.id,
            Setup = joke.text,
            Punchline = joke.text,
            Is12Plus = joke.is12Plus,
            Is18Plus = joke.is18Plus,
            Created = joke.created.ParseDate(),
            Language = joke.language,
            Author = joke.author.ConvertToPerson()
        });
        return jokes;
    }



}

