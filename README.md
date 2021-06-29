# WPF-Hybrid-Cryptography
Algorithms used : AES-128(CBC), RSA, SHA-256

This application reads any txt file and ecrypts/decrypts the contents of this file.

Desclaimer! Due to time constraints and limited experience in programming(forgot essential OOP stuff that i really needed :)) and wpf in general. The Signature Part of the Program is still under work and it's not working as inteded. Also currently i can't get the code to stop creating a new key with the symmetric algorithm (AES) when it's decrypting but it does somehow decrypt correctly (key used for encryption is not equal to the key used for decryption or that's what i think is going on i might be wrong about this).

I apologise for the spaghetti code. Keep in mind that i am still a beginner.

-Link to Package used within the Program:

https://github.com/myloveCc/NETCore.Encrypt


-Before you run the program install the package first using 
the NuGet Package Manager Console in Visual Studio (Tools> NuGet Package Manager> Package Manager Console) 
 by writing the following code:

Install-Package NETCore.Encrypt -Version 2.0.9


If by any chance this didn't work I will include a link to a self-contained 
executable file.

Link: https://drive.google.com/file/d/1o4NfWFo9ZYYz5qnaCSpGCybjPLFRr5nS/view?usp=sharing

Please note that the picture below shows how this would work in a sender/reciever scenario.
My program is just focused on the Encryption/Decryption part of it ONLY.

![HybridModel](https://user-images.githubusercontent.com/59689940/119700094-20653a00-be53-11eb-8c16-1e1f09c6779c.png)

This is a screenshot from the Program.
![image](https://user-images.githubusercontent.com/59689940/119704513-067a2600-be58-11eb-82c4-15f072f5c875.png)


