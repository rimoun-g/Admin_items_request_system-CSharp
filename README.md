# Admin items

A simple C# application to process requests for items.

## Idea:
For many businesses, there are employees who recieve items to be used by them. This system will allow you to record transactions and keep track of them like:
- What items did the employee recieve?
- When the last time an employee recieved an item.
- Track the items, quantities, value.  

Basic plan of the project:
![alt text]( https://i.imgur.com/PMvPJog.jpg "Basic plan of the project")

## Implementation:
The application has three main windows:  
1. **Transactions:**
    1. For adding a transaction only.
    
2. **Administration tools:**
    1. Adding/Updating/Deleting an item.
    2. Adding/Updating/Deleting an item subcategory.
    3. Adding/Updating/Deleting a user.
    4. Deleting Transactions.
    5. Adding Employees.
    
3. **Reports:**
    1. Customized reports (based on filters).
    2. General report.  

## Layers:
**The Application is made from three layers:**
1. Database layer.
2. Data Layer.
3.Application Layer  

## SQL:
The used databse to store records is a Sqlite file, however the same can be done with Sql server.
