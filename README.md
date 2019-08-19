# Pierre's Market

#### _An application that let's an admin and clients explore Pierre's baked products. . - 08/16/2019_

#### _By **Uriel Gonzalez**_

## Description

This MVC Web application uses a local database and user authentication to view and manage a bakery business inventory.

All users can:
1. Create an account and log in

Only logged in users can:
1. See a Treat Menu.
2. See a Flavor Menu.
3. Navigate through menu and account pages.
4. Add treats and flavors to the inventory/menu.
5. Delete specific treats and flavors.
6. Edit specific treats and flavors.

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/Ugonz86/Pierres_Market_SS.git
    ```
2. Open the App Settings file (Pierres_Market_SS/Market/appsettings.json) and ensure that the MySQL username and password match your MySQL credentials.

3. Log onto MySQL:
    ```
    $ mysql -u root -p epicodus
    ```
4. Create the following tables:
    ```
    Flavors > FlavorId Int() PK, NN,AI + Description LONGTEXT
    Treats > TreatId INT() PK, NN, AI + Name LONGTEXT
    FlavorTreat > TreatFlavorId INT() PK, NN, AI + FlavorID INT() + TreatId()
    ```
5. Run:
    ```$dotnet Run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET Core
* ASP.NET Core MVC
* Entity Framework Core
* LINQ
* MySQL

## Support and contact details

_Please contact Uriel Gonzalez with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Uriel Gonzalez_**
