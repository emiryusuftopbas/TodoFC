# TodoFC
TodoFC , to do list from console. This is simple command line todo list app.
We developers like to work from command line that is why i wrote this application.

## How to add 
You need to download the exe , or you can build the exe from the source code.

 - Create a folder
 - Move executable program into created folder

 ![System Properties](https://user-images.githubusercontent.com/58172827/76757530-ca016380-6798-11ea-8113-eb44640c97d4.png)

 - Click on  *Environment Variables*

 ![Environment variables](https://user-images.githubusercontent.com/58172827/76757607-e7cec880-6798-11ea-97e9-ff8268620d9f.png)

 - Double click on *Path*

 ![Edit environment variable](https://user-images.githubusercontent.com/58172827/76757660-05039700-6799-11ea-924a-a556139dae77.png)
 
 - Click on new and add write the path of the folder.
 - Click ok.
 - Now you are ready to use TodoFC from console.

## How to create a to do
Open cmd and type 

	TodoFC add

 After you typed the command ,program will wait input from you.

 ![TodoFC add](https://user-images.githubusercontent.com/58172827/76757708-295f7380-6799-11ea-913b-6a06c14ae697.png)

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

![todofc mark-as-completed](https://user-images.githubusercontent.com/58172827/76757758-45fbab80-6799-11ea-8b99-4f7ca6ad0edd.png)
   
   **Marking as uncompleted**

	TodoFC mark-as-uncompleted <id>

![todofc mark-as-uncompleted](https://user-images.githubusercontent.com/58172827/76757828-6fb4d280-6799-11ea-9c35-94220b7f0897.png)

## How to delete a to do

	TodoFC del <id>

Before delete:

![Todo List](https://user-images.githubusercontent.com/58172827/76757926-a985d900-6799-11ea-955c-dab176d8c693.png)

After delete:

![todo List](https://user-images.githubusercontent.com/58172827/76757952-ba364f00-6799-11ea-962c-0a7f58de9dee.png)

 

## Contributors

 - Emir Yusuf Topbaş <emiryusuftopbas@gmail.com>
## License & copyright
Licensed under the [GNU General Public License v3.0](LICENSE)



