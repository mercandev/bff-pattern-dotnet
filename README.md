## Backend for Frontend Example Dotnet   

What is BFF (Front-End to Back-End)? There is a very good article written on this subject. [Link](https://samnewman.io/patterns/architectural/bff) 

In this example, we created 5 different json returning endpoints in [Mockoon](https://mockoon.com/) application, considering that more than one field in the profile tab of the twitter application is due to microservices.

<img width="1000" alt="image" src="https://user-images.githubusercontent.com/22862224/222963620-8c45e3db-0403-4468-9ed6-3140c5c78f07.png">


The application returns data readonly by connecting with many microservices through a single gateway. I have drawn a sample diagram related to this topic.

<img width="1089" alt="bff_example" src="https://user-images.githubusercontent.com/22862224/222963708-e8dfc7f2-0b20-4b83-ac2d-ca0f49250e5b.png">
