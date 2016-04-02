using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDatabasePractice.ViewModels {
    public class MovieViewModel {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string CategoryName { get; set; }
    }
}
