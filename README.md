# TodoAppWebApi Creating Migration to DB and Define Connection:

### First steps To run the server: 
* Download the Server.
* Open the server using visual-Studio and run build.

### Second step is to connect to SQL: 
* Open the Data access Folder in the ToDoAppWebApi proj and click on the file  ToDoAppDataContext.ts
* scrol down until you find the function named OnConfiguring()
* in the line of the data soource change to the name of your sql server :
```
"Data Source=DESKTOP-B1CO1K7;Initial Catalog=TodosApp;Integrated Security=True;MultipleActiveResultSets=true"
```
#### Exemple:
```
### DESKTOP-B1CO1K7 ###
```
* Now change also in the appsettings.json file as above to your SQL server Name.
* After this changes please rebuild the project.

### Third step open sql Server:
* Log in to your Sql Server.
* Go back to the server in Visual studio.

### Fourth step makeing the magration of the tables to the sql Server:
*  In the soltion Explorer Right click on the project TodoAppWebApi and click on "Open in terminal".
*  Run this code in the terminal: 
   * dotnet ef database update

### Five step:
* In the Sql Server Refresh the Data Base and look for the new DB that been created with the tables of "Lists" & "Items"

### Six step:
* change the running place to "TodoAppWebApi" and run the server:
![image](https://user-images.githubusercontent.com/33696390/124010956-2c12c600-d9e8-11eb-96db-030ce5677015.png)



