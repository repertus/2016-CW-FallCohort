# Classroom Manager

This assignment is a week long project, broken into manageable chunks throughout the week.

The goal is to build a web application that helps teachers of any subject manage who their students are, what their projects are, and the assignment of projects to students.

## Toolbox
You will be using everything you have learned in the last 5 weeks to complete this project. 

**Required Tools**
```
--Backend--
SQL Server
Entity Framework
ASP Web API

--Frontend--
HTML5
CSS Frameworks (You do not have to use Bootstrap!)
Angular
Angular-UI-Router
Angular-Toastr
```

## Data Requirements
`Student`
```
StudentId
FirstName
LastName
EmailAddress
Telephone
```

`Project`
```
ProjectId
Name
Description
```

`Assignment`
```
StudentId  --|
ProjectId  --|
					   |_ These in combination form a composite key. Refer to Monday's lecture to see how this is modelled in Entity Framework.
```

## Relationships
`A student has many assignments`, therefore `An assignment has a student`
`A project has many assignments`, therefore `An assignment has a project`

## Screenshots
**Dashboard**<br />
<img src="http://imgur.com/a/mPatn.png" alt="">

**Student Grid Screen**<br />
<img src="http://imgur.com/a/ALMki.png" alt="">

**Student Detail Screen**<br />
<img src="http://imgur.com/a/oEjtx.png" alt="">

**Project Grid Screen**<br />
<img src="http://imgur.com/a/dxATB.png" alt="">

**Project Detail Screen**<br />
<img src="http://imgur.com/a/6A0Dp.png" alt="">

## Extras
(In this order)

* Refactor your application to use Uncle Bobs Clean Architecture as shown on Tuesday.
* Write unit tests for your C# API.
* Write unit tests for your Angular Application.

## Turn in instructions
* Push your changes to GitHub 
* [Click here to create an issue in the class repository](https://www.github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=18-ClassroomManager&body=1.%20Where%20can%20I%20find%20your%20repository%3F%20(Paste%20the%20url%20of%20your%20repository%20below)%0A%0A2.%20How%20many%20screens%20were%20you%20able%20to%20complete%3F%0A%0A3.%20Did%20you%20complete%20any%20of%20the%20extras%3F)
	* Include a link to your repository in the description
	* Answer the questions filled out for you in the description