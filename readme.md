# TodoFC
TodoFC , to do list from console. This is simple command line todo list app.
We developers like to work from command line that is why i wrote this application.

## How to add 
You need to download the exe , or you can build the exe from the source code.

 - Create a folder
 - Move executable program into created folder
 ![System Properties](https://i.ibb.co/9vQjr10/Annotation-2019-11-27-205018.png)
 - Click on  *Environment Variables*
 ![Environment variables](https://i.ibb.co/mcL2PyS/Annotation-2019-11-27-205018.png)
 - Double click on *Path*
 ![Edit environment variable](https://i.ibb.co/1Rd4BSs/Annotation-2019-11-27-205018.png)
 - Click on new and add write the path of the folder.
 - Click ok.
 - Now you are ready to use TodoFC from console.

## How to create a to do
Open cmd and type 

	TodoFC add

 After you typed the command ,program will wait input from you.
 ![TodoFC add](https://i.ibb.co/0YvrtZw/Capture.png)
 ## How to show to do list
 Open cmd and type TodoFC
 
	TodoFC
   This will show uncompleted to do list.
   
**Showing completed todo list**

    TodoFC show-completed
**Showing all todo list**
	

    TodoFC show-all
## Marking as completed and uncompleted
    TodoFC mark-as-completed <id>
    
   You have to type todo id , for example
   

    TodoFC mark-as-completed 2
![enter image description here](https://i.ibb.co/L8D1Qvw/Capture.png)
   
   **Marking as uncompleted**

	TodoFC mark-as-uncompleted <id>

![enter image description here](https://i.ibb.co/JKhBHwc/Capture.png)
## How to delete a to do

	TodoFC del <id>

Before delete:
![Todo List](https://i.ibb.co/XtXBN63/todolist.png)
After delete:

![todo list](https://i.ibb.co/0fJ0Nwt/asd.png)

 

## Contributors

 - Emir Yusuf Topbaş <emiryusuftopbas@gmail.com>
## License & copyright
Licensed under the [GNU General Public License v3.0](LICENSE)



