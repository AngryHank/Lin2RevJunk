using System;
using System.IO;
using System.Security.Cryptography;

namespace Decryptify
{
    class TripleDESManagedExample
    {
        public static byte[] DES_Key
        {
            get { return System.Text.Encoding.ASCII.GetBytes("Netmarbl"); }
        }

        public static void Main(string[] args)
        {

            // Mapping for files that require the use of custom IV strings
            var customFileIV = new System.Collections.Generic.Dictionary<string, string>()
                {
                    { "CastleSiegeBuffRule.csv", "SiegeBuf" },
                    { "CastleSiegeBuffRule_Name.csv", "SiegeBuf" },
                    { "DialogGuide.csv", "Dialog.c" },
                    { "EsportsConst.csv", "Const_eS" },
                    { "FortressSiegeBuffRule.csv", "SiegeBuf" },
                    { "FortressSiegeBuffRule_Name.csv", "SiegeBuf" },
                    { "GuildAchievement.csv", "Achievem" },
                    { "GuildAchievement_Name.csv", "Achievem" },
                    { "HelpUrl.csv", "Help.csv" },
                    { "HelpUrl_Name.csv", "Help.csv" },
                    { "MissionDaily.csv", "Mission." },
                    { "MissionDaily_Name.csv", "Mission." },
                    { "MissionDailyReward.csv", "Mission." },
                    { "MissionWeekly.csv", "Mission." },
                    { "MissionWeekly_Name.csv", "Mission." },
                    { "MissionWeeklyReward.csv", "Mission." },
                    { "NpcSpawn.csv", "/NpcSpaw" },
                    { "PetConditionString.csv", "Pet.csv" },
                    { "PetExp.csv", "Pet.csv" },
                    { "PetGrade.csv", "Pet.csv" },
                    { "PromoteGrade.csv", "Promote." },
                    { "Quest.csv", "/Quest/0" },
                    { "Quest_Name.csv", "/Quest/0" },
                    { "ServerString.csv", "String.c" },
                    { "ServerString_Name.csv", "String.c" },
                    { "ShopInApp.csv", "Shopinap" },
                    { "ShopItem.csv", "Shop.csv" },
                    { "ShopItem_Name.csv", "Shop.csv" },
                    { "ShopItemProduct.csv", "ShopProd" },
                    { "SlanderName.csv", "Slander." },
                    { "SlanderMessage_Name.csv", "Slander." },
                    { "UseableAchievementTask.csv", "Achievem" }
                };

            foreach (string filename in args)
            {
                Console.WriteLine("File: {0}", filename);

                byte[] fileData = System.IO.File.ReadAllBytes(filename);
                // Default the IV string to the filename.  
                string unformattedIV = Path.GetFileName(filename);
                // Looks to find if there is an undersore in file name
                int offset = unformattedIV.IndexOf('_');
                // Override if there is a custom IV string
                // If not then will remove underscores and replace with .csv
                if (customFileIV.ContainsKey(unformattedIV))
                {
                    unformattedIV = customFileIV[unformattedIV];
                }
                else if (offset >= 0)
                {
                    unformattedIV = unformattedIV.Substring(0, offset) + ".csv";
                }


                byte[] fileIV = System.Text.Encoding.ASCII.GetBytes(unformattedIV.PadRight(8, '\0').Substring(0, 8));


                try
                {
                    using (DESCryptoServiceProvider provider = new DESCryptoServiceProvider())
                    {

                        provider.Key = DES_Key;
                        provider.IV = fileIV;

                        ICryptoTransform crypto = provider.CreateDecryptor();

                        using (MemoryStream dataStream = new MemoryStream(fileData))
                        using (CryptoStream cryptStream = new CryptoStream(dataStream, crypto, CryptoStreamMode.Read))
                        using (StreamReader decryptedStream = new StreamReader(cryptStream))
                        {
 
                            string outData = decryptedStream.ReadToEnd();

                            string filePath = Path.GetDirectoryName(filename);
                            string outPath = Path.Combine(filePath, "Decrypted");
                            if (!Directory.Exists(outPath))
                            {
                                Directory.CreateDirectory(outPath);
                            }


                            string outFile = Path.Combine(outPath, Path.GetFileName(filename));

                            File.WriteAllText(outFile, outData);
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
        }
    }
}
 