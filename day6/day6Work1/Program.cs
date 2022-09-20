using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SQL 

            //SELECT COMMAND --> The SELECT statement is used to select data from a database.
            //SELECT * FROM table_name;

            //DİSTİNCT --> The SELECT DISTINCT statement is used to return only distinct (different) values.
            //SELECT DISTINCT Country FROM Customers;

            //WHERE -->The WHERE clause is used to filter records.
            //SELECT * FROM Customers WHERE Country = 'Mexico';

            //SQL AND, OR and NOT Operators
            //The AND operator displays a record if all the conditions separated by AND are TRUE.
            //SELECT column1, column2, ...  FROM table_name WHERE condition1 AND condition2 AND condition3 ...;

            //The OR operator displays a record if any of the conditions separated by OR is TRUE.
            //SELECT column1, column2, ... FROM table_name WHERE condition1 OR condition2 OR condition3 ...;

            //The NOT operator displays a record if the condition(s) is NOT TRUE.
            //SELECT column1, column2, ...FROM table_name WHERE NOT condition;

            //ORDER BY COMMAND -->The ORDER BY keyword is used to sort the result-set in ascending or descending order.
            //To sort the records in descending order, use the DESC keyword.
            //To sort the records in growing order, use the ASC keyword.
            //SELECT column1, column2, ... FROM table_name ORDER BY column1, column2, ... ASC | DESC;

            //INSERT INTO COMMAND -->The INSERT INTO statement is used to insert new records in a table.
            //INSERT INTO table_name (column1, column2, column3, ...) VALUES(value1, value2, value3, ...);

            //NULL Values --> A NULL value is different from a zero value or a field that contains spaces. A field with a NULL value is one that has been left blank during record creation!
            //SELECT column_names FROM table_name WHERE column_name IS NULL;

            //UPDATE COMMAND --> The UPDATE statement is used to modify the existing records in a table.
            //UPDATE Customers SET ContactName = 'Alfred Schmidt', City = 'Frankfurt' WHERE CustomerID = 1;

            //DELETE COMMAND --> The DELETE statement is used to delete existing records in a table.
            //DELETE FROM table_name WHERE condition;

            //TOP, LIMIT, FETCH FIRST or ROWNUM COMMAND
            //TOP --> The clause is used to specify the number of records to return.
            // SQL Server / MS Access Syntax:
            //SELECT TOP number | percent column_name(s)
            //FROM table_name
            //WHERE condition;

            // MySQL Syntax:
            //SELECT column_name(s)
            //FROM table_name
            //WHERE condition
            //LIMIT number;

            //Oracle 12 Syntax:
            // SELECT column_name(s)
            //FROM table_name
            //ORDER BY column_name(s)
            //FETCH FIRST number ROWS ONLY;


            //MIN() and MAX() Functions
            //The MIN() function returns the smallest value of the selected column.
            //The MAX() function returns the largest value of the selected column.
            //MIN() Syntax
            //SELECT MIN(column_name)
            //FROM table_name
            //WHERE condition;

            //MAX() Syntax
            //SELECT MAX(column_name)
            //FROM table_name
            //WHERE condition;

            //COUNT(), AVG() and SUM() Functions
            //The COUNT() function returns the number of rows that matches a specified criterion.
            //SELECT COUNT(column_name)
            //FROM table_name
            //WHERE condition;

            //The AVG() function returns the average value of a numeric column.
            //SELECT AVG(column_name)
            //FROM table_name
            //WHERE condition;

            //The SUM() function returns the total sum of a numeric column.
            //SELECT SUM(column_name)
            //FROM table_name
            //WHERE condition;








        }
    }
}
