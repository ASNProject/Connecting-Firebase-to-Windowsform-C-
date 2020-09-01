# Connecting-Firebase-to-Windowsform-C-Sharp

Hallo, Now i want to give some tutorial to Connecting Realtime database Firebase to Windowsform with Visual Studio C#. Firebase is realtime database from Google to develope our project. Firebase database isn't SQL database but it is a JsON format database. Is very easy to learn make some project with database. So, let get started!.

## 1. Create new project windowsform with Visual Studio C#

![image](https://user-images.githubusercontent.com/49858542/91786585-2581b980-ec32-11ea-804e-053361142342.png)

## 2. Create design of Windowsform

![image](https://user-images.githubusercontent.com/49858542/91786918-f3248c00-ec32-11ea-8b2d-604eee02873b.png)

Tabel Component of Windowsform
| No |           Component           |         Value       |
|----|-------------------------------|---------------------|
| 1 | Button  | Connecting to Firebase|
| 2 | Label | Not Connected |

## 3. Install package library FireSharp.Serialization.JsonNet

Choose Project => Manage NuGet Package

![image](https://user-images.githubusercontent.com/49858542/91787301-c0c75e80-ec33-11ea-8d2a-6baf5c7db57b.png)

Browse => Search " FireSharp.Serialization.JsonNet => Install

![image](https://user-images.githubusercontent.com/49858542/91787325-d046a780-ec33-11ea-86ea-06b9be664939.png)


## 4. Create a new Realtime Firebase

Open link Firebase and login with Google email. https://firebase.google.com/?hl=id

![image](https://user-images.githubusercontent.com/49858542/91787542-582cb180-ec34-11ea-868f-1eb699632f01.png)

Create new firebase database. (Follow image below to create new database)

![image](https://user-images.githubusercontent.com/49858542/91787605-785c7080-ec34-11ea-9768-05a360510f6d.png)

![image](https://user-images.githubusercontent.com/49858542/91787614-7db9bb00-ec34-11ea-87cd-d098afc21048.png)


![image](https://user-images.githubusercontent.com/49858542/91787619-81e5d880-ec34-11ea-8662-38f6375fb9fc.png)

Choose Realtime database.

![image](https://user-images.githubusercontent.com/49858542/91787731-b8bbee80-ec34-11ea-8b5a-54674ee44986.png)

Make rules like it.

![image](https://user-images.githubusercontent.com/49858542/91787748-c3768380-ec34-11ea-9752-b8119a040621.png)

## 5. Open view code and write code

###### a. Write import library FireSharp

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

###### b. Write code in the Class

    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "kE5gZJFZXJLsKgQGYaTpL40690kkhOpJNC3UjjO8", //Input Token Secret Firebase Realtime
            BasePath = "https://fir-csharp-cb339.firebaseio.com/" //Input link firebase
        };

        IFirebaseClient client;
    }

TO 






