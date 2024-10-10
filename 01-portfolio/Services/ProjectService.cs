using _01_portfolio.Models;

namespace _01_portfolio.Services
{
    public interface IProjectService
    {
        List<Project> GetProjects();
    }

    public class ProjectService : IProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>()
            {
                new Project{
                    Title = "Sonibel Website",
                    Description = "The project consisted of developing a comprehensive online sales system for a music store, offering an intuitive and secure platform for both customers and the store owner. The application includes two main interfaces: the sales portal aimed at customers to explore and purchase musical products, and an administrative portal designed for the store owner to manage inventory, orders, and other key aspects of the business.",
                    ImageURL = "/images/sonibel-website.png",
                    Link = "https://sonibelec.com/"
                    },
                new Project{
                    Title = "Continental School Website",
                    Description = "The project involved the design and development of the institutional website for a school, providing a comprehensive and functional digital platform for the educational community. The website provides detailed information about the school, its mission, vision, and values, as well as relevant information about staff, curriculum, and extracurricular activities.",
                    ImageURL = "/images/continental-school-website.png",
                    Link = "https://continentaltiamarita.com/"
                    },
            };
        }
    }
}