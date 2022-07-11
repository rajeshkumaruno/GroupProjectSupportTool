# GroupProjectSupportTool

Project Work completed-

We implemented the three Layers as per our Architecture diagram
DB script andtable has been created
Project Add and update functionality has been created
The template of BAL and DAL are also ready
Majority of DAL layer library for database object has been created




Detaisl of UI/DAL/BAL layer
The Presentation Layer or the "UI Front End" of the Group Project Support Tool application will provide a way for a project team member to interact with the application. The idea is to give an "intuitive" interface that is easy to navigate and work with. Currently, the project's scope does not include mobile or multi-touch screens and other devices, but the UI presentation layer can grow based on expansion possibilities in other devices.

The Business Logic Layer will ensure that business rules and workflow are expanded into separate components that provide specialized functionality. For example, a Business  Layer will provide the services to manipulate the Project Calendar logic to the "clients" of the system, thereby hiding the logic from the clients

A data access layer (DAL)  will provide simplified access to data stored in MS SQL Server. When called from BLL, the DAL will return a reference to an object, complete with its attributes. Therefore, if required, this  Client-Server application can smoothly migrate from one database to another.




How to run the  project-

Once you download the code, please open the GroupProjectWeb.sln file using Visual Studio
Navigate to the GroupProjectWeb folder
Run the Index.aspx file


