using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Social" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SocialTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Social" />)
        /// </summary>
        public SocialTest() : base(typeof(Social))
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Social) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _socialInstanceType;
        private Social _socialInstance;
        private Social _socialInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Social" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _socialInstanceType = typeof(Social);
            _socialInstanceFixture = this.Create<Social>(false);
            _socialInstance = _socialInstanceFixture ?? this.Create<Social>(true);
            CurrentInstance = _socialInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Social) Initializer

        #region Methods

        private const string MethodGetTweets = "GetTweets";
        private const string MethodConstructTweet = "ConstructTweet";
        private const string MethodConvertTextURL = "ConvertTextURL";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (Social) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Social_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Social) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Social_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Social)

        #region General Initializer : Class (Social) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetTweets, 0)]
        [TestCase(MethodConstructTweet, 0)]
        [TestCase(MethodConvertTextURL, 0)]
        public void AUT_Social_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Social) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Social" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_Social_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Social) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Social" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Social_Is_Instance_Present_Test()
        {
            // Assert
            _socialInstanceType.ShouldNotBeNull();
            _socialInstance.ShouldNotBeNull();
            _socialInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Social) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Social" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Social_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _socialInstance.ShouldBeAssignableTo<Social>();
            _socialInstanceFixture.ShouldBeAssignableTo<Social>();
            CurrentInstance.ShouldBeAssignableTo<Social>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Social) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Social_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Social instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Social(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _socialInstance.ShouldNotBeNull();
            _socialInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Social>();
        }

        #endregion

        #region General Constructor : Class (Social) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Social_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Social instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Social(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _socialInstance.ShouldNotBeNull();
            _socialInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetTweets) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);

            // Act
            Action executeAction = () => _socialInstance.GetTweets();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _socialInstance.GetTweets();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            Type [] methodGetTweetsParametersTypes = null;
            object[] parametersOfGetTweets = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTweets, methodGetTweetsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_socialInstanceFixture, parametersOfGetTweets);
            var result2 = this.GetResultOfMethod<string>(MethodGetTweets, parametersOfGetTweets, methodGetTweetsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTweets.ShouldBeNull();
            methodGetTweetsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            Type [] methodGetTweetsParametersTypes = null;
            object[] parametersOfGetTweets = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTweets, parametersOfGetTweets, methodGetTweetsParametersTypes);

            // Assert
            parametersOfGetTweets.ShouldBeNull();
            methodGetTweetsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            Type [] methodGetTweetsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTweets, methodGetTweetsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTweetsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            Type [] methodGetTweetsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTweets, methodGetTweetsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTweetsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTweets) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_GetTweets_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTweets);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTweets, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Social_ConstructTweet_Method_Call_Internally(Type[] types)
        {
            var methodConstructTweetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConstructTweet, methodConstructTweetParametersTypes);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var xDocument = this.CreateType<XDocument>();
            var methodConstructTweetParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfConstructTweet = { xDocument };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructTweet, methodConstructTweetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_socialInstanceFixture, out exception1, parametersOfConstructTweet);
            var result2 = this.GetResultOfMethod<string>(MethodConstructTweet, parametersOfConstructTweet, methodConstructTweetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConstructTweet.ShouldNotBeNull();
            parametersOfConstructTweet.Length.ShouldBe(1);
            methodConstructTweetParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var xDocument = this.CreateType<XDocument>();
            var methodConstructTweetParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfConstructTweet = { xDocument };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConstructTweet, methodConstructTweetParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_socialInstanceFixture, parametersOfConstructTweet);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConstructTweet.ShouldNotBeNull();
            parametersOfConstructTweet.Length.ShouldBe(1);
            methodConstructTweetParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var xDocument = this.CreateType<XDocument>();
            var methodConstructTweetParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfConstructTweet = { xDocument };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConstructTweet, parametersOfConstructTweet, methodConstructTweetParametersTypes);

            // Assert
            parametersOfConstructTweet.ShouldNotBeNull();
            parametersOfConstructTweet.Length.ShouldBe(1);
            methodConstructTweetParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var methodConstructTweetParametersTypes = new Type[] { typeof(XDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConstructTweet, methodConstructTweetParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConstructTweetParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var methodConstructTweetParametersTypes = new Type[] { typeof(XDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConstructTweet, methodConstructTweetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConstructTweetParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructTweet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConstructTweet) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConstructTweet_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConstructTweet);
            var currentMethodInfo = this.GetMethodInfo(MethodConstructTweet, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Social_ConvertTextURL_Method_Call_Internally(Type[] types)
        {
            var methodConvertTextURLParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertTextURL, methodConvertTextURLParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var str = this.CreateType<string>();
            var strDisplay = this.CreateType<string>();
            var methodConvertTextURLParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertTextURL = { str, strDisplay };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertTextURL, methodConvertTextURLParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_socialInstanceFixture, out exception1, parametersOfConvertTextURL);
            var result2 = this.GetResultOfMethod<string>(MethodConvertTextURL, parametersOfConvertTextURL, methodConvertTextURLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertTextURL.ShouldNotBeNull();
            parametersOfConvertTextURL.Length.ShouldBe(2);
            methodConvertTextURLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var str = this.CreateType<string>();
            var strDisplay = this.CreateType<string>();
            var methodConvertTextURLParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertTextURL = { str, strDisplay };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertTextURL, methodConvertTextURLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_socialInstanceFixture, parametersOfConvertTextURL);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertTextURL.ShouldNotBeNull();
            parametersOfConvertTextURL.Length.ShouldBe(2);
            methodConvertTextURLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var str = this.CreateType<string>();
            var strDisplay = this.CreateType<string>();
            var methodConvertTextURLParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfConvertTextURL = { str, strDisplay };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertTextURL, parametersOfConvertTextURL, methodConvertTextURLParametersTypes);

            // Assert
            parametersOfConvertTextURL.ShouldNotBeNull();
            parametersOfConvertTextURL.Length.ShouldBe(2);
            methodConvertTextURLParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var methodConvertTextURLParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertTextURL, methodConvertTextURLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertTextURLParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var methodConvertTextURLParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertTextURL, methodConvertTextURLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertTextURLParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertTextURL, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertTextURL) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Social_ConvertTextURL_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertTextURL);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertTextURL, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}