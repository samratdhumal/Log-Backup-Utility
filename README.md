# Log-Backup-Utility

## Problem Statement: 
To record all activities of Warship through log events to detect problems, provide secure access to the system and apply clustering algorithm to collected logs.


## Objectives:
1.	To retrieve different event data logs.
2.	To store and sort those logs using clustering techniques.
3.	To prepare scheduled backup on daily/weekly/monthly basis.
4.	To provide secure and easy access to the required logs.
5.	To avoid unnecessary planning of activity.


## Significance of the Project:
Previously, all the activities occurring were not recorded. These activities needed analysis to stop the repetition of those errors. Thus all the problems occurring then were not solved. After implementation of this project all the activities are recorded and thus track of all the problems is stored. Hence during the next voyage all the precautions will be taken and previous mistakes won’t be repeated.

## Results:
1.	Secure Authentication
      The Authorized users are allowed to log in into the system as they have a valid and authenticated permission from organization.

2.	Static Log creation
       Our system contains a form which accepts type of logs, time and date of logs and brief description about logs.

3.	Dynamic Log creation
        Dynamic logs are retrieved through FTP from different clients to the server. 

4.	Log backup
        To take log backup we allow users to select source folder which contains log data and transfer that data to the destination folder.

5.	K-Means Clustering
        K-Means clustering algorithm is used to cluster the retrieved logs and this clustered report is saved in a text file.

## Conclusion & Future work:
This project helps in collecting different logs from the clients/sensors, which are retrieved and clustered by using data mining technique. This helps admin to use previous information to improve the tactics and warfare techniques. It also helps in data analysis of the frequently occurring logs. The security is maintained by the system as it is accessed only by the authorized person i.e. admin. Thus, overall it provides secure, reliable and helpful software for storing, retaining the logs. 
