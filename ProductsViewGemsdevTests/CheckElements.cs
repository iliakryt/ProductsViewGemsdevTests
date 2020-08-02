using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace ProductsViewGemsdevTests
{
    class CheckElements
    {
        private IWebDriver _webDriver;
        private const string _sectionGeoMeta = "my-150";
        private const string _sectionGosSystem = "gos-system bg_circle";
        private const string _sectionUrbanAnalytics = "urban-analytics";
        private const string _sectionOtherProducts = "other-products bg_circle";

        public CheckElements(IWebDriver webDriver) 
        {
            _webDriver = webDriver;
        } 

        public bool CheckSectionViewGeoMeta()
        {         
            try
            {
                bool check =_webDriver.PageSource.Contains(_sectionGeoMeta);
                if (check == false)
                {
                    return false;
                }
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool CheckSectionViewGosSystem()
        {
            try
            {
                bool check = _webDriver.PageSource.Contains(_sectionGosSystem);
                if (check == false)
                {
                    return false;
                }
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool CheckSectionViewUrbanAnalytics()
        {
            try
            {
                bool check = _webDriver.PageSource.Contains(_sectionUrbanAnalytics);
                if (check == false)
                {
                    return false;
                }
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool CheckSectionViewOtherProducts()
        {
            try
            {
                bool check = _webDriver.PageSource.Contains(_sectionOtherProducts);
                if (check == false)
                {
                    return false;
                }
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool CheckReferenceGosSystem()
        {
            try
            {
                bool check = _webDriver.PageSource.Contains(_sectionOtherProducts);
                if (check == false)
                {
                    return false;
                }
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
