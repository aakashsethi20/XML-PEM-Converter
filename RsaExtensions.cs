using System.Security.Cryptography;

using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace XmlPemConverter;

public static class RsaExtensions
{
    public static AsymmetricCipherKeyPair? GetKeyPair(this RSA rsa)
    {
        try
        {
            return DotNetUtilities.GetRsaKeyPair(rsa);
        }
        catch
        {
            return null;
        }
    }

    public static RsaKeyParameters? GetPublicKey(this RSA rsa)
    {
        try
        {
            return DotNetUtilities.GetRsaPublicKey(rsa);
        }
        catch
        {
            return null;
        }
    }
}
