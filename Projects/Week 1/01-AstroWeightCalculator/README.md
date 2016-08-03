# Astro Weight Calculator

<img src="http://i.imgur.com/x189kBb.png" />

For this assignment, you've been hired by the NASA Jet Propulsion Laboratory to create a simple weight calculator that would be used by future astronauts to calculate their weight on the surface of the 9 planets (okay, 8 planets and a dwarf!) as well as the moon and the sun of our solar system.

## First - setup a simple `node-static` web server
`node-static` is a simple, RFC2616 compliant file streaming module for Node.js which can be used for making any of your directories a static file server. You can use this as a command-line tool to make a directory to a server or as a library for creating custom file server.

`node-static` can be easily installed using npm (we'll make it global for using the command-line tool)

## Tasks

1. From the Terminal in Mac or the command prompt in Windows enter:  

`npm install -g node-static`

2. To start the server, navigate to the directory from where you want to serve your files and hit the following command:

`static . ` 

3. You should see the following output:

`serving "." at http://127.0.0.1:8080`

4. This means the server started at port 8080 with the current directory as webroot. Read the node-static documentation to learn more about this library.


Note:  If you are using a Mac and encounter error messages like 'EACCES', you will need to fix your permissions:

https://docs.npmjs.com/getting-started/fixing-npm-permissions

## Project Tasks

1. Create a folder named `dev` to store all of your future projects.
    - For Mac - create a `dev` folder in your Home Directory.
    - For Windows - create a `dev` folder in the top level of your `C:` drive.
2. Create a folder named `01-AstroWeightCalculator` in your `dev` folder.
3. Initialize an empty git repository in `01-AstroWeightCalculator` by running `git init` in the command prompt.
4. Open this folder in your favorite text editor (Ours is Sublime!)
5. Create an `index.html` file and a corresponding `index.js` file.
6. Create a basic HTML page, and make sure it has the following HTML elements.
    - An `input` element for the user to enter their weight.
    - A `select` element for the user to select a planet, populated with `option` elements where the value attribute is set to the surface gravity for that planet, and the content inside of the `option` elements represents the name of that planet.
    - A `button` element for the user to calculate their weight based on the above inputs.
    - A `p` element to display the expected output.
7. Also make sure you reference your `index.js` before the `</body>` tag.
8. Write the following JavaScript in your `index.js` file
    - Create a function that will be called when the user clicks on the `button` element you added to your HTML.
    - This function should grab the values entered by the user from the `input` element and the `select` element.
    - The function should then calculate the weight of the user on the selected planet, and show the weight to the user in the `p` element you added to your HTML.
     
## Planet Data
<table>
    <thead>
        <tr>
            <th>Planet Name</th>
            <th>Multiple of Earth Gravity</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Sun</td>
            <td>27.9</td>
        </tr>
        <tr>
            <td>Mercury</td>
            <td>0.377</td>
        </tr>
        <tr>
            <td>Venus</td>
            <td>0.9032</td>
        </tr>
        <tr>
            <td>Earth</td>
            <td>1</td>
        </tr>
        <tr>
            <td>Moon</td>
            <td>0.1655</td>
        </tr>
        <tr>
            <td>Mars</td>
            <td>0.3895</td>
        </tr>
        <tr>
            <td>Jupiter</td>
            <td>2.640</td>
        </tr>
        <tr>
            <td>Saturn</td>
            <td>1.139</td>
        </tr>
        <tr>
            <td>Uranus</td>
            <td>0.917</td>
        </tr>
        <tr>
            <td>Neptune</td>
            <td>1.148</td>
        </tr>
        <tr>
            <td>Pluto</td>
            <td>0.06</td>
        </tr>
    </tbody>	
</table>

## Turn In Instructions
* Push your changes to GitHub 
* [Click here to create an issue in the class repository](https://www.github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=01-AstroWeightCalculator&body=1.%20Where%20can%20I%20find%20your%20repository%3F%20(Paste%20a%20link%20below)%0A%0A2.%20What%20was%20your%20best%20accomplishment%20in%20this%20project%3F%0A%0A3.%20What%20was%20the%20most%20challenging%20piece%20of%20this%20project%20for%20you%3F)
    * Include a link to your repository in the description
    * Answer the questions filled out for you in the description	
    * You will receive 10XP for handing in this assignment. You do not earn extra points for handing it in sooner, or for the quality of your code.