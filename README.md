#### _DATE: 6-9-17_

#### By _**John Dowd**_

## Description

This program gives the user the opportunity to add a list of stylists, and for each stylist, add clients who see the stylist. The stylists work independently, so each client only belongs to a single stylist. The program user can update the info for each stylist and client.


## Specifications
|Behavior| User Input| Output |
|---|---|---|
|Program will create and return stylist. |"Jody Johnson"| "Jody Johnson"|
|Program will return all stylists. | [List Stylists Button] | "Names of all stylists"|
|Program will delete stylist. |"Jody Johnson"| " "|
|Program will create a client under stylist. |"Frank Jones"| "Frank Jones "|
|Program will delete client. |"Frank Jones"| " "|
|Program will return edited client info. |"Jim Jones"| "Jim Jones"|
|Program will return edited stylist info. |"John Jones"| "Jim Jones"|

### Link
https://github.com/irishdowd10/HairSalonApp.git

## Setup

* Clone the project files from link in your powershell > run dnu restore >and then run dnu kestrel > then type localhost:5004


* In SQLCMD: > CREATE DATABASE hair_salon; > GO > USE hair_salon; > GO > CREATE TABLE stylists (id INT IDENTITY(1,1), name VARCHAR(255)); > CREATE TABLE clients (id INT IDENTITY(1,1), name VARCHAR(255), stylist_id int); > GO



## Known Bugs
None that I know of.

## Support and contact details

_John Dowd - john.dowd@inspectall.com_

## Technologies Used

_HTML Bootstrap, Nancy, Razor, C#, xUnit, SQL, MMSS_

### License

*Open source applies to all. Use at your own risk*

### Notes

Copyright (c) 2017 **_John Dowd - Epicodus_**
