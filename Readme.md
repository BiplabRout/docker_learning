Student API Application using .NET CORE 6.0 and Docker 
-------------------------------------------------------

1. Install docker in Linux Instance (CentOS)</br>
sudo yum install -y yum-utils</br>
sudo yum-config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo</br>
sudo yum install docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin</br>
</br>
2. Start the docker deamon</br>
sudo systemctl start docker</br>
sudo systemctl status docker</br>
</br>
3. Install Docker compose in Linux Instance (CentOS)</br>
sudo curl -L "https://github.com/docker/compose/releases/download/v2.18.1/docker-compose-linux-x86_64" -o /usr/local/bin/docker-compose</br>
sudo chmod +x /usr/local/bin/docker-compose</br>
</br>
4. Build the Student API Application docker image</br>
go to users home directory and create a folder names as "sqldata"</br>
Go to Dockerfile location and run below command</br>
docker build -t student-api .</br>

5. Build the Docker Container using docker-compose (both Student API application and Postgres SQL)</br>
docker-compose --profile development up</br>
</br>
6. Log to Postgres SQL and run the following SQL Queries :</br>
CREATE DATABASE studentdb</br>
CREATE TABLE MbaStudentDetails (</br>
    MbaStdName VARCHAR(255),</br>
   MbaStdGrade VARCHAR(255),</br>
    MbaStdMark INT</br>
);</br>
</br>
</br>
INSERT INTO MbaStudentDetails VALUES ('Rohit','MA',70);</br>
INSERT INTO MbaStudentDetails VALUES ('Rinku','MB',85);</br>
INSERT INTO MbaStudentDetails VALUES ('Tapas','MC',90);</br>
INSERT INTO MbaStudentDetails VALUES ('Deepak','MD',95);</br>
INSERT INTO MbaStudentDetails VALUES ('Raju','ME',97);</br>
</br>
SELECT * FROM MbaStudentDetails</br>
</br>
</br>
CREATE TABLE StudentDetails (</br>
    StdName VARCHAR(255),</br>
   StdGrade VARCHAR(255),</br>
    StdMark INT</br>
);</br>
</br>
</br>
INSERT INTO StudentDetails VALUES ('Biplab','A',70);</br>
INSERT INTO StudentDetails VALUES ('Happy','B',85);</br>
INSERT INTO StudentDetails VALUES ('Siba','C',90);</br>
INSERT INTO StudentDetails VALUES ('Rahul','MD',95);</br>
INSERT INTO StudentDetails VALUES ('Biswa','E',97);</br>
</br>
SELECT * FROM StudentDetails</br>
</br>
7. Student API application is exposed to port 8000 and Postgres SQL to port 5432</br>




