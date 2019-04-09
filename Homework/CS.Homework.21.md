## Kindra Bilodeau
#### C# Homework 21

1. **What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different
query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?**
  - sql is high level where linq can do more in c#
  - sql is how you access the database.
  - linq deals with data in memory
2. **What is the one essential requirement for the data structures used with LNQ? Why is this requirement
important?**
  - All data must be stored in a data structure and must be enumerable.
  - It's needed to iterate through the data
3. **Were does the LINQ Select() method live?**
  - System.Linq namespace
4. **(Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);**
  - the select method is called on the customers array and returns the FirstName property from cust object and is assigned to the IEnumerable type string name customerFirstNames
5. **(Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr =>
    String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);**
  -names of companies that  the addresses where the country equals United States.
  - addr is an alias
6. **(OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr =>
    addr.CompanyName).Select(comp => comp.CompanyName);**
  - Select the companyname and orders them by company name
7. **(Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);**
  - It will group the addresses by Country
8. **(Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();**
  - Distinct will eliminate duplicates
  - It will select Count the number of distinct countries
9. **(Join) Explain, token by token, each token in this line of code:
var companiesAndCustomers =
customers.Select(c =>
new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>
custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>
new {custs.FirstName, custs.LastName, addrs.Country });**
  - it joins the customer and the address arrays
  - it selects the firstname, lastname and company name from customers. joined on company name then gets the
10. **Explain the difference between a deferred collection and a static, cached collection.**
  - a static, cached collection is a copy of the original data and does not change.
  - deferred evaluation if you modify the data before it iterates through a collection
