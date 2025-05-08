namespace Rijndael256.Cryptor.Structures
{
    public struct CryptObject
    {
        public string Data;
        public string EncryptData;

        public override string ToString()
        {
            return $"Data: \"{Data}\"\nEncryptData: \"{EncryptData}\"";
        }
    }
}
