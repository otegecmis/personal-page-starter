using Personal.Models;

namespace Personal.Repositories;

public class LinksRepository
{
    private static readonly List<Link> links = new();

    static LinksRepository()
    {
        links = new List<Link>()
        {
            new Link() { Id = 1, Title = "GitHub", URL = "https://github.com/otegecmis" },
            new Link() { Id = 2, Title = "HackerRank", URL = "https://hackerrank.com/otegecmis" }
        };
    }

    public static List<Link> List
    {
        get
        {
            return links;
        }
    }
}
