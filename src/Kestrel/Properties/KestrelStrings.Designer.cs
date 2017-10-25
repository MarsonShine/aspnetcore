// <auto-generated />
namespace Microsoft.AspNetCore.Server.Kestrel
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class KestrelStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Server.Kestrel.KestrelStrings", typeof(KestrelStrings).GetTypeInfo().Assembly);

        /// <summary>
        /// An 'https' URL was provided, but a development certificate could not be found.
        /// </summary>
        internal static string HttpsUrlProvidedButNoDevelopmentCertificateFound
        {
            get => GetString("HttpsUrlProvidedButNoDevelopmentCertificateFound");
        }

        /// <summary>
        /// An 'https' URL was provided, but a development certificate could not be found.
        /// </summary>
        internal static string FormatHttpsUrlProvidedButNoDevelopmentCertificateFound()
            => GetString("HttpsUrlProvidedButNoDevelopmentCertificateFound");

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
