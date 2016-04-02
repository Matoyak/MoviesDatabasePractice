namespace MoviesDatabasePractice.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }

    export class MovieListController {
        public movies;

        constructor(private $http: ng.IHttpService) {
            $http.get('/api/movies')
                .then((response) => {
                    this.movies = response.data;
                });
        }
    }

    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
