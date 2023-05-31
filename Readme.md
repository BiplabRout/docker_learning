Student API Application using .NET CORE 6.0 and Docker 
-------------------------------------------------------

1. Install docker in Linux Instance (CentOS)
sudo yum install -y yum-utils
sudo yum-config-manager --add-repo https://download.docker.com/linux/centos/docker-ce.repo
sudo yum install docker-ce docker-ce-cli containerd.io docker-buildx-plugin docker-compose-plugin

2. Start the docker deamon
sudo systemctl start docker
sudo systemctl status docker

3. Install Docker compose in Linux Instance (CentOS)
sudo curl -L "https://github.com/docker/compose/releases/download/v2.18.1/docker-compose-linux-x86_64" -o /usr/local/bin/docker-compose
sudo chmod +x /usr/local/bin/docker-compose

4. Build the Student API Application docker image
go to users home directory and create a folder names as "sqldata"
Go to Dockerfile location and run below command
docker build -t student-api .

5. Build the Docker Container using docker-compose (both Student API application and Postgres SQL)
docker-compose --profile development up

6. Log to Postgres SQL and run the following SQL Queries :
CREATE DATABASE studentdb
CREATE TABLE MbaStudentDetails (
    MbaStdName VARCHAR(255),
   MbaStdGrade VARCHAR(255),
    MbaStdMark INT
);


INSERT INTO MbaStudentDetails VALUES ('Rohit','MA',70);
INSERT INTO MbaStudentDetails VALUES ('Rinku','MB',85);
INSERT INTO MbaStudentDetails VALUES ('Tapas','MC',90);
INSERT INTO MbaStudentDetails VALUES ('Deepak','MD',95);
INSERT INTO MbaStudentDetails VALUES ('Raju','ME',97);

SELECT * FROM MbaStudentDetails


CREATE TABLE StudentDetails (
    StdName VARCHAR(255),
   StdGrade VARCHAR(255),
    StdMark INT
);


INSERT INTO StudentDetails VALUES ('Biplab','A',70);
INSERT INTO StudentDetails VALUES ('Happy','B',85);
INSERT INTO StudentDetails VALUES ('Siba','C',90);
INSERT INTO StudentDetails VALUES ('Rahul','MD',95);
INSERT INTO StudentDetails VALUES ('Biswa','E',97);

SELECT * FROM StudentDetails

7. Student API application is exposed to port 8000 and Postgres SQL to port 5432




