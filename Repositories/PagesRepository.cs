using Personal.Models;

namespace Personal.Repositories;

public class PagesRepository
{
    private List<Page> _pages;

    public PagesRepository()
    {
        _pages = new List<Page>()
        {
            new Page() { Title = "Home", Content = "This is my home page." },
            new Page() { Title = "Resume", Content = "This is my resume page." },
            new Page() { Title = "Contact", Content = "This is my contact page." }
        };
    }

    public Page GetByTitle(string title)
    {
        return _pages.FirstOrDefault(p => p.Title == title);
    }
}