


# The AutoSignup Task 

>1st: How it's working 

>2nd: Featuers

>3rd: Limitations and issues



![Build Status](http://img.shields.io/travis/badges/badgerbadgerbadger.svg?style=flat-square) ![Coverage Status](http://img.shields.io/coveralls/badges/badgerbadgerbadger.svg?style=flat-square)

![Screenshot (251)](https://user-images.githubusercontent.com/13305274/82570065-63763880-9b81-11ea-8c66-37be8a6280b9.png)



***The structure of the project***


- Begin with the test cases that that handled by the frame work that interacts selemnum as below
![Architecture](https://user-images.githubusercontent.com/13305274/82571078-b8667e80-9b82-11ea-91f6-da57558fe977.png)
>The Case Tests

- The key is too keep every thing simple

![carbon (2)](https://user-images.githubusercontent.com/13305274/82580992-2f564400-9b90-11ea-8e35-068e8eb3b7f7.png)




> The Framework

-Apllied the Page Object model and OOP principle 


![OP)](https://user-images.githubusercontent.com/13305274/82574080-e51c9500-9b86-11ea-9204-2dc752c97c91.png) ![Screenshot (258)](https://user-images.githubusercontent.com/13305274/82574636-afc47700-9b87-11ea-8eda-2f5b66f62b10.png)

> And for each element in the registration procces there is is a generator 

![Screenshot (260)](https://user-images.githubusercontent.com/13305274/82574951-1fd2fd00-9b88-11ea-85dc-2aec272a5fc1.png)

> The browser that handles it all

![carbon (1)](https://user-images.githubusercontent.com/13305274/82580799-f74f0100-9b8f-11ea-8f7c-dea80c3d7ac5.png)






**Features**

>Takes screenshoots to failure and make html Report .. save it in extent report file

![Screenshot (262)](https://user-images.githubusercontent.com/13305274/82576232-e13e4200-9b89-11ea-9209-c4f4c3b2936c.png)

>Managed to intercept the egistration Request and response using Using "BrowserProxy mob" 
- registration process It saves the HAR [http archive] report that can be read by chrome HAR reader 
![unnamed](https://user-images.githubusercontent.com/13305274/82577048-b7d1e600-9b8a-11ea-8f16-982e1eb9a9de.png)


***Limitations and issues***


<br>-Some issues may show up while registration like Xpath may changed 
<br>-Proxy capabilites failed to make a prefrience to chromedriver some times
<br>-Miss implementing the last registerd user cardinalites which can to login with 


## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright Shrief Fadl©2020 
