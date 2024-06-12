using Newtonsoft.Json;

namespace AndreasReitberger.Shared.XForm.Core.Utilities
{
    public class SecretAppSettingReader
    {
        // Source: https://www.programmingwithwolfgang.com/use-net-secrets-in-console-application/
        public static T? ReadSection<T>(string sectionName)
        {
            // Needs the Directory.Build.targets in order to work (copies the secret.json as EmbeddedResource to the app)
            string settings = UserSecretsManager.Settings[sectionName].ToString();
            return JsonConvert.DeserializeObject<T>(settings);
        }
    }
}
