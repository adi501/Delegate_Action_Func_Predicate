**Delegates, Func, Action, Predicate in c#?**

**Delegates**
Delegates are pointers to function. Delegates are used for implementing events and call back methods.
Delegates are two types 
•	Single Cast Delegates
•	Multi Cast Delegates

**Single Cast Delegates**

![image](https://github.com/user-attachments/assets/cb99f83f-7007-427d-aeb3-042875ae8a49)

**Multi Cast Delegates**

 ![image](https://github.com/user-attachments/assets/282abec4-eee4-412e-83af-f31a24fbe99c)

**Func, Action and Predicate**

Func, Action and Predicate are define in C# 3.0 and these are generic inbuilt delegates. The above steps are not required, if you use these delegates.

**Func Delegate**

Func is generic delegate present in System namespace. It takes one or more input parameters and returns one out parameter. The last parameter is considered as a return value.
 
Func delegate type can include 0 to 16 input parameters of different types. It must have one return type. So return type is mandatory but input parameter is not.
 
 ![image](https://github.com/user-attachments/assets/b9a4e2ad-74dc-4a6d-85e9-3411a50d5f94)

![image](https://github.com/user-attachments/assets/d8afeb2c-1fac-4032-8190-772bc80e6455)

![image](https://github.com/user-attachments/assets/046fcdb9-2ddd-41a8-998c-611901e0bd01)

**Action Delegate**

Action is a generic delegate present in System namespace. It takes one or more input parameters and returns nothing.

So it does not return any value.

![image](https://github.com/user-attachments/assets/bd00e947-4705-4559-8d3f-4ec59f0b347d)


![image](https://github.com/user-attachments/assets/5d4c8fa8-9a84-4442-b8e1-b4028c2ea078)

 
![image](https://github.com/user-attachments/assets/41be4eab-d51e-4f32-ba5b-92a80dc26792)

**Predicate Delegate**

Predicate delegate is also inbuilt generic delegate and is present in System namespace.
It is used to verify certain criteria of method and returns output as Boolean, either True or False.

Predicate can be used with method, anonymous and lambda expression.

![image](https://github.com/user-attachments/assets/59323486-aa0f-45cf-a075-9ac9931f9a7b)

 
![image](https://github.com/user-attachments/assets/9d5b7021-cb73-4a43-9a7d-b0b88fb0b833)


 ![image](https://github.com/user-attachments/assets/5bf4a086-7065-4671-ada6-ad58631fe713)

 
