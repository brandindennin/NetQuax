# NetQuax
Spring 2019


# Branching git

1. Go to the repository homepage

2. Click on the branch button, type in a name

3. click create branch

4. In your project, open git bash

5. Type git checkout -b yourBranchName

6. make changes

7. add and commit, save as before

8. for pushing type git push -u origin yourBranchName 

8.5. Once you push,  do not make any more changes to that branch until code is reviewed

9. if git says something about upstream, just follow what it says, I don't remember the exact message it's something like

10. go back to github, it should say compare and pull request on the homepage, click that

11. On the right hand side of the page there should be a reviewers area, code MUST be reviewd before it is committed to 
    master, assign the review to me for now. Then click create pull request.

12. The reviewer will confirm there are no errors and click merge with master, and delete the branch.




# Connecting Your Project to the Database

This must be done in order for the serverside to build

1. SQL Server express and SQL Server Management Studio(SSMS), open SSMS and create a database called NetQuax

 1.5. Run NetQuaxTables.sql and NetquaxDataSeed from the additional dev files folder

2. Add A C# class called Globals.cs to the entities folder, This will NOT be tracked by source control

3. Add a global string variable, it should look like this: public const string connectionString = "placeholder";

4. In visual studio, click view > Server Explorer

5. right click Data Connections > Add Connection

6. TYPE the server name into the Server Name dialog box, mine was DESKTOP-OPHFJM4\SQLEXPRESS

7. Right click on the new connection, click properties and copy the connection string

8. Assign the connectionString variable in Globals.cs to the value you just copied

9. after the Data Source section, add a new section that says Initial Catalog=NetQuax

10. the final connection string should look  ~ like this

 connectionString = @"Data Source=DESKTOP-OPHFJM4\SQLEXPRESS;Initial Catalog=NetQuax; Integrated Security=True";

if the connection string has a backslash the @ character will escape it.


# Hey Guys, Please Read This Before Starting

5:33 March 20th

I added a new folder called entities, this is where we will put the classes and interfaces

6:48 March 18th

I will be uploading the Visual Studio solution either tonight or tomorrow, I'll call it NetQuax. All of the cshtml files should go into the views folder, css in the content folder, and our javascript in the file called app.js in the Scripts folder. Similarly, if we decide to add more models and controllers those will go in their respective folders.

I will also upload a folder for miscellaneous development files for the sql or any supporting documents.

I wil be putting the requirements and design documents in the folder called tech docs so everything is in one place. I also put some c# coding references in the references folder, it's all very similar to java.





