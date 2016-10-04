# Todo Unit Tests

Your assignment today is to write unit tests for an existing todo application.

## Tasks

* Fork and Clone the [todo-tests](https://github.com/cameronoca/todo-tests) repository.
* Install the necessary packages needed to run Jasmine unit tests in Karma
* Write and add the unit tests described in the section below.

## Setup

### 1. Install Karma + Jasmine
`npm install -g karma-cli`<br />
`npm install karma karma-jasmine jasmine-core karma-chrome-launcher karma-sinon --save-dev`

`karma`: our test runner<br />
`karma-jasmine`: plugin for karma to run jasmine tests<br />
`jasmine-core`: core library for our jasmine tests<br />
`karma-chrome-launcher`: launches chrome to run unit tests<br />
`karma-sinon`: plugin for karma to work with sinon - a mocking framework

### 2. Install Angular Test Dependencies in your project
`bower install angular-mocks bardjs  --save-dev`<br />

`angular-mocks`: a set of pre-written mocks for angular services<br />
`bardjs`: makes it simple to use angular-mocks in your Jasmine tests

### 3. Initialize karma in your project
`karma init`


### 4. Add necessary files to karma.conf.js
"These need to be loaded in order for Karma to reference them for testing"
```js
files: [
  'src/bower_components/angular/angular.js',
  'src/bower_components/angular-mocks/angular-mocks.js',
  'src/bower_components/sinon/index.js',
  'src/bower_components/bardjs/dist/bard.js',
  'src/app/**/*.js'
],
```

### 5. Add sinon framework to Karma
"This tells Karma to use the following plugins as frameworks. Run jasmine tests, and use sinon as a dependency for bardjs"
```js
frameworks: ['jasmine', 'sinon']
```

### 6. Run karma for the first time, verify that the output shows `0 of 0 successful`
karma start

### 7. Add a `todo.controller.spec.js` file for TodoController
Write a unit test for the `addTodo`, `removeTodo` and `getAllTodos` functions as shown in todays video.

### 8. Add a `todo.factory.spec.js` file for TodoController
Write unit tests for the 5 service methods in the todo factory as shown in todays video.

## Extras
* Can you think of any other unit tests that should be written? Try thinking of ways the application could break, then write unit tests to cover that scenario.

## Turn In Instructions
* Push your changes to GitHub using `git push origin master`
* [Click here to create an issue in the class repository](https://www.github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=17-TodoUnitTests&body=1.%20Where%20can%20I%20find%20your%20repository%3F%20(Paste%20the%20url%20of%20your%20repository%20below)%0A%0A2.%20Did%20you%20manage%20to%20write%20unit%20tests%3F%0A%0A3.%20How%20many%20unit%20tests%20did%20you%20write%3F)
    * Include a link to your repository in the description
    * Answer the questions filled out for you in the description