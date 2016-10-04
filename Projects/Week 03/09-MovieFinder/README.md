# Movie Nerd

In this assignment, you will be building an app that allows movie nerds to search for their favorite movies/tv shows.

You should make use of Angular JS, Bootstrap and the OMDB API (http://omdbapi.com) to complete this assignment.

<img src="http://i.imgur.com/ebody6P.png" /> 

## Tasks
1. Create a folder named `09-MovieFinder` in your `dev` folder.
2. Setup your Git workflow.
  - Initialize an empty git repository in `09-MovieFinder` by running `git init` in the command prompt.
  - Create a repository on GitHub called `09-MovieFinder` and follow the instructions to add a remote origin.
3. Open this folder in your favorite text editor (Ours is Sublime!)
4. Create a file structure similar to the following (Folder by feature)
```
/
|__ bower_components
|__ app
   |__ core
      |__ movie.factory.js
   |__ search
      |__ search.controller.js
      |__ search.html
   |__ detail
      |__ detail.controller.js
      |__ detail.html
   |__ app.module.js
   |__ index.html

```
5. Make use of the following AngularJS features to build this application.
  - Configure routing using the `angular-ui-router` package to create two seperate states. One for the Search view, and one for the Detail view.
  - Create a `factory` and inject a `$http` service to call the OMDB API.
  - Create a `controller` and factory you created above **DO NOT USE `$scope`**. Figure out the code you'll need to write to facilitate the given requirements.
  
## Requirements
* Must be able to search for movies.
* Must show results of the search for the movies.
* Must be able to view more information for a particular movie. (The design of this page is up to you!)

## Helpful Links
* https://scotch.io/tutorials/angular-routing-using-ui-router
* https://docs.angularjs.org/api/ng/service/$http
* http://www.sitepoint.com/api-calls-angularjs-http-service/

## Turn in instructions
* Push your changes to GitHub 
* [Click here to create an issue in the class repository](https://github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=09-MovieNerd&body=1.%20Where%20can%20I%20find%20your%20repository%3F%0D%0A%0D%0A%0D%0A%0D%0A2.%20Did%20you%20complete%20any%20of%20the%20extras%3F)
	* Include a link to your repository in the description
	* Answer the questions filled out for you in the description
