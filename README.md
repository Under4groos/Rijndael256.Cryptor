# Rijndael256.Cryptor


```link
https://github.com/2Toad/Rijndael256
https://www.newtonsoft.com/json
```



## include

```cs
using Rijndael256.Cryptor;
using Rijndael256.Cryptor.Structures;
```

## using code

```cs
Console.WriteLine($"Random: \"{Cryptor.GenerateRandomString(30)}\"");
Console.WriteLine("==========");
string key = "cpcxwrPNL7r6xuRtmEC2CwZuR5ymHm";

MyUserData myUserData = new MyUserData("JohnDoe", "john.doe@example.com", 25);

CryptObject jsonDataEncrypted = myUserData.ObjToJsonEncrypt(key);

Console.WriteLine(jsonDataEncrypted);
Console.WriteLine("==========");
MyUserData object_ = (MyUserData)jsonDataEncrypted.EncryptData.JsonToObjDecrypt(key, typeof(MyUserData));

object_.DisplayUserInfo();
```

```
Random: "timCMVB9GlKYLzLfPy39oJ1mTEeG8X"
==========
Data: "{"UserName":"JohnDoe","Email":"john.doe@example.com","Age":25}"
EncryptData: "rlYzNjM//5fOnBwhai1zTAeY4wdxOn0a1IIxIVJ9fsxvUdwx5fUEfaaIqonwK0qTA8Hi4eAljswFoMj9tJ1SfoXqpHfnEztoH/X01tOZr7RX/hwYNwhenqLWvcOWCc85SQDNmompUwn1FcQLQfRmw2bEvPAuTsZjnijpIPlesN9m00M453XFITcp1Ui6OHyE"
==========
User Name: JohnDoe
Email: john.doe@example.com
Age: 25
```
