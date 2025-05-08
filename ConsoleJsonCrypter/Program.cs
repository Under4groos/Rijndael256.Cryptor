


using ConsoleJsonCrypter;
using Rijndael256.Cryptor;
using Rijndael256.Cryptor.Structures;




Console.WriteLine($"Random: \"{Cryptor.GenerateRandomString(30)}\"");
Console.WriteLine("==========");
string key = "cpcxwrPNL7r6xuRtmEC2CwZuR5ymHm";

MyUserData myUserData = new MyUserData("JohnDoe", "john.doe@example.com", 25);

CryptObject jsonDataEncrypted = myUserData.ObjToJsonEncrypt(key);

Console.WriteLine(jsonDataEncrypted);
Console.WriteLine("==========");
MyUserData object_ = (MyUserData)jsonDataEncrypted.EncryptData.JsonToObjDecrypt(key, typeof(MyUserData));

object_.DisplayUserInfo();

