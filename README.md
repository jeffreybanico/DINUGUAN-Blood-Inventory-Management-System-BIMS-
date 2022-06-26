# DINUGUAN: Blood Inventory Management System (BIMS)
DINUGUAN Blood Inventory Management System is a system that facilitates hospital blood inventory transactions including registration of eligible donors, monitoring of blood stocks inventory, verification of blood requests, and safekeeping of blood donation information. This system is inclined towards digitizing and streamlining the workflow of blood inventories. The information system includes two user types: admin and nurse.

## Basic Features
***1. Login and Registration <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/login.png" alt="Login Page">
</p>

***2. Password Recovery <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/password%20recovery.png" alt="Password Recovery Page">
</p>

***3. Adding, Editing/Updating, Deleting, Searching & Filtering of Information***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/Screenshot%20(113).png" alt="Adding, Editing/Updating, Deleting, Searching & Filtering of Information">
</p>

***4. Reports Generation <br>***
<p align="center">
  <img width="700" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/report%20gen%201.png" alt="Report Gen 1">
</p>
<p align="center">
  <img width="700" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/report%20gen%202.png" alt="Report Gen 2">
</p>
<p align="center">
  <img width="700" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/report%20gen%203.png" alt="Report Gen 3">
</p>
<p align="center">
  <img width="700" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/report%20gen%205.png" alt="Report Gen 4">
</p>

***5. Database Backup and Restoration <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/backup.png" alt="Backup">
</p>
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/restore.png" alt="Restore">
</p>

***6. User Transaction Logs <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/logs.png" alt="User Logs">
</p>

## Functions (Main Transactions)
***1. Donor Registration <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/Donor.png" alt="Donor Registration">
</p>

***2. Blood Inventory Management <br>***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/inventory.png" alt="Blood Inventory Management">
</p>

***3. Request Management***
<p align="center">
  <img width="950" src="https://github.com/jeffreybanico/DINUGUAN-Blood-Inventory-Management-System-BIMS-/blob/main/img/Request.png" alt="Request Management">
</p>

## To use
1. Install and set up Visual Studio 2019 or newer version
2. Install and set up MySQL Server
3. Downlaod the blood_ forlder
4. Go to MySQL and Import the Database named **blood_msdb.sql**
5. After importing the database open Visual Studio 2019 and navigate to the folder blood_ (note: before opening the folder blood_ reassure you extracted it first)
6. Go to the **blood_msdb.vb** and change the username and password of the database. (note: insert the password and username of your db where you import the database blood_msdb.sql)
7. Following this go to the **AdminRequest.vb** and look for C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\templates\ and C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\requestlist\ change this to the path of your device where the templates of the report to be generated and the storage located
8. Furthermore, go to the  **AdminDonorList.vb** and look for C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\templates\ and C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\donorlist\ also change this to the path of your device where the templates of the report to be generated and the storage located
9. Another, go to the  **AdminBloodInventory.vb** and look for C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\templates\ and C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\bloodinventory\ also change this to the path of your device where the templates of the report to be generated and the storage located
10. Lastly, try to build the program it self by clicking the green play button above
11. Have a nice try 😁

## To Access
***Admin***<br>
username: jeff<br>
password: earth

***Nurse***<br>
username: vladdy<br>
password: vladdy
