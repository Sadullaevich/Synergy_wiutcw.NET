# Synergy_wiutcw.NET
I created application for my university assessment using SQLite database and C# alongside .NET. 
Task Description:
You are required to design an SQLite database and C#-based software for managing the employees and recording their swipes (swipe is an event of getting in and
out from the workplace). The database should have the following structure:
Table em_employee – contains information on all employees of a company
em_id Artificial Id for the table (autonumber, primary key)
em_name Name of the employee
em_is_active Indicates if the employee can or cannot make swipes
em_start_date First day of work of the employee
em_discharge_date Last day of work of the employee, set to 1-Jan-2050 if the employee is not
planned for termination.
Table sp_swipe – contains swipes for the employees
sp_id Artificial Id for the table (autonumber, primary key)
sp_emp_id Link to em_employee table, contains the ID of the employee
sp_date Contains the date of the swipe
sp_in Contains the IN time i.e. the time employee started to work that day
sp_out Contains the OUT time i.e. the time employee stopped the work that day
Based on a series of interviews with the team lead, you have identified the following requirements for the
system to be developed:
1. Manage employees
 Display all employees stored in the database
 Enable addition/editing of the employees
 Make sure to validate the user input
 Enable deletion of employees’ records
 em_employee table can have related records in sp_swipe table, you should not allow
deleting the employees with swipes.
 Persist employee’ information in the database
 Allow sorting the employees by name
 Allow filtering the employees by “Is active” status => to show only Active, only Inactive or all.
2. Manage swipes
 Display all swipes stored in the database
 Enable registering new swipes
 Make sure to validate the user input as follows:
 Duplicate swipes are not allowed => don’t allow to save the data if the database
already contains a record with the same sp_emp_id and sp_date
 Inactive employees cannot swipe => don’t allow to save the data if the employee
selected has “Is active” set to False
 Not-yet-started employees cannot swipe => don’t allow to save the data if the
selected employee has “Start date” set to a later date then swipe’s date
 Already terminated employees cannot swipe => don’t allow to save the data if the
selected employee has “Discharge date” set to an earlier date then swipe’s date
 Swipes cannot be modified, so don’t allow editing or deletion of the records
 Persist swipes’ information in the database
And one more important note: your solution should be implemented using C# for code part and use an
SQLite database.
