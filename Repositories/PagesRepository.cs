using Personal.Models;

namespace Personal.Repositories;

public class PagesRepository
{
    private List<Page> _pages;

    public PagesRepository()
    {
        _pages = new List<Page>()
        {
            new Page()
            {
                Title = "Home",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse blandit tellus quis odio ullamcorper pulvinar. Maecenas ac magna velit. Sed mi est, cursus id mauris eu, mollis tincidunt nibh. Sed nisi dolor, ornare ac elementum non, laoreet vitae ex. Nulla dictum fringilla dapibus. Suspendisse lacus leo, fringilla sit amet augue id, maximus suscipit nunc. Morbi ullamcorper tortor leo, sed ultrices diam dictum id."
            },
            new Page()
            {
                Title = "Resume",
                Content = "Vivamus ipsum urna, convallis viverra elementum sit amet, tempus id purus. Nunc sed semper mauris. Praesent lobortis leo nisl, a imperdiet ligula convallis ut. Etiam justo enim, scelerisque a volutpat a, tristique ac ligula."
            },
            new Page()
            {
                Title = "Contact",
                Content = "Aenean dolor erat, venenatis a fringilla nec, aliquam non ex."
            }
        };
    }

    public Page GetByTitle(string title)
    {
        return _pages.FirstOrDefault(p => p.Title == title);
    }
}