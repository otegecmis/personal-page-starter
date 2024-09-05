namespace Personal.Models;

public class LinkRepository
{
    private static readonly List<Link> links = new();

    static LinkRepository()
    {
        links = new List<Link>()
        {
            new Link() { Id = 1, Title = "GitHub", URL="https://github.com/otegecmis" },
            new Link() { Id = 2, Title = "HackerRank", URL="https://hackerrank.com/otegecmis" }
        };
    }

    public static List<Link> List
    {
        get
        {
            return links;
        }
    }

    public static Link? GetById(int? id)
    {
        return links.FirstOrDefault(c => c.Id == id);
    }
}
