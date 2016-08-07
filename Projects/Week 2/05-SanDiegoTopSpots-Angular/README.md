# San Diego Top Spots

There are some great places to see in downtown San Diego. In this project you'll get to know a few of them by turning the provided JSON file into a table in HTML with links to Google Maps using Angular.

<img src="http://i.imgur.com/4UU4Ye4.png" />


## Tasks
1. Create a folder named `05-SanDiegoTopSpots-Angular` in your `dev` folder.
2. Setup your Git workflow.
  - Initialize an empty git repository in `06-SanDiegoTopspots` by running `git init` in the command prompt.
  - Create a repository on GitHub called `06-SanDiegoTopspots` and follow the instructions to add a remote origin.
3. Open this folder in your favorite text editor (Ours is Sublime!)
4. Create an `index.html` file and a corresponding `index.js` file.
5. Download [topspots.json]("https://github.com/OriginCodeAcademy/2016-CW-FallCohort/tree/master/Projects/Week%201/05-SanDiegoTopSpots/topspots.json") to your `06-SanDiegoTopspots` folder.
6. Create an HTML `table` structure with the headers you see in the image above.
7. Also make sure you reference your `index.js` before the closing `</body>` tag.
8. Write the following JavaScript in your `index.js` file
	- Create an Angular module.
	- Create an Angular controller.
	- Use the `$http` angular service to download the contents of `topspots.json` into your controller.
	- Use angular bindings to bind the locations to your view in your html.
9. To start/test your application - navigate to `05-SanDiegoTopSpots-Angular` in command line and run `static .` to start a web server that you can access by going to `http://localhost:8080`.

## Extras
- Move the $http call that retrieves the 'topspots.json' data file into a factory and inject it into your controller.
- Can you create a form to add new locations to the topspots array?
- Can you find an Angular plugin to show the locations on a google map?

## Turn In Instructions
* Push your changes to GitHub using `git push origin master`
* [Click here to create an issue in the class repository](https://www.github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=05-SanDiegoTopSpots-Angular&body=1.%20Where%20can%20I%20find%20your%20repository%3F%20(Paste%20the%20url%20of%20your%20repository%20below)%0A%0A2.%20What%20differences%20have%20you%20noticed%20working%20with%20AngularJS%20vs%20working%20with%20jQuery%20in%20this%20assignment%3F%0A%0A3.%20What%20was%20your%20biggest%20accomplishment%20in%20this%20assignment%3F%0A%0A4.%20What%20was%20your%20biggest%20challenge%20in%20this%20assignment%3F)
    * Include a link to your repository in the description
    * Answer the questions filled out for you in the description
    * You will receive 10XP for handing in this assignment. You do not earn extra points for handing it in sooner, or for the quality of your code.