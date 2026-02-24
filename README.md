# Client-Manager
An application for maintaining client records.
The program allows the user to create, read, delete and update records in an external database.

## Features
- Uses a windows form to display all the records in a database
- Allows the user to add, edit, or delete a record in the database
- Shows records in descending order by id number (most recently added get desplayed at the top)

## Skills Demonstrated
- Connecting to a database
- Designing a windows form
- Modular program design (different methods and classes to seperate logic)
- Clear UI design

## How to Run
1. Clone or download this repository
2. Create a simple MySQL database with a table called client_table
3. Add the following columns to client_table (clientID, firt_name, last_name, email, phone_number, address)
4. Make clientID AUTO_INCREMENT
5. Add your connection string for this database into the connectString variable in ClientRepository.cs
6. Build and run the project 

## Example Run

### Main Window
![Main Window](images/C_Sharp_CRUD_Main.png)
