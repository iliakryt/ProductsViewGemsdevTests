using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace ProductsViewGemsdevTests
{
    public class GemsDevTests
    {
        private IWebDriver driver;
        private readonly By _productButton = By.XPath("//header//li[@id = 'menu-item-45']//a[text() = 'Продукты']");      
        private readonly By _referenceGosSystem = By.XPath("//section[@class='gos-system bg_circle']/descendant::a[@href = 'https://xn--c1aaceme9acfqh.xn--p1ai/']");
        
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://gemsdev.ru/");
            var product = driver.FindElement(_productButton);
            product.Click();           
        }
        
        [Test]
        public void ViewGeoMetaTest()
        {
            var checkElement = new CheckElements(driver);
            Assert.IsTrue(checkElement.CheckSectionViewGeoMeta(), "Раздел \"GeoMeta\" не найдет");
        }

        [Test]
        public void ViewGosSystemTest()
        {
            var checkElement = new CheckElements(driver);
            Assert.IsTrue(checkElement.CheckSectionViewGosSystem(), "Раздел \"Государственная система обеспечения градостроительной деятельности\" не найдет");
        }

        [Test]
        public void ViewUrbanAnalyticsTest()
        {
            var checkElement = new CheckElements(driver);
            Assert.IsTrue(checkElement.CheckSectionViewUrbanAnalytics(), "Раздел \"Городская аналитика\" не найдет");
        }

        [Test]
        public void ViewOtherProductsTest()
        {
            var checkElement = new CheckElements(driver);
            Assert.IsTrue(checkElement.CheckSectionViewOtherProducts(), "Раздел \"Другие наши продукты\" не найдет");
        }

        [Test]
        public void ReferenceGosSystem()
        {
            Thread.Sleep(500);
            var actualReferenceGosSystem = driver.FindElement(_referenceGosSystem);
            Assert.IsNotNull(actualReferenceGosSystem, "Ссылка не найдена");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
