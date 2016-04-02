using System;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDatabasePractice.Models {
    public class SampleData {
        public static void Initialize(IServiceProvider serviceProvider) {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            if(!db.Categories.Any()) {
                db.Categories.AddRange(
                    new Category {
                        Name = "Drama",
                        Movies = new List<Movie> {
                            new Movie { Title = "Steel Magnolias", Director = "Herbert Ross"},
                            new Movie { Title = "Training Day", Director = "Antoine Fuqua" }
                        }
                    }, new Category {
                        Name = "SciFi",
                        Movies = new List<Movie> {
                            new Movie { Title = "Star Wars", Director = "George Lucas"},
                            new Movie { Title = "Memento", Director = "Christopher Nolan" },
                            new Movie { Title = "Ex Machina", Director = "Alex Garland" }
                        }
                    }
                );
                db.SaveChanges();
            }
        }
    }
}
