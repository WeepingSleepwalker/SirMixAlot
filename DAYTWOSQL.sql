SELECT * 
FROM Customer
Where County = 'Brazil';

SELECT COUNT(*)
FROM Customer;

SELECT *
From CustomerId
WHERE CustomerId = 10;

SELECT SUM(Total)
FROM Invoice;

SELECT CustomerId, SUM(Total)
FROM Invoice
GROUP BY CustomerId; --GROUP BY gives us a way to of an agregate by entries.

SELECT *
FROM Invoice;

SELECT CustomerId, SUM(Total) AS Sum_Total
From Invoice
GROUP BY CustomerId
HAVING SUM(Total) > 40
ORDER BY Sum_Total DESC, CustomerId;

SELECT Address FROM Customer;

SELECT * FROM Customer WHERE Country = 'Brazil';

-- List all customers (full name, customer id, and country) who are not in the USA

SELECT FirstName + ' ' + LastName AS FullName, CustomerId, Country FROM Customer WHERE Not Country = 'USA';


-- List all sales agents

SELECT * FROM Employee WHERE Title = 'Sales Support Agent';

-- Retrieve a list of all countries in billing addresses on invoices

SELECT Distinct BillingCountry FROM Invoice;

-- Retrieve how many invoices there were in 2009, and what was the sales total for that year?
    -- (challenge: find the invoice count sales total for every year using one query)

SELECT BillingCountry, COUNT(BillingCountry) FROM Invoice GROUP BY BillingCountry;


-- how many line items were there for invoice #37

SELECT Count(*) FROM InvoiceLine WHERE InvoiceID = 37;



-- how many invoices per country?



-- Retrieve the total sales per country, ordered by the highest total sales first.

SELECT CustomerId, SUM(Total) AS Sum_Total
FROM Invoice
WHERE BillingCountry != 'USA'
GROUP BY CustomerId
HAVING SUM(Total) > 40
ORDER BY Sum_Total DESC, CustomerId;

-- Logical order of operations is:
-- FROM
-- WHERE
-- GROUP BY
-- HAVING
-- SELECT
-- ORDER BY

--joins

SELECT *
FROM Employee AS e1 CROSS JOIN Employee AS e2
WHERE e1.EmployeeID != e2.EmployeeID;

--Cross Join
--Inner Join
--Left Join
--Right Join
--Outter


-- every album by artist

SELECT Album.Title AS [Album Title], Artist.Name AS[Artist Name]
FROM Album INNER JOIN Artist ON Album.ArtistID = Artist.ArtistID;

SELECT al.Title, ar.Name
FROM Album AS al INNER JOIN Artist As ar on al.ArtistID = ar.ArtistID;

--all rock songs, showing the name in the format "Artist-Name - Song-Name"
--genre has genre name and genre ID
--track has track name, genre id.
--album has ablem id and artist id 
--artist has name artist ID



SELECT Artist.Name + ' - ' + Track.Name AS [Artist - Song]
FROM Track 
    INNER JOIN Genre ON Genre.GenreID = Track.GenreID
    JOIN Album ON Track.AlbumId = Album.AlbumId
    JOIN Artist ON Album.ArtistID = Artist.ArtistID
    where Genre.Name = 'Rock';


select *
FROM 
Album;

-- JOINS CHALLENGES
-- Show all invoices of customers from brazil (mailing address not billing)
SELECT Invoice.* 
FROM Invoice
    INNER JOIN Customer ON Customer.CustomerId = Invoice.CustomerId
     WHERE Customer.Country = 'Brazil';

SELECT COUNT(InvoiceId) AS TotalInvoices, Sum(Total) AS TotalSales 
FROM Invoice 
WHERE InvoiceDate LIKE '%2009%';

-- Show all invoices together with the name of the sales agent for each one

SELECT * FROM Invoice
 INNER JOIN Customer ON Customer.CustomerId = Invoice.CustomerId
  JOIN Employee ON Employee.EmployeeId = Customer.SupportRepId;

-- Show all playlists ordered by the total number of tracks they have
SELECT Count(PlaylistTrack.PlaylistID) FROM PlaylistTrack JOIN ;

-- Which sales agent made the most sales in 2009?


-- How many customers are assigned to each sales agent?


-- Which track was purchased the most ing 20010?


-- Show the top three best selling artists.


-- Which customers have the same initials as at least one other customer?