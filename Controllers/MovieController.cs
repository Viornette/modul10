using Microsoft.AspNetCore.Mvc;

namespace modul10_103022300145.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        public static List<string> stars1 = new List<string>
        {
            "Tim Robbins",
            "Morgan Freeman",
            "Bob Gunton"
        };

        public static List<string> stars2 = new List<string>
        {
            "Marlon Brando",
            "AI Pacino",
            "James Caan"
        };

        public static List<string> stars3 = new List<string>
        {
            "Christian Bale",
            "Heath Ledger",
            "Aaron Eckhart"
        };

        public static readonly List<Movie> movieL = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", stars1, "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", stars2, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
            new Movie("The Dark Knight", "Christopher Nolan", stars3, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieL;
        }

        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            return movieL[id];
        }

        [HttpPost]

        public void Post([FromBody] Movie value)
        {
            movieL.Add(value);
        }

        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            movieL.RemoveAt(id);
        }
    }
}
