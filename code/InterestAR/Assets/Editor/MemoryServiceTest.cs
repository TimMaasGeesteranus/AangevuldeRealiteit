using System;
using System.Diagnostics;
using Assets.Scripts.Services;
using NUnit.Framework;

namespace Assets.Editor
{
    public class MemoryServiceTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void MemoryDataServiceShouldSaveLanguage()
        {
            string language = "Nederlands";
            // Makes sure initial value is returned
            MemoryDataService.ClearData();

            // Should return English as initial value
            Assert.AreEqual("English", MemoryDataService.Language);
            MemoryDataService.Language = language;

            // Save directly instead saving on closure
            MemoryDataService.DirectSave();
            Assert.AreEqual(language, MemoryDataService.Language);
        }
    }
}
