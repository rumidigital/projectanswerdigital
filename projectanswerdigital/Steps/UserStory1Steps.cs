using projectanswerdigital.POM;
using System;
using TechTalk.SpecFlow;

namespace projectanswerdigital.Steps
{
    [Binding]
    public class UserStory1Steps
    {
        private PomModelMethods methods;
        private BasePageObjects obj = new BasePageObjects();
        private ScenarioContext scenarioContext;

        [Given(@"I add a faded short sleeve t-shirt to the cart")]
        public void GivenIAddAFadedShortSleeveT_ShirtToTheCart()
        {
            methods.FIndELementAndClick(obj.FadedShortSleeveTshirt);
            methods.FIndELementAndClick(obj.AddtoCart);
        }

        [Given(@"I navigate to the cart")]
        public void GivenINavigateToTheCart()
        {
            methods.FIndELementAndClick(obj.BasketIcon);
        }

        [When(@"I select the delete icon")]
        public void WhenISelectTheDeleteIcon()
        {
            methods.FIndELementAndClick(obj.DeleteIcon);
        }

        [Then(@"I should be presented with a banner that statesyour shopping cart is empty")]
        public void ThenIShouldBePresentedWithABannerThatStatesyourShoppingCartIsEmpty()
        {
            methods.FIndElementIsPresent(obj.BannerEmptyCartMessage);
        }
    }
}
