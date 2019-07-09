# MicrosoftReady19_ServerlessWorkshop

 ---------------Azure function --------------------

1. Azure portal -> Creating Resource Group (In west US)
2. Go to Marketplace -> create resource -> azure CosmosDB 
3. Create new solution in VS, add a project -> azure function
4. Choose trigger as -> CosmosDB trigger, V2 .net core
5. Add connection settings from the portal of the CosmosDB resource
6. Add a file -> local.settings.json -> add connection strings setting
7. Cross check the configs of the function in vs
8. Add lease setting – CreateLeaseCollectionIfNotExists = true in the function defintion
9. Create a Database and Collection in the CosmosDB created in Step 2.
10. Add an item in collection, you can refer the git solution for sample jsons
11. Debug azure function, add appropriate breakpoints
12. Add a new item in CosmosDB
13. Breakpoint hits – verify the added item
14. 

-------------- Publishing azure function--------------------------
1. Go to Azure marketplace and Create a function app
2. Get the publish profile of the function app from azure portal
3. In visual studio, right click on the Azure function project and publish the function app
4. Add cosmos db connection string in app setting 
5. Alternatively Import Profile and then publish


------------------ Event grid-------------------
1. In portal, create Event grid topic of Event grid schema type
2. Create an event subscription 
3. Create a storage account, create a queue in it
4. Go back to event grid subscription, add the queue as the endpoint
5. Add code for sending out events to event grid
6. Add event grid configurations to function
7. Debug and test azure function- event should reflect in event grid

----------- Logic app------------
1. Go to marketplace and Create blank logic app
2. Select trigger- Event grid – when a resource event occurs
3. Configure trigger with subscription, Resource type – event grid topics, Resource name, event type items
4. Add action- switch control
5. Switch on – Event type
6. On any one Event Type - add further actions
7. Add action to read from a blob
8. Add dynamic content to action and hit save
9. Test the logic app - By changing cosmos item -> check event grid -> check logic app run history, view the latest run












