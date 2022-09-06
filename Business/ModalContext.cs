using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class ModalContext
    {
        public static bool DoesModalExist()
        {
            try
            {
                if (
                    DriverHolder.Driver
                    .FindElements(By.XPath("(//div[@role='dialog'])[2]")).Count == 0
                    )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static void TryToCloseModal()
        {
            if (DoesModalExist())
            {
                ModalWindow.CloseModalWindowButton.Click();
            }
        }
    }
}
