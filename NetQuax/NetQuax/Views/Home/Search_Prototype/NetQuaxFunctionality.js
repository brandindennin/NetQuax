
// get the movies and format them


    $('#butt').click(function(){
        let movieSearch = $('#searchText').val()
        // console.log($('#searchText').val());
        console.log(movieSearch);
        getMovies(movieSearch);
    });
    
    // search for movie
    function getMovies(movieSearch){
        axios.get('http://www.omdbapi.com/?s='+movieSearch+'&apikey=13b99c79')
        .then((response)=>{
        console.log(response);
        let movies = response.data.Search;
        console.log(movies)
        let output ='';
        $.each(movies, (index, movie)=>{
            output +=`
            <div class="col-md-4">
                <div class="well text-center">
                <img src='${movie.Poster}'>
                <h5>${movie.Title}</h5>
                <a onclick="'${movie.imdbID}'" class='btn btn-primary' href="#">Movie Details</a>
                </div>
            </div>
        `
        }); 
            
        console.log(output);
        $('#movies').html(output);
        console.log("plup")
        })
        .catch((err) =>{
            console.log(err);
        })
    }

/* get default movies */

