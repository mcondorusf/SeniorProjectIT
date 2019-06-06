<a target="_blank" href="https://www.usf.edu/it"><img align="right" src="https://cdn.usf.edu/_resources/images/v3/global/png/logo-classic-stacked.png"></a>
# USF IT Senior Project

### Motivation 
This project was created as an assignment for the University of South Florida Senior IT Project (CIS4935) during the Summer 2019 term. This is a web application which provides users with specific flood data based on input of a location with the intention of informing the user of the Base Flood Elevation (BFE) and providing a recommendation for the minimum  build elevation of a structure's first floor at this location. The application makes use of flood data API and a Geographical Information System (GIS) to find and present flood data and layers within a navigational map interface.  

This is an open source application. While there are applications that offer similar functionality, this software intends to extend and marry the functionality of multiple sources, and offer feedback not present in other tools. 

### Scope
The application is intended to be used as a reference by those who wish to evaluate their preparedness under a variety of flood conditions. The data provided may then be used to better understand the risks associated with a particular location as well as inform potential steps that may be taken to reduce risk. Providing a clearer understanding of flooding scenarios, their risks, and mitigations has both public safety, as well as insurance implications.

The application will also provide useful information about flooding in the Tampa Bay area (and beyond) to individuals who wish to understand, in greater detail, the pattern of flooding and how it affects the region as a whole. This could be advantageous not only to consumers of flood insurance, but also to underwriters, appraisers, and other professionals who maintain structures at flood sites and assess the risk of floods to geographic locations. 

### Framework and Languages
ASP .Net Core Platform:  This web application is built on the ASP .Net Core web application platform.  For development the application requires a development environment that is able to run ASP .Net Core web applications. The application follows the MVC (Model, View, Controller) application programming paradigm. The application makes use of JavaScript, JQuery, Bootstrap, and other client-side technologies

ArcGIS: ArcGIS is a maps plugin for the web application. ArcGIS provides a map with search functionality that allows a user to click the map and ascertain the location and details about that location. ArcGIS also provides a layering tool to developers to allow development of custom layers for the map based on input data. This application makes use of the JavaScript API for ArcGIS, and any breaking changes to the API may cause issues in development. 

National Flood Data API:  The National Flood Data API is used by this application. The application queries against this API to get data for specific locations and the Tampa Bay region as a whole. The license key for this application expires after the due date of this project at the end of July 2019. Any developer trying to use the application after that time will not be able to get data without further contacting National Flood Data regarding the API key. 

### Operating Environment
This web application is intended for use with all modern desktop browsers. Although it can be accessed from any device capable of web browsing, support is not currently guaranteed for mobile device screen sizes or interactions.

### Integrations, API, and Database Resources
- <a href="https://developers.arcgis.com/" target="_blank">ArcGIS</a> - GIS, Maps, Layers
- <a href="https://www.fema.gov/flood-insurance-rate-map-firm" target="_blank">FEMA</a> - Flood Insurance Data
- <a href="http://nationalflooddata.com/flood/floodapi/" target="_blank">National Flood Data</a> - Flood Data API

### Screenshots
<img width="800" height="400" src="https://github.com/mcondorusf/SeniorProjectIT/blob/master/usf_flood_data.PNG?raw=true">



### Project Contributors
**Team Flood Fighters**
- Matthew Condor
- Michael Lee
- Michael Joseph
- Sean King
- Hassan Baraka
