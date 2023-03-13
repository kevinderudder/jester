

using BenchmarkDotNet.Running;
using Jester.OldSchool.Benchmarks;
using Jester.OldSchool.Models;


ReadOnlySpan<byte> span = "Kevin DeRudder"u8;
Console.WriteLine(span.ToString());

Person author = new Person()
{
    Name = "Kevin DeRudder",
    LinkedInUrl = "https://www.linkedin.com/in/kevinderudder",
    Email = "kevin.derudder@gmail.com"
};

Joke joke = new Joke() {
    
   Setup = "What do you call a cow with no legs?",
    Punchline = "Ground beef",
};
joke.Punchline = "Ground beef.";
joke.Is12Plus = true;
joke.Is18Plus = false;
joke.Author = author;
joke.Language = "English";
joke.Created = DateTime.Now;

//BenchmarkRunner.Run<ValidatorBenchmarks>();


DadJokesService service = new DadJokesService();
var response = service.GetJokes();
Console.WriteLine(response.Count());




