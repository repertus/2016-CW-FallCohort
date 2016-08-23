# Build Your Own Universe

In this optional assignment you will be writing classes that work together to create a Universe inside of your computer.

## Tasks
1. Create a new solution in VisualStudio called MyUniverse
1. Create the following C# classes in Visual Studio that meet the following requirements

### Universe
```
- Properties -
Name (string)
Galaxies (List of Galaxies)

- Methods -
AddGalaxy(Galaxy)
```

### Galaxy
```
- Properties -
Name (string)
SolarSystems (List of SolarSystems)

- Methods -
AddSolarSystem(SolarSystem)
```

### Solar System
```
- Properties -
Name
Star (Reference to a Star object)
Planets (List of Planets)

- Methods -
AddStar(Star)
AddPlanet(Planet)
```

### Star
```
- Properties -
Name
```

### Planet
```
- Properties -
Name
LifeForms (List of LifeForm)

- Methods -
AddLifeForm(LifeForm)
```

### LifeForm
```
- Properties -
FirstName
LastName
```

3. In `Program.cs`, write code to generate the following object structure

```
1 Universe containing
	1000 Galaxies, each with
		200 Solar Systems, each with
			1 Star
			10-15 Planets (Look into the Random class) Each with
				10,000-10,000,000,000 life forms
```
Some tools you will need: `for loop`, the `Random`([View Documentation
](http://www.dotnetperls.com/random)) class, the `new` keyword, and the `List<T>`([View Documentation](http://www.dotnetperls.com/list)) data type.

