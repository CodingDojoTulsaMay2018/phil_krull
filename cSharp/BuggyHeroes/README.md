# Group Assignment: Debug This!

This is a simple .NET Core 2.0 MVC application where you can enter superheroes and then add them to teams. When going to localhost:5000, the user should be able to enter their name. Once added, they should be redirected to a page that allows them to add new teams. The username entered should appear on the nav bar. When the user clicks the "Heroes" link, they should be able to add new heroes, and see all existing heroes.

1. Navigate to the folder where you'd like to download this assignment
2. Make a copy of this assignment with this command:
    - `git clone https://github.com/tehtertot/BuggyHeroes.git`
3. Navigate into the newly created BuggyHeroes folder, which contains this project
4. Run `dotnet restore`
5. Create the schema for this application on your MySQL server 
    - EITHER from command line/terminal: 
        - mysql -u root -p
        - enter your password
        - copy and paste the script found in the dbScript.sql file
    - OR from MySQL Workbench:
        - open up a connection
        - enter your password
        - copy and paste the script found in the dbScript.sql file
        - execute the script by clicking on the lightning bolt (without the cursor or magnifying glass)
5. Find all the bugs!

*Note: You should NOT have to modify the Program.cs file or the database.*