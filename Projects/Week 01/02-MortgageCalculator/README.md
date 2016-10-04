# Mortgage Calculator

The San Diego real estate market is an excellent place to invest your extra cash. Lets build a mortgage calculator using jQuery to calculate your monthly payment on a home mortgage. 
For this you will need to build a form that accepts the `loan balance`, `interest rate`, `loan term` in years and `period` (either monthly or bi-monthly - every 2 months) and a calculate button that outputs a monthly payment amount to the end user.

## Helpful Images

<img src="http://i.imgur.com/Pn1GDZu.png" />
<img src="http://i.imgur.com/Amq3Vv9.png" />

## Tasks

1. Create a folder named `02-MortgageCalculator` in your `dev` folder.
2. Setup your Git workflow.
  2a. Initialize an empty git repository in `02-MortgageCalculator` by running `git init` in the command prompt.
  2b. Create a repository on GitHub called `02-MortgageCalculator` and follow the instructions to add a remote origin.
3. Open this folder in your favorite text editor (Ours is Sublime!)
4. Create an `index.html` file and a corresponding `index.js` file.
5. Create a basic HTML page, and make sure it has the following HTML elements.
    - An `input` element for the user to enter the mortgage loan balance in US dollars.
   - An `input` element for the user to enter the annual percentage rate of charge (APR).
   - An `input` element for the user to enter the loan term in years.
   - A `select` element for the user to select a period, populated with `option` elements where the value attribute is set to the available periods, in the case, either 'monthly' or 'bimonthly', and the content inside of the `option` elements represents the corresponding number of periods over a year (12 or 6).
   - A `button` element for the user to calculate their monthly mortgage payment based on the above inputs.
   - A `p` element to display the expected output.
7. Also make sure you reference your `index.js` before the `</body>` tag.
8. Write the following JavaScript in your `index.js` file
   - Create a function that will be called when the user clicks on the `button` element you added to your HTML.
   - This function should grab the values entered by the user from the `input` elements and the `select` element.
   - The function should then calculate the monthly payment as follows (we can break this formula into 4 'buckets' for readability):
        
If you are not familiar with some of the terms in the following code sample - you can Google the terms to see what they mean.

```js
// Loan balance is $300,000
var loanBalance = 300000;

// Loan term is 30 years
var loanTerm = 30;

// Period is 12 for monthly, 6 for bi-monthly
var period = 12;

// Annual Interest Rate is 4%
var interestRate = 4;

// number of payments (360)
var numberOfPayments = loanTerm * period;

// monthly interest rate (~0.0033)      
var monthlyInterestRate = (interestRate / 100) / period;

// compounded interest rate (~3.31)
var compoundedIntestRate = Math.pow((1 + monthlyInterestRate), numberOfPayments);

// interest quotient (~0.004)
var interestQuotient  = (monthlyInterestRate * compoundedInterestRate) / (compoundedIntestRate - 1);

// final calculation rounded to two decimal places ($1432.25)
var monthlyPayment = Math.round((loanBalance * interestQuotient) * 100) / 100;
```


## Turn In Instructions
* Push your changes to GitHub using `git push origin master`
* [Click here to create an issue in the class repository](https://www.github.com/OriginCodeAcademy/2016-CW-FallCohort/issues/new?title=02-MortgageCalculator&body=1.%20Where%20can%20I%20find%20your%20repository%3F%20(Paste%20the%20url%20of%20your%20repository%20below)%0A%0A2.%20What%20was%20your%20biggest%20struggle%20in%20this%20assignment%3F%0A%0A2.%20What%20was%20your%20biggest%20accomplishment%20in%20this%20assignment%3F)
    * Include a link to your repository in the description
    * Answer the questions filled out for you in the description
    * You will receive 10XP for handing in this assignment. You do not earn extra points for handing it in sooner, or for the quality of your code.
