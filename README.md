<h1 align='center'><img width='900' height='450' src='AirPet/wwwroot/img/WalkDog.jpg'><br>


**<h1 align = 'center'>AirPET**


*<h2 align ='center'>Hit the Road. (new friends included)*


<h3 align ='center'>•<a href='#requirements'> Requirements</a> •<a href='#setup'> Setup</a> •<a href='#technologies-used'> Technologies</a> •<a href='#❤️contributors'> Contributors</a> •<a href='#protecting-your-data'> Protecting Data</a> •<a href='#specifications'> Specs</a> •<a href='#cloning'> Cloning</a> •<a href='#app-settings'> AppSettings</a> •<a href='#database-with-migrations'> Database</a></h3>


<h3 align='center'>AirP.E.T. is a website to connect people who are looking for a petsitter with those who want to petsit. Users looking for pet sitters open their homes for travelers looking for accommodations. Sitters save money on a place to stay, and those seeking petcare don't have to worry about boarding their pets, which is both stressful for the animal and expensive for their owner. </h3>

# **SPECIFICATIONS**

As a user I should be able to:

* Create an account, log in, and log out

* Fill out a profile
    * Sitter or seeker
    * Destination or location
    * Pet experience or pets needing sitter
    * Photo
    * dates of travel or dates needing sitter
    * bio

* Search for
    * user by type: pet sitter or seeking a sitter
        narrow results by: 
              * location
              * date of travel
              * type of pet

* See a list of users who match criteria

# **SETUP**

## **CLONING**

* Copy the repo link as shown in the image below

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone.gif 'How to clone repo')

* Paste the link in the field provided by VsCode as thown in the image below

* You will be prompted to open the directory once you have cloned it. Select 'open'

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif 'Cloning from Github within VSCode')

<br>

# **APP SETTINGS**

**You need to update your username and password in the appsettings.json file.**

_By default these are set to user:root and an empty password. If you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

# **PROTECTING YOUR DATA**

* Step 1: create a .gitignore file in the top level of your project directory. populate the file as shown in step 1 of the image below.

* Step 2: commit that .gitignore file (this prevents your sensitive information like your API key being shown to others). **DO NOT PROCEED UNTIL YOU DO THIS!**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/readme-image-3.jpg 'Set up instructions')

<br>

# **DATABASE WITH MIGRATIONS**

with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet ef database update``

<br>

# **TECHNOLOGIES USED**

_[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_

_[CSS](https://en.wikipedia.org/wiki/Cascading_Style_Sheets)_

_[Bootstrap](https://getbootstrap.com/)_

_[Asp.Net MVC](https://dotnet.microsoft.com/apps/aspnet/mvc)_

_[HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)_

_[Jquery](https://jquery.com/)_

_[Visual Studio Code](https://code.visualstudio.com/)_

_[MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

# **INSTALL**

## **INSTALLING WITH DOTNET**


with the root project folder open in your code editor, execute the following in your terminal:

``cd ProjectName``

``dotnet restore``

``dotnet build``

``dotnet watch run``

<br>

# **❤️Contributors**

| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/linked-in-images/beverly-potts.jpeg' width='160px;'/><br /><sub><b>Beverly Potts</b></sub>](https://www.linkedin.com/in/beverlypotts/)<br />

<br>

<br>

![alt text][logo]

[logo]: https://img.shields.io/bower/l/bootstrap 'MIT License'

 