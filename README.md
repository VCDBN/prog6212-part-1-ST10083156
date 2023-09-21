##Time Management Application##

The reason i have created this application is to aid college students with the management of their study time. It will prompt them for their module and semester details, and then provide them with a recommended weekly amount self-study hours in order to do well in the given modules.

##App Funciontality##

This application is coded in the C# programming language on the Visual Studio IDE. The application is a WPF appication and makes use of OOP. The main window acts as a greeting to the user, which then transfers the user to the first page requiring input. It will prompt the user for all the details about each module they will be studying and it will store all those modules in a static Modules list in the Module class. The done button being clicked will then transfer the user to the semester window which will prompt for information about the semester which will be used to calculate the numberof self-study hours recommended for each module. This will be stored in an IDicitionary along with the names of each module. These modules will be stored in Week objects and those Week objects in-turn will be stored in the static list Weeks. Once those details have been recorded, the user click on the button will transfer them to the next window which wil just display the remaining hours of self-study recommended for each week in a datagrid and ifthe user wishes to update hours in any given week, they may click the update button and it will transfer them to the update hours window where they can enter the details about which week, which module and how many hours they studied. This window will update the IDictionary and return them to the display window once they click the button and this loop will repeat.

##Application running

 In order to run it, one must first download Visual Studio and pull the application code into their IDE and click on the green run button located in the tools bar above the open window. Once clicked, the user will just need to follow the prompts on the screen and enter the details in order to calculate their recommended self-study hours. 
