# _[Vendor Order Tracker V2](https://github.com/TSiu88/VendorOrderTrackerV2)_

#### _Updated Independent Assignment for [Epicodus](https://www.epicodus.com/), 12.30.2022_

#### By _**Tiffany Siu**_

<!-- [![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive) -->
[![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/VendorOrderTrackerV2)
![Languages](https://img.shields.io/github/languages/top/tsiu88/VendorOrderTrackerV2)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Notable Features](#notable-features)
4. [Specifications](#specifications)
5. [User Stories](#user-stories)
6. [Screenshots](#screenshots)
7. [Test Case Example](#test-case-example)
8. [Known Bugs](#known-bugs)
9. [Support and Contact Details](#support-and-contact-details)
10. [License](#license)
---
## Description

This program was originally the Week 10 Friday independent assignment for Epicodus' full time Intro to Programming and C#/React course.  This is a program made to show using the MVC file structure, objects within objects, and RESTful routing naming conventions.

This program is a web application that allows a user to add vendors that buy from this bakery and then add the orders each vendor has ordered from the bakery on their own page.  Vendors can be added with a name and description and viewed on a list of all vendors.  The orders are made inside of the vendor's pages and added to a list on the vendor's page of what was ordered.  Orders can have information like the title of the order, the date, a description, and the price.  

This has been updated to include being able to add in initial data with a json file so it does not start without any data.  Also orders are now sorted with the oldest orders appearing first in the list.

## Setup/Installation Requirements

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _Command Prompt_
* _Web Browser_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/VendorOrderTracker.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` in command line interface of the repository's directory
5. Run `dotnet run` to start up the program in the command line interface
6. Type the URL listed under "Now listening on:" into a web browser to view program

## Other Technologies Used
* _C#_
* _MSTest_
* _Razor_
* _Markdown_

## Notable Features
This program has an object within an object using C# with Razor and HTML.  The site is styled nicely and has a fixed background and footer.  The seed data is written in JSON format and read into the program when it is first run.

## Specifications

<details>
  <summary>Click to expand to view specifications</summary>

| Specification | Input | Output |
| :-------------     | :------------- | :------------- |
| The program displays splash page as homepage with welcome message and link to vendors page | Application start | Welcome message and link displayed on spash page |
| The program shows message that list is empty for that page | On vendor page with 0 Vendors on List | "No vendors added!" |
| The program displays list of vendors with link to fill out form to add a new vendor | On vendor page | List of vendors displayed that can be clicked into, link to add new vendor displayed |
| The user clicks a vendor name to get more information on a vendor and a list of that vendor's orders with a link to add more orders | On a vendor's page | Show vendor information, description, and list of orders with link to add more |
| The user clicks an order to get more information on that order | On an order's page | Show order information, description, price, date, etc. |

</details>

## User Stories

* As a bakery owner, I want to be able to organize vendors and their orders so that I can find requests and their information easily to track business relationships.
* As a vendor, I want to have my orders organized so I can be assured that the bakery is keeping track of my order so they can fulfill it.

## Screenshots

_Here is a preview of what it looks like:_

**Homepage**

![Snippet of homepage](readme-img/snippet1.png)

**Vendor List**

![Snippet of vendor list](readme-img/snippet3.png)

**Order Input**

![Snippet of order input](readme-img/snippet4.png)

<details>
  <summary>Click to expand to view more screenshots</summary>

**Vendor Input**

![Snippet of vendor input](readme-img/snippet2.png)

**Vender Orders**

![Snippet of output box](readme-img/snippet5.png)

**Order Details**

![Snippet of output box](readme-img/snippet6.png)

</details>

## Test Case Example

_Tests are done through MSTest and are run from the command line prompt with `dotnet test` in the test folder._

_Some example test:_

![Snippet of an example test](readme-img/tester1.png)

![Snippet of an example result](readme-img/tester2.png)

## Known Bugs

_There are currently no known bugs in this program_

_README image paths unable to load within project so is currently outside of project folders_

## Support and contact details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

*Background Photo by Ales Krivec on [Unsplash](https:/unsplash.com/photos/QnNqGoCnBg0)*

Copyright (c) 2022 **_Tiffany Siu_**
