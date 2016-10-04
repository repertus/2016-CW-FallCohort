## Week 8 - NoshSpot Group Project

<img src="http://www.gridgit.com/postpic/2009/08/agile-software-development-life-cycle_279700.jpg" />

In this project you will be working as a team to build a food ordering service using the SWAC stack (SQL Server, Web API, AngularJS, C#).

The project will be managed in an Agile fashion, faciliting Scrum to communicate progress with eachother and the Product Owner.

You will also be utilizing a combination of Mob Programming and Pair Programming throughout the project, where appropriate.

The **Product Owner/Scrum Master** for this project will be Cameron. (Note that usually these are two seperate entities in Scrum).<br/>
The **Development Team** for this project will be you guys!

### Introduction
A local entrepreneur has a great idea for a system to provide restaurants in Downtown San Diego that don't currently accept online orders the ability to do so. Your team has been contracted to design the initial version of this system.

The product owner envisions a system comprised of three applications, **in the following priority**.

- A "superuser" app that allows the product owner to enter new restaurants into the system
- A customer website to allow customers to place orders
- A restaurant website to allow restaurants to view orders made to their restaurant

### Mockups
Initial mockups have been created by the Product Owner for the benefit of the development team, [you can view them here](https://1drv.ms/b/s!ArMVQT-XVrJsgbs-Dc9eE0moD18Wug)

### Tasks
**Release Planning Meeting**

Meet with the Scrum Master and the rest of the development team to plan what features will be delivered in the first release, then break down the release features into manageable sprints.

**Project Setup**

Create a Repository on GitHub, and ensure that everybody on the team has access to the repository by adding them as a collaborator. **Take the time here to read [A successful Git branching model](http://nvie.com/posts/a-successful-git-branching-model/). Seriously, spend a whole day here if you have to. It'll help.**

**Build the Database as a mob**

Before you begin coding - take some time to discuss your data model by drawing Entity Relation Diagrams on [Draw.io](https://www.draw.io). Save these to the Trello board created during the Release planning meeting.

After you have your data model drawn up, build the database for using Entity Framework as a mob. When the database is generating to the team's satisfaction, the driver should push the changes to GitHub. 

**Build the Web API in pairs**

You should now break away from mob programming to delegate controller creation to pairs in your team. This is a good chance for you to practice creating branches and creating pull requests into the master branch. **Before you merge changes back into the master branch...**

**Perform a Mob Code Review**

As a team, perform a code review for each pull request that has been made, checking for style inconsistencies and functionality issues. Once this has been done, you can merge all branches into the master branch.

**Mob Develop the initial layout/states of the user interface**

As a mob, pull the master branch to a machine (now complete with everyones changes). Then shell out the layout of the application - making group decisions about design at this point, such as preferred CSS framework and use of components within that framework.

When the application has been shelled out sufficiently (State Definitions / Controllers / Templates / Navigation), the driver should push the changes to GitHub.

**Pair program the necessary screens**

After this point, work will be done in pairs. Before working, decide as a team who will work on each screen to be built. Each pair should make a feature branch, then once the screen is finished, issue a pull request into the development branch. Repeat this process for each screen you have been tasked with building.

**Integrate all the individual branches as a mob**

(Your instructor will sit down with you and help with this). Now, it's time for all of your efforts will be combined into the first release of MedAgenda!

**Bug Fixes/Improvements as necessary**
	
**Demo your application in front of Cohort 6.0**

Create a short presentation (no more than 10 minutes) to demo your project. Your presentation should be composed of the following

- Briefly describe the project
- Outline the technologies used for the project
- Demo the project
- Q+A
