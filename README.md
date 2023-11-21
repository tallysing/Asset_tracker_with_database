# Asset tracking with database

A console application for asset tracking of company assets with features like currency conversion.

## Setup 

Follow the instructions below to get the application running locally.

### Installations
- Visual Studio Community Edition (latest)
- MS SQL Server 2022 Developer Edition
 -  Download and install the Developer edition from here
  - Make sure you get SQL Server Management Studio too
  
  ### Clone & Build
  
To open the solution in Visual Studio, clone the repository from this page.

### Usage

When you first open the application, you will be met by a blue instruction text. It contains different options for how you can procced. You can now navigate between registering, moving office location, deleting and viewing your company's assets. The information you need to register is the asset's type, brand name, model, purchase date, and price. To move the office location of an asset, you must enter the model name of the asset and the new office location to which you want to move the asset, while to delete an asset, you only need to enter the model name. When you want to view the assets the application will display it in a table sorted after type first then purchase date. Rows highlighted red imply that the assets are (within three months) approaching three years old or older. Yellow rows imply the assets are approaching three years old whitin six months. Each time you view the assets the application will automatically update the assets' age based on their purchase date. The assets' purchase prices are automatically converted to the local currency of the offices' locations.
