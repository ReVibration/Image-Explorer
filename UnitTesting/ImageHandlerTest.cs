/// <summary>
/// Author - Bartek Siwak
/// Date - 23/11/22
/// </summary>
namespace UnitTesting
{
    /// <summary>
    /// Test Class for ImageHandler Unit
    /// 
    /// The ImageHandler Class Should:
    /// 1. Display the correct image passed in
    /// 2. If the filename is invalid throw an InvalidFileException
    /// 
    /// </summary>
    [TestClass]
    public class ImageHandlerTest
    {
        // DECLARE a constant image variable to hold the correct image that should be displayed, call it CORRECT_IMAGE
        Image CORRECT_IMAGE;

        // DECLARE a image handler for the tests 
        IImageHandler _imgHandler;

        /// <summary>
        ///  Setup is reponsible for setting up all of the tests 
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            // ASSIGN the image with the correct image 
            CORRECT_IMAGE = Image.FromFile(Path.GetFullPath("..\\..\\..\\..\\OrangeFish.png"));
            // ASSIGN the _imgHandler with a new ImageHandler
            _imgHandler = new ImageHandler();
        }

        #region 1.Display the correct image passed
        /// <summary>
        /// DisplayCorrectImage check the first use case being 1.Display the correct image passed in
        /// </summary>
        [TestMethod]
        private void DisplayCorrectImage()
        {
            #region ARRANGE
            //DECLARE a variable to check whether the test has passed, call it hasPassed, ASSIGN it to false
            Boolean hasPassed = false;
            // DECLARE a string that will hold the path to the image passed in, call it imgPath, ASSIGN it to the correct image path
            string imgPath = Path.GetFullPath("..\\..\\..\\..\\OrangeFish.png");
            // DECLARE a image to hold the result from load image
            Image imgResult;
            #endregion

            #region ACT
            // RUN the load image method from the image handler with imgPath passed in
            imgResult = _imgHandler.LoadImage(imgPath);
            // CHECK whether the image that has been return is the same size are the correct image
            if ((imgResult.Width == CORRECT_IMAGE.Width) && (imgResult.Height == CORRECT_IMAGE.Height))
            {
                //IF so then assign has pass equal to true
                hasPassed = true;
            }
            #endregion

            #region ASSERT
            // ASSERT whether has passed is true determining whether the behaviour is correct
            Assert.IsTrue(hasPassed);
            #endregion

        }
        #endregion

        #region 2.If the filename is invalid throw an InvalidFileException

        /// <summary>
        /// InvalidFilename checks whether an exception is ran if an invalid filename is passed
        /// </summary>
        [TestMethod]
        private void InvalidFilename()
        {
            #region ARRANGE
            // DECLARE a boolean to check whether the exception, call it hasThrown, Assign it to false
            bool hasThrown = false;
            // DECLARE a string to a path name that doesn't exist, call it imgPath, Assign it that path name
            string imgPath = Path.GetFullPath("..\\..\\..\\..\\orangeefish.png");
            #endregion

            #region ACT
            try
            {
                // TRY to load an invalid image
                _imgHandler.LoadImage(imgPath);
            }
            catch
            {
                // IF an exception has been thrown catch it and assign hasThrown to true
                hasThrown = true;
            }
            #endregion

            #region ASSERT
            // ASSERT whether has thrown is true
            Assert.IsTrue(hasThrown);
            #endregion
        }

        #endregion
    }
}