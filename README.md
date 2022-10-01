# VenderOrder Tracker

#### By Skylan Lew

#### Independent Project 8 for Epicodus

## Technologies Used

- C#
- .NET 5
- ASP.NET Core MVC
- Javascript
- HTML

## Description

This web application allows the user to keep a list of vendors, as well as a list of orders for each vendor. The web app is themed around [Pierre's Bakery](https://github.com/doublespoiler/pierres-bakery).

Along the top navbar, the user can log out (go to the splash screen), or go back to the all vendors list.

Upon opening the splash page, the user can click the button to enter the app. They will be greeted by an empty list of Vendors, prompting them to add a vendor. Upon filling out the form, they are redirected to the vendor list, where they can add another vendor, or look at a vendor's details.

When they click on a vendor's details, they are prompted to add an order for the vendor. Upon submitting the form, they are taken back to the vendor's list of orders, and can choose to view an order's details, or go back to the vendor page.

The application will continue to store all lists until the server is turned off.

## Setup/Installation Requirements

### Requires

- [.NET 5](https://dotnet.microsoft.com/en-us/download/dotnet/5.0) - <https://dotnet.microsoft.com/en-us/download/dotnet/5.0>

### Download/Run Instructions (git)

- clone: `$ git clone https://github.com/doublespoiler/vendor-order.git` or Code>Download ZIP
- navigate to project folder: `$ cd VendorOrder.Solution/VendorOrder`
- restore: `$ dotnet restore`
- build: `$ dotnet build`
- run: `$ dotnet run`

### Test Instructions (git)

- clone: `$ git clone https://github.com/doublespoiler/vendor-order.git` or Code>Download ZIP
- navigate to test folder: `$ cd VendorOrder.Solution/VendorOrder.Tests`
- test: `$ dotnet test`

## Known Bugs

- Randomized images doesn't work on `Order New` and `Order Show` routes

## License

[MIT](https://choosealicense.com/licenses/mit/)
`[MIT](https://choosealicense.com/licenses/mit/)`

Copyright (c) 2022 Skylan Lew
