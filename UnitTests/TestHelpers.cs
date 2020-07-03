using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace UnitTests
{
    public static class TestHelpers
    {
        private static string TestImagesPath
        {
            get
            {
                var path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"..\..\..\";
                path = Path.Combine(path, "TestImages");
                return path;
            }
        }

        public static string TestImagePath(string subfolder, string filename)
        {
            return Path.Combine(TestImagesPath, subfolder, filename);
        }
    }
}