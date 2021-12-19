## How to install application
- Install Visual Studio Community 2022 version 17.0.4
- Install MS SQL sever 2019
- Clone git to your computer
## How to use
- Change the SQLconnection (in DataProvider.cs file) which is suitable with your SQLSever
- Run the application in Visual Studio
- Open SQL sever and insert 1 account leader in database
- Add 1 account for Member and 1 account for Mentor
## Note 
- Only Leader can add, delete Member, Mentor, and Leader
- Only Leader can deliver tasks for member
- Mentor do not have task function
- Only Leader can add information of activity and its finance
- When adding new Member/Mentor/Leader, the system will automatically create new account for that object
- When deleting a Member/Mentor/Leader, the system will automatically delete the account of that object
- We can change the password of account only when user enter new_password = re-enter_new_password
- When Member submit his/her task, he/she can not see the submited task. Only Leader could see that
