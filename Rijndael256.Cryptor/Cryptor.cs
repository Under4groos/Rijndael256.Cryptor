using Newtonsoft.Json;
using Rijndael256.Cryptor.Rijndael256;
using Rijndael256.Cryptor.Structures;

namespace Rijndael256.Cryptor
{
    public static class Cryptor
    {
        public static string Decrypt(string etmCiphertext, string password, KeySize keySize = KeySize.Aes256)
        {
            return RijndaelEtM.Decrypt(etmCiphertext, password, keySize);
        }
        public static string Encrypt(string etmCiphertext, string password, KeySize keySize = KeySize.Aes256)
        {
            return RijndaelEtM.Encrypt(etmCiphertext, password, keySize);
        }

        public static object JsonToObjDecrypt(this string etmCiphertext, string password, Type type, KeySize keySize = KeySize.Aes256)
        {

            string decryptJson = Decrypt(etmCiphertext, password, keySize);
            return JsonConvert.DeserializeObject(decryptJson, type);
        }
        public static CryptObject ObjToJsonEncrypt(this object etmCiphertext, string password, KeySize keySize = KeySize.Aes256)
        {
            CryptObject cryptObject = new CryptObject();
            cryptObject.Data = JsonConvert.SerializeObject(etmCiphertext);

            cryptObject.EncryptData = Encrypt(cryptObject.Data, password, keySize);
            return cryptObject;
        }

        public static int[] Range = Enumerable.Range(48, 122)
            .Where(i => (i < 58 || i >= 65 && i <= 90 || i >= 97 && i <= 122))
            .ToArray();
        public static string GenerateRandomString(int length) =>
            new string(Enumerable.Range(0, length)
            .Select(_ => (char)Range[new Random().Next(Range.Length)])
            .ToArray());

    }
}
