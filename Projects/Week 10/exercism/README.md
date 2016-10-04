# Exercism Exercises

This assignment is intended to keep your mind busy with coding exercises whenever you have free time.

[Exercism.io](http://exercism.io/) is a way to "level up your programming skills". Simply - it's a command line tool that allows you to fetch and solve problems in **33 different programming languages!** Start with JavaScript, but if you're feeling crazy - why not try and see if you can solve some problems in a language you're not familiar with? `Go` is a pretty fun language to code in once you dive in!

<img src="http://i.imgur.com/ifaz1ys.png" />

## 1. Setup Instructions

### 1a. Sign up for Exercism

- [ ] Go to [http://exercism.io/](http://exercism.io/) and sign up for an account.

### 1b. Download the Exercism CLI

#### MacOS 
- [ ] Go download `brew` from their website: [http://brew.sh](http://brew.sh)
- [ ] In Terminal, run `brew update && brew install exercism`. This runs two commands sequentially using the `&&` operator. The first command tells `brew` to `update` itself. The second command tells `brew` to `install` `exercism`.

#### Windows 
- [ ] Go download `choco` from their website: [http://chocolatey.org](http://chocolatey.org)
- [ ] In Command Prompt, run `choco install exercism-io-cli`. This tells `choco` to `install` `exercism`.

### 1c. Link your account to Exercism
- [ ] Login to your [exercism.io](http://exercism.io/) account
- [ ] Find your API key and copy the command to your clipboard

<img src="http://i.imgur.com/RLJHAko.png" />

- [ ] Run this command in Terminal/Command Prompt (depending on whether you're running MacOS or Windows respectively)

## 2. Download the first exercise

- [ ] Run `exercism fetch javascript hello-world`. This will create an `exercism` folder in your user directory.

**Windows**: `C:\Users\{{your_username}}\exercism`<br />
**MacOS**: `~/exercism`

## 3. Open the `exercism` folder in your text editor of choice

<img src="http://i.imgur.com/imCeCNC.png" />

In every challenge that you tell `exercism` to `fetch`, the following files are typically downloaded.

```
|_ challenge-name
	|_ challenge-name.spec.js 			- A set of unit tests
	|_ challenge-name.js				- The file you write your code in
	|_ README.md						- A markdown file with information about the challenge.
```

## 4. Complete the Hello World challenge

- [ ] Complete the hello-world challenge using the screenshot above.
- [ ] Submit the challenge by running `exercism submit javascript/hello-world/hello-world.js` in  Terminal/Command Prompt. (**IMPORTANT** - You must run this command while in the `exercism` folder).
- [ ] Open the link that's printed out to verify submission.

<img src="http://i.imgur.com/mmyl3nN.png" />

## 5. Repeat this process for the rest of the challenges!

The rest of the exercises can be found [here](http://exercism.io/languages/javascript/exercises). Exercism has recommended resources for completing the exercises [here](http://exercism.io/languages/javascript).

Good luck! :D