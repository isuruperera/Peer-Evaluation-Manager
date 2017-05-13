==== How to Run ====

1. Install the program 'mysql-installer-web-community-5.7.18.1' first
2. When asked, give the username as 'root' and the password as 'root' (without 'quotes')
3. After mySql is done installing, Do the following steps
****Note: mySql will download 300+ MB data for installation***
4. Open Command Prompt
5. Run command path=C:/**MySql Install Location**/bin
6. Run Command, mysql -h localhost -u root -p
7. Give the password as root **<= Your MySql Password**
8. Now mySql may show a welcome message and command prompt changes to => mysql>
9. type show databases;
10. Make sure you do not have peer_evaluation_manager
11. If peer_evaluation_manager is in the database list, type drop peer_evaluation_manager; and enter
12. copy following code and paste it in the command prompt and hit enter.

CREATE DATABASE peer_evaluation_manager;
CREATE TABLE `peer_evaluation_manager`.`peer_data` (
  `Date` VARCHAR(25) NOT NULL,
  `Index_Number` VARCHAR(45) NULL,
  `Name` VARCHAR(200) NULL,
  `Subject` VARCHAR(100) NULL,
  `Lesson` VARCHAR(200) NULL,
  `Status` VARCHAR(45) NULL);

13. Run the application in the Run This folder.
14. Enjoy