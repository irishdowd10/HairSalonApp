#### _DATE: 6-9-17_

#### By _**John Dowd**_

## Description

This program gives the user the opportunity to add a list of stylists, and for each stylist, add clients who see the stylist. The stylists work independently, so each client only belongs to a single stylist.


## Specifications
|Behavior| User Input String| User Input Word| Output |
|---|---|---|---|
|Program will display stylist name . |"Jody Johnson"| "Jody Johnson"| 1 |


### Link


## Setup

* In SQLCMD: > CREATE DATABASE hair_salon; > GO > USE todo; > GO > CREATE TABLE stylists (id INT IDENTITY(1,1), name VARCHAR(255)); > CREATE TABLE clients (id INT IDENTITY(1,1), name VARCHAR(255), stylist_id int); > GO


## Known Bugs
.

## Support and contact details

_John Dowd - john.dowd@inspectall.com_

## Technologies Used

_HTML Bootstrap, Nancy, Razor, C#, xUnit, SQL, MMSS_

### License

*Open source applies to all. Use at your own risk*

### Notes

Copyright (c) 2017 **_John Dowd - Epicodus_**
