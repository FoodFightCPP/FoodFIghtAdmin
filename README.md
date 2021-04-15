# FoodFightAdmin

This is the repo for the Food Fight administrative web application.

## Deployment

The app is deployed to Microsoft Azure through a workflow from this repo. The developing environment is ASP.NET Core with Entity Framework.
The database is a SQL relational database deployed to Azure.
The mobile App and Web App pull from the same database.

## Website

To reach the site click [here](admin.foodfight.live)

## Access

You must first have an administrative account to access the data in the site.
Once administrative account is aquired, here are some navigational tips.

1. The Landing page has a welcome message and a big FoodFight logo with a navigation dashboard on the bottom.
2. Clicking the logo will take you to the administrative dashboard where you will get counts of the number of items in certain tables as well as links to admin profile information.
3. Clicking the links in the navigation dashboard (that follows to each page) will take you to their respected table views.
4. To log out, click either the logout link in the top right, or from the administrative dashboard, click the logout button and click the log out link on the following page.

## Future releases

The site is currently a working work in progress future releases will include:

- Ablity to suspend user accounts.
- More detailed relationship tables with viewmodels and views.
- Improved details layouts for users and restaurants.
- Customizeable data viewers in the Administrative Dashboard.
- Messaging system to communicate with other administrators through the site.
- Help ticket generator to report issues.
- More views for other tables.
- Many more features to come...
