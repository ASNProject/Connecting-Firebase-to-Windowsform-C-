# Connecting-Firebase-to-Windowsform-C-Sharp

Hallo, Now i want to give some tutorial to Connecting Realtime database Firebase to Windowsform with Visual Studio C#. Firebase is realtime database from Google to develope our project. Firebase database isn't SQL database but it is a JSON format database. Is very easy to learn make some project with database. So, let get started!.

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

To find the Token and link, Please follow this image below:<br />
###### Find link firebase

![image](https://user-images.githubusercontent.com/49858542/91788319-1ac92380-ec36-11ea-9e96-eac7a45c1a22.png)

###### Find Token Secret Firebase<br />
Choose Setting => Setting Project => Service Account => Secret Database => Copy the uniqe code 

![image](https://user-images.githubusercontent.com/49858542/91788511-9925c580-ec36-11ea-8814-77973f332768.png)

![image](https://user-images.githubusercontent.com/49858542/91788520-9e831000-ec36-11ea-8d61-b8459a984948.png)

###### c. Write code if the Button Click

        private void button1_Click(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                label1.Text = "Connected Firebase";
                label1.ForeColor = Color.Green;
            }
        }

## 6. Run the project

![image](https://user-images.githubusercontent.com/49858542/91788671-fde12000-ec36-11ea-9979-aeb1a997f0ae.png)

![image](https://user-images.githubusercontent.com/49858542/91788677-00dc1080-ec37-11ea-8151-0f3094423de2.png)

## 7. Full Source Code

        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.Data;
        using System.Drawing;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;
        using System.Windows.Forms;

        using FireSharp.Config;
        using FireSharp.Interfaces;
        using FireSharp.Response;

        namespace Connecting_Firebase_to_CSharp
        {
            public partial class Form1 : Form
            {
                IFirebaseConfig config = new FirebaseConfig
            {
                 AuthSecret = "kE5gZJFZXJLsKgQGYaTpL40690kkhOpJNC3UjjO8", //Masukkan Token Rahasia Firebase
                 BasePath = "https://fir-csharp-cb339.firebaseio.com/" //Masukkan Link Firebase
            };

                IFirebaseClient client;

            public Form1()
             {
                InitializeComponent();
             }

            private void button1_Click(object sender, EventArgs e)
             {
                  client = new FireSharp.FirebaseClient(config);
                   if (client != null)
             {
                label1.Text = "Connected Firebase";
                label1.ForeColor = Color.Green;
            }
              }

             private void Form1_Load(object sender, EventArgs e)
             {
    
              }
    
             private void label1_Click(object sender, EventArgs e)
             {

             }


             }
           }








###### Author

ASNProject<br />
email: asnproject02@gmail.com








