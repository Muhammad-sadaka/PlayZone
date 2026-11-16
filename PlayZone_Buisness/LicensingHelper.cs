using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace PlayZone_Buisness;

public static class LicensingHelper
{
    private static string filePath = "license.dat";
    
    // حفظ المفتاح في ملف
    public static void SaveLicenseKey(string key)
    {
        File.WriteAllText(filePath, key);
    }
    
    // قراءة المفتاح من الملف
    public static string ReadLicenseKey()
    {
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath).Trim();
        }
        return string.Empty;
    }
    
    public static string GetMachineId()
    {
        string cpuInfo = "";
        try
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"]?.Value?.ToString() ?? "";
                break;
            }
        }
        catch
        {
            cpuInfo = "PC_ID_FALLBACK";
        }

        return GetHash(cpuInfo + "PlayZone_Secret_Key");
    }

    private static string GetHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 6; i++) // نأخذ أول جزء فقط ليصبح مفتاحاً قصيراً
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            // تنسيق الكود على شكل مقاطع مثل: A1B2-C3D4-E5F6
            string raw = builder.ToString();
            return $"{raw.Substring(0, 4)}-{raw.Substring(4, 4)}-{raw.Substring(8, 4)}";
        }
    }

    public static bool ValidateActivationKey(string enteredKey)
    {
        string expectedKey = GenerateKeyForMachine(LicensingHelper.GetMachineId());
        return string.Equals(expectedKey, enteredKey.Trim(), StringComparison.OrdinalIgnoreCase);
    }

    public static string GenerateKeyForMachine(string machineId)
    {
        return GetHash(machineId + "MySuperSecretSalt2026");
    }
}