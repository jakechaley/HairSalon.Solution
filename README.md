# Eau Claire's Salon

#### By Jake Haley

#### Application to help Claire organize her Clients and Stylists

## Technologies Used

* C# 
* .NET
* Microsoft Entity Framework
* Razor
* ASP.NET MVC
* MySql WorkBench

## Description

This project helps practice creating and using a database in an MVC app. User is able to add stylists and then within those stylists the user can store clients belonging to said stylist.

## Setup/Installation Requirements

* To use this application you have to have MySql Workbench installed. Follow setup instructions [here!](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
* Clone this repository onto your local machine. 
* In Workbench, click the Administration tab, then select Data Import/Restore
* In Data Import window, select Import from self-contained file, and using the file browser option, navigate to this project's root directory and select jake_haley.sql.
* After selecting this, select New in the Default Schema to be imported to. Name the schema "hair_salon"
* Select the Import Progress tab and click Start Import
* In the project's root directory, you will next need to create an appsettings.json file with the following information where YOURPASSWORDHERE is the password used to connect to MySQL: { "ConnectionStrings":{ "DefaultConnection":"Server=localhost;Port=3306;database=hair_salon;uid=root; pwd=[YOURPASSWORDHERE];" } }
* Save this. Once saved move to HairSalon directory by typing `cd HairSalon` into the command line. 
* Install project dependendencies by typing `dotnet restore` into the command line.
* While in HairSalon directory, type `dotnet run` into the command line to run program.

## Known Bugs

* No known issues
* Please let me know if any are found!

## License

ISC License

Copyright (c) [2022] [Jake C. Haley]

_Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies._

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH
REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY
AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT,
INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM
LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR
OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR
PERFORMANCE OF THIS SOFTWARE.


